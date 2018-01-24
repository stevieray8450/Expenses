using System.ComponentModel.DataAnnotations;

namespace TestAPI.Data.Models
{
    public class People
    {
        [Key]
        public int PersonId { get; set; }
        public string Person_Name { get; set; }
    }
}
 