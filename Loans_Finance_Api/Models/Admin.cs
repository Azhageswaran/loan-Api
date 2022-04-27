using System.ComponentModel.DataAnnotations;

namespace Loans_Finance_Api.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Required]
        public string AdminName { get; set; }

        [Required, MaxLength(20)]
        public string Password { get; set; }
    }
}
