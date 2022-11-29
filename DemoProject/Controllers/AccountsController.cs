using DemoProject.Interfaces;
using DemoProject.Models;
using DemoProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        

        private readonly ILogger<AccountsController> _logger;
        private readonly IAcountService _accountService;

        public AccountsController(ILogger<AccountsController> logger, IAcountService accountService )
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IEnumerable<AccountDTO>> Get()
        {
            return await _accountService.GetAccounts();
        }

        [HttpGet("{id}")]
        public async Task<AccountDetailsDTO> GetDetails( int id)
        {
            return await _accountService.GetAccountDetails(id);
        }
    }
}