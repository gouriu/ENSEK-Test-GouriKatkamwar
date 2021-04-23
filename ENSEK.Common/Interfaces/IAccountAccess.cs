namespace ENSEK.Common.Interfaces
{
    using System.Threading.Tasks;
    using odels;

    public interface IAccountAccess
    {
        Task<AccountModel> GetAccountById(int accountId);
    }
}