using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Data;
using TestAPI.Data.Models;

namespace TestAPI.Controllers
{
    [Route("[controller]")]
    public class AccountsController : Controller
    {
        private ExpensesDbContext _context;
        private IBaseDa<Accounts> _accountsDa;

        public AccountsController(ExpensesDbContext context, IBaseDa<Accounts> accountsDa)
        {
            _context = context;
            _accountsDa = accountsDa;
        }

        [HttpGet]
        public IEnumerable<Accounts> List()
        {
            return _accountsDa.List();
        }
    }
}
