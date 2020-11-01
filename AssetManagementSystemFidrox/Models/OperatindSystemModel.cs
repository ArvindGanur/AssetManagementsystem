using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models
{
    public class OperatingSystemModel
    {
        [Key]
        public int OSId { get; set; }
        public string Operating_System { get; set; }
    }
}
