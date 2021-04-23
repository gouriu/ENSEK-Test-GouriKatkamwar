namespace ENSEK.DataAccess.Access
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Common.Interfaces;
    using Common.Models;
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class MeterReadingsAccess : IMeterReadingsAccess
    {
        private readonly MeterReadingsDbContext _dbContext;
        private readonly IMapper _mapper;

        public MeterReadingsAccess(MeterReadingsDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task AddMeterReadingAsync(MeterReadingModel meterReading)
        {
            var meterReadingEntity = _mapper.Map<MeterReadingEntity>(meterReading);
            _dbContext.MeterReadings.Add(meterReadingEntity);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<MeterReadingModel> GetAllMeterReading()
        {
            var meterReadingEntities = _dbContext.MeterReadings.AsNoTracking();
            return _mapper.Map<IEnumerable<MeterReadingModel>>(meterReadingEntities);
        }

        public IEnumerable<MeterReadingModel> GetAllMeterReadingsByAccountId(int accountId)
        {
            var meterReadingEntities = _dbContext.MeterReadings.Where(n => n.AccountId == accountId).AsNoTracking();
            return _mapper.Map<IEnumerable<MeterReadingModel>>(meterReadingEntities);
        }
    }
}
