using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Data;
using TestAPI.Data.Models;

namespace TestAPI.Controllers
{
    [Route("[controller]")]
    public class AccountsController : Controller
    {
        private IBaseDa<Accounts> _accountsDa;

        public AccountsController(IBaseDa<Accounts> accountsDa)
        {
            _accountsDa = accountsDa;
        }

        [HttpGet]
        public IEnumerable<Accounts> List()
        {
            return _accountsDa.List();
        }
    }
}
