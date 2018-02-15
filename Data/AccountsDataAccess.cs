using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TestAPI.Data.Models;

namespace TestAPI.Data
{
    public class AccountsDataAccess : BaseDa<Accounts>
    {
        private ExpensesDbContext _context;

        public AccountsDataAccess(ExpensesDbContext context)
        {
            _context = context;
        }

        public override IEnumerable<Accounts> List()
        {
            return _context.Accounts.Include(account => account.AccountType);
        }
    }
}