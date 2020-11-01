using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models
{
    public class ItemsBrand
    {
        [Key]
        public int brandsId { get; set; }
        public string brands_Name { get; set; }
    }
}
