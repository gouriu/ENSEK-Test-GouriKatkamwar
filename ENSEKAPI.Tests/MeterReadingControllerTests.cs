using System.Net;
using System.Threading.Tasks;
using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace NotificationsTests
{
    using System.Collections.Generic;
    using ENSEK.Common.Interfaces;
    using ENSEK.Common.Models;
    using ENSEK.Services;
    using ENSEKApi.Controllers;
    using FluentAssertions;
    using Microsoft.Extensions.Configuration;

    public class MeterReadingControllerTests
    {
        private readonly Mock<ICSVService> _csvServiceMock = new Mock<ICSVService>();
        private readonly Mock<IMeterReadingService> _meterReadingServiceMock = new Mock<IMeterReadingService>();
        private readonly MeterReadingsController _meterReadingsController;
        private readonly Fixture _fixture = new Fixture();
        private readonly Mock<ILogger<MeterReadingsController>> _loggerMock= new Mock<ILogger<MeterReadingsController>>();

        public MeterReadingControllerTests()
        {
            
            var inMemorySettings = new Dictionary<string, string> {
                {"CsvPath", "Path"}
            };

            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings)
                .Build();
            _meterReadingsController = new MeterReadingsController(_meterReadingServiceMock.Object, _csvServiceMock.Object, configuration);
        }

        [Fact]
        public async void UploadMeterReadings_WhenCalled_ReturnsOkWithCountOutput()
        {
            var readings =_fixture.CreateMany<MeterReadingModel>();
            var csvPath = _fixture.Create<string>();
            
            _csvServiceMock.Setup(n => n.ReadCsvFileForMeterReadings(It.IsAny<string>()))
                .Returns(readings);
            
            var countOutput = _fixture.Create<ReadingUploadOutput>();
            _meterReadingServiceMock.Setup(m =>
                    m.AddMeterReadingAsync(It.Is<IEnumerable<MeterReadingModel>>(r => r == readings)))
                .Returns(Task.FromResult(countOutput));

            var result = await _meterReadingsController.UploadMeterReadings();

            Assert.IsType<OkObjectResult>(result);
            var output = result as OkObjectResult;
            output.Value.Should().BeEquivalentTo(countOutput);
        }
    }
}
