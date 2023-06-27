using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SuperShop.Models
{
    public class ChangeUserViewModel
    {
        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
    }
}
