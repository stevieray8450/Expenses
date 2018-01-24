using System;
using System.Collections.Generic;
using TestAPI.Data.Models;

namespace TestAPI.Data
{
    public class AccountsDataAccess
    {
        private ExpensesDbContext _context;

        public AccountsDataAccess(ExpensesDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Accounts> List()
        {
            return _context.Accounts;
        }
    }
}
