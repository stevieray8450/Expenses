using System;
using System.ComponentModel.DataAnnotations;

namespace TestAPI.Data.Models
{
    public class AccountTypes
    {
        [Key]
        public int? Account_TypeId { get; set; }
        public string Account_Type { get; set; }
    }
}
