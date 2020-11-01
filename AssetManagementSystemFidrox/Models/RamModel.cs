using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models
{
    public class RamModel
    {
        [Key]
        public int RAM_ID { get; set; }
        public string RAM { get; set; }
    }
}
