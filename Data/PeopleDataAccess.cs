using System.Linq;
using TestAPI.Data.Models;

namespace TestAPI.Data
{
    public class PeopleDataAccess
    {
        private ExpensesDbContext _context;

        public PeopleDataAccess(ExpensesDbContext context)
        {
            _context = context;
        }

        public People GetPerson(int id) 
        {
            return _context.People.FirstOrDefault(person => 
                                                  person.PersonId == id);
        }
    }
}
