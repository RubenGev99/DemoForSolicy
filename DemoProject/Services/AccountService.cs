using AutoMapper;
using DemoProject.DAL;
using DemoProject.Interfaces;
using DemoProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Services
{
    public class AccountService : IAcountService
    {
        private readonly AccountsContext _dbContext;
        private readonly IMapper _mapper;
        public AccountService(AccountsContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AccountDTO>> GetAccounts()
        {
            var accounts = await _dbContext.Accounts.Include(a=>a.Owner).ToListAsync();
            return _mapper.Map<IEnumerable<AccountDTO>>(accounts);
        }
        public async Task<AccountDetailsDTO> GetAccountDetails(int id)
        {
            var account = await _dbContext.Accounts.Include(a => a.Owner).Where(a=>a.Id == id).SingleAsync();
            return _mapper.Map<AccountDetailsDTO>(account);
        }
    }
}
