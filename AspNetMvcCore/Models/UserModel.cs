using System.ComponentModel.DataAnnotations;

namespace AspNetMvcCore.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "This is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This is required")]
        public string JobTitle { get; set; }
    }
}
