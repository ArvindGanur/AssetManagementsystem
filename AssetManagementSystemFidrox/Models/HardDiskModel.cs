using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models
{
    public class HardDiskModel
    {
        [Key]
         public int Hard_DiskId { get; set; }

        public string Hard_Disk_HD { get; set; }
    }

}
