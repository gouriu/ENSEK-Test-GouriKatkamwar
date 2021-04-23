namespace ENSEK.DataAccess.Access
{
    using System.Threading.Tasks;
    using AutoMapper;
    using Common.Interfaces;
    using Common.odels;
    using Microsoft.EntityFrameworkCore;

    public class AccountAccess : IAccountAccess
    {
        private readonly MeterReadingsDbContext _dbContext;
        private readonly IMapper _mapper;

        public AccountAccess(MeterReadingsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<AccountModel> GetAccountById(int accountId)
        {
            var accountEntity = await _dbContext.Accounts.SingleOrDefaultAsync(t => t.AccountId == accountId);
            return _mapper.Map<AccountModel>(accountEntity);
        }
    }
}
