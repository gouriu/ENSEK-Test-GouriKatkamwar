namespace ENSEKApi.Controllers
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using ENSEK.Common.Interfaces;
    using ENSEK.Common.Models;
    using ENSEK.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    [Route("api/meter-readings")]
    [ApiController]
    public class MeterReadingsController : ControllerBase
    {
        private readonly IMeterReadingService _meterReadingService;
        private readonly ICSVService _csvService;
        private readonly IConfiguration _configuration;
        private string _csvPath;

        public MeterReadingsController(IMeterReadingService meterReadingService, ICSVService csvService,IConfiguration configuration)
        {
            _meterReadingService = meterReadingService;
            _csvService = csvService;
            _configuration = configuration;
            _csvPath = _configuration.GetValue<string>("CsvPath");
        }

        [Route("")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MeterReadingModel>), (int)HttpStatusCode.OK)]
        public ActionResult Get()
        {
            var meterReadings = _meterReadingService.GetAllMeterReadings();
            return Ok(meterReadings);
        }

        [Route("~/api/accounts/{id}/meter-readings")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MeterReadingModel>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public ActionResult GetByAccountId(int accountId)
        {
            if (accountId == 0)
            {
                return BadRequest("UserId can't be 0");
            }

            var meterReadings = _meterReadingService.GetAllMeterReadingsByAccountId(accountId);
            return Ok(meterReadings);
        }

        [Route("meter-reading-uploads")]
        [HttpPost]
        [ProducesResponseType(typeof(ReadingUploadOutput),(int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> UploadMeterReadings()
        {
            // read from csv
            var readings = _csvService.ReadCsvFileForMeterReadings(_csvPath);
            
            // add to db
           var output = await _meterReadingService.AddMeterReadingAsync(readings);
           return Ok(output);
        }
    }
}