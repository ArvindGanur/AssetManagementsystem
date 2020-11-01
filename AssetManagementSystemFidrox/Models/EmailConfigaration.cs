using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models
{
    public class EmailConfigaration
    {
        [Required]
        [StringLength(100)]
        [Display(Name ="To")]
        public string To { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name ="From")]
        public string From { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name ="Subject")]
        public string Subject { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Email Body")]
        public string Body { get; set; }
    }
}
