using System;
using System.ComponentModel.DataAnnotations;

namespace TestAPI.Data.Models
{
    public class Expenses
    {
        [Key]
        public long ExpenseId { get; set; }
        public int Expense_TypeId { get; set; }
        public ExpenseTypes ExpenseType { get; set; }
        public double Expense_Amount { get; set; }
        public DateTime Expense_Date { get; set; }
        public int AccountId { get; set; }
        public Accounts Account { get; set; }
    }
}
