using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models
{
    public class GraphicsCardModel
    {
        [Key]
        public int Graphics_CardId { get; set; }
        public string Graphics_Card_GC { get; set; }
    }
}
