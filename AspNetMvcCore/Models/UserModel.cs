using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcCore.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This is required")]
        public string JobTitle { get; set; }
    }
}
