using Microsoft.AspNetCore.Mvc;
using TestAPI.Data;
using TestAPI.Data.Models;

namespace TestAPI.Controllers
{
    [Route("[controller]")]
    public class AccountTypesController : Controller
    {
        private ExpensesDbContext _context;
        private AccountTypesDataAccess _accountTypesDa;

        public AccountTypesController(ExpensesDbContext context)
        {
            _context = context;
            _accountTypesDa = new AccountTypesDataAccess(_context);
        }

        [HttpPost]
        public int Create([FromBody]AccountTypes accountType) 
        {
            return _accountTypesDa.Create(accountType);
        }
    }
}
