using DemoProject.Models;

namespace DemoProject.Interfaces
{
    public interface IAcountService
    {
        public Task<IEnumerable<AccountDTO>> GetAccounts();
        public Task<AccountDetailsDTO> GetAccountDetails(int id);
    }
}
