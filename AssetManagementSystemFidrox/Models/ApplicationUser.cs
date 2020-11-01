using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models
{
    public class ApplicationUser :IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LasrName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [StringLength(12)]
        public string PhoneNumber2 { get; set; }

        public bool IsAdmin { get; set; }



    }
}
