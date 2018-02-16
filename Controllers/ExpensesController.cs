using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using TestAPI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace TestAPI.Controllers
{
    
    [Route("[controller]")]
    public class ExpensesController : Controller
    {
        private IExpensesDa _expensesDa;

        public ExpensesController(IExpensesDa expensesDa)
        {
            _expensesDa = expensesDa;
        }

        [HttpGet]
        public string Get()
        {
            return "get!";
        }

        [HttpPost]
        public bool UploadFile([FromBody] object csvFile)
        {
            return _expensesDa.UploadFile(csvFile);
        }
    }
}
