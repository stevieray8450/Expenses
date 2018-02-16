using System.ComponentModel.DataAnnotations;

namespace TestAPI.Data.Models
{
    public class ExpenseTypes
    {
        [Key]
        public int Expense_TypeId { get; set; }
        public string Expense_Type { get; set; }
    }
}
