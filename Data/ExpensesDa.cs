using System;
using TestAPI.Data.Models;

namespace TestAPI.Data
{
    public class ExpensesDa : BaseDa<Expenses>, IExpensesDa
    {
        private ExpensesDbContext _context;

        public ExpensesDa(ExpensesDbContext context)
        {
            _context = context;
        }

        public bool UploadFile(object csvFile)
        {
            var file = csvFile;
            return true;
        }
    }
}
