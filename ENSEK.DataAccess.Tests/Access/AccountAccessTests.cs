using AutoFixture;
using AutoMapper;
using FluentAssertions;
using Moq;
using Xunit;

namespace Notifications.DataAccess.Tests.Access
{
    using ENSEK.Common.odels;
    using ENSEK.DataAccess.Access;
    using ENSEK.DataAccess.Entities;

    public class AccountAccessTests : IClassFixture<MeterReadingSeedDataFixture>
    {
        private readonly Mock<IMapper> _mapperMock = new Mock<IMapper>();
        private readonly Fixture _fixture = new Fixture();
        private readonly MeterReadingSeedDataFixture _dataFixture;

        public AccountAccessTests(MeterReadingSeedDataFixture dataFixture)
        {
            _dataFixture = dataFixture;
        }

        [Fact]
        public async void GetAccountById_WhenCalled_ReturnsAccount()
        {
            // Arrange
            var expectedAccount = _fixture.Create<AccountModel>();
            _mapperMock.Setup(m => m.Map<AccountModel>(It.IsAny<AccountEntity>()))
                .Returns(expectedAccount);

            var sut = new AccountAccess(_dataFixture.Context, _mapperMock.Object);

            //Act
            var result = await sut.GetAccountById(1);

            //Assert
            expectedAccount.Should().BeEquivalentTo(result);
        }
    }
}
