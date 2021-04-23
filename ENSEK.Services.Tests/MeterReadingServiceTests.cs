using Moq;
using Xunit;
using System.Threading.Tasks;
namespace Notifications.Services.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoFixture;
    using ENSEK.Common.Interfaces;
    using ENSEK.Common.Models;
    using ENSEK.Common.odels;
    using ENSEK.Services;
    using FluentAssertions;
    using FluentValidation;
    using FluentValidation.Results;

    public class MeterReadingServiceTests
    {
        private readonly Mock<IMeterReadingsAccess> _meterReadingAccessMock = new Mock<IMeterReadingsAccess>();
        private readonly Mock<IAccountAccess> _accountAccessMock = new Mock<IAccountAccess>();
        private readonly Mock<IValidator<MeterReadingModel>> _validatorMock = new Mock<IValidator<MeterReadingModel>>();
        private readonly IMeterReadingService _meterReadingService;
        private readonly Fixture _fixture = new Fixture();
        public MeterReadingServiceTests()
        {
            _meterReadingService = new MeterReadingService(_meterReadingAccessMock.Object, _accountAccessMock.Object, _validatorMock.Object);
        }

        [Fact]
        public async void AddMeterReadingAsync_WhenCalled_SavesReadingsToDb()
        {
            // arrange
            var meterReadingsForAccount = _fixture.CreateMany<MeterReadingModel>();
            _meterReadingAccessMock.Setup(t => t.GetAllMeterReadingsByAccountId(It.IsAny<int>()))
                .Returns(meterReadingsForAccount);

            _meterReadingAccessMock.Setup(n => n.AddMeterReadingAsync(It.IsAny<MeterReadingModel>()))
                .Returns(Task.CompletedTask);

            var account = _fixture.Create<AccountModel>();
            _accountAccessMock.Setup(a => a.GetAccountById(It.IsAny<int>())).Returns(Task.FromResult(account));
            
            var validResult = new ValidationResult()
            {
                Errors = { },
            };
            
            _validatorMock.Setup(v => v.Validate(It.IsAny<MeterReadingModel>())).Returns(validResult);

            var readingsToAdd = new List<MeterReadingModel>()
            {
                _fixture.Build<MeterReadingModel>()
                    .With(m => m.AccountId, 1)
                    .With(m => m.MeterReadValue, "11111")
                    .With(m => m.MeterReadingDateTime, DateTime.Now)
                    .Create()
            };
            var result = await _meterReadingService.AddMeterReadingAsync(readingsToAdd);

            var expectedOutput = new ReadingUploadOutput()
            {
                ReadingsUploaded = readingsToAdd.Count(),
                UploadFailed = 0
            };
            
            result.Should().BeEquivalentTo(expectedOutput);
        }
    }
}
