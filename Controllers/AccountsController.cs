using System;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Data;

namespace TestAPI.Controllers
{
    public class AccountsController : Controller
    {
        private ExpensesDbContext _context;
        private AccountsDataAccess _accountsDa;

        public AccountsController(ExpensesDbContext context)
        {
            _context = context;
            _accountsDa = new AccountsDataAccess(_context);
        }
    }
}
