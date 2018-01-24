using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Data;
using TestAPI.Data.Models;

namespace TestAPI.Controllers
{
    [Route("[controller]")]
    public class PeopleController : Controller
    {
        private ExpensesDbContext _context;
        private PeopleDataAccess _peopleDa;

        public PeopleController(ExpensesDbContext context) 
        {
            _context = context;
            _peopleDa = new PeopleDataAccess(_context);
        }

        [HttpGet]
        public IEnumerable<People> Get()
        {
            return _context.People;
        }

        [HttpGet("{id}")]
        public People Get(int id)
        {
            return _peopleDa.GetPerson(id);
        }

        [HttpPost]
        public void Post([FromBody]People person)
        {
        }

        [HttpPut]
        public void Put([FromBody]People person)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
