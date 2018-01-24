using System;
using TestAPI.Data.Models;

namespace TestAPI.Data
{
    public class AccountTypesDataAccess
    {
        private ExpensesDbContext _context;

        public AccountTypesDataAccess(ExpensesDbContext context)
        {
            _context = context;
        }

        public int Create(AccountTypes accountType) 
        {
            _context.Add(accountType);
            _context.SaveChanges();
            return (int)accountType.Account_TypeId;
        }
    }
}
