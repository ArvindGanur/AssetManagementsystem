using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models.ViewModels
{
    public class RegisterUserViewModel
    {
        [MaxLength(50, ErrorMessage ="Can only accept upto 50 Characters")]
        [Required(ErrorMessage ="First Name is Required")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "Can only accept upto 50 Characters")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalide Email Formate")]
        [Required(ErrorMessage ="Email is Required")]
        public string  Email { get; set; }
        

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength =8, ErrorMessage ="Password must be at least 8 characters")]
        public string  Password { get; set; }

        public string ReEnterPassword { get; set; }
    }
}
