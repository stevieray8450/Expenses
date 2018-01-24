using System;
using System.ComponentModel.DataAnnotations;

namespace TestAPI.Data.Models
{
    public class Accounts
    {
        [Key]
        public int AccountId { get; set; }
        public string Account_Name { get; set; }
        public decimal Balance { get; set; }

        public int Account_TypeId { get; set; }
        public AccountTypes AccountType { get; set; }
    }
}
