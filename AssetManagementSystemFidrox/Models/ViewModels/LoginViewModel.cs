using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models.ViewModels
{
    public class LoginViewModel
    {
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalide Email Formate")]
        [Required(ErrorMessage ="Email is Required")]
        public  string Email { get; set; }

        [Required(ErrorMessage ="Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool  RememberMe { get; set; }
    }
}
