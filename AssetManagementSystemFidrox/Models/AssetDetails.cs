using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models
{ 
    public class AssetDetails
    {
        [Key]
        public int AssetId { get; set; }
        [Display(Name = "Asset No")]
        [Required]
        [StringLength(50)]
        public string Asset_No { get; set; }
        [Display(Name = "Asset Name")]
        [StringLength(50)]
        public string Asset_name { get; set; }
        [Display(Name = "Asset Model")]
        [StringLength(50)]
        public string Asset_model_no { get; set; }
        [Display(Name = "Assert Processor")]
        [StringLength(50)]
        public string AstProcessor { get; set; }
        [Display(Name = "Asset Type")]
        [StringLength(50)]
        [Required]
        public string Asset_type { get; set; }
        [Display(Name = "Accessories")]
        [StringLength(150)]
        public string Asset_accessories { get; set; }

        [Display(Name = "Ram GB")]
        [Required]
        public string Asset_Ram_GB { get; set; }
        [Display(Name = "HardDisk GB")]
        [Required]
        public string Asset_HardDisk_GB { get; set; }
        [Display(Name = "LicenseKey")]
        [StringLength(50)]
        public string Asset_LicenseKey { get; set; }
        [Display(Name = "Mouse")]
        public string Asset_Mouse { get; set; }
        [Display(Name = "Laptop Bag")]
        [StringLength(50)]
        public string Asset_Bag_Name { get; set; }


        [Display(Name = "Graphics Crd")]
        public string Asset_graphics_crd_GB { get; set; }
        [Display(Name = "Charger")]
        public string Asset_Charger { get; set; }
        [Display(Name = "Asset OS")]
        public string Asset_OS { get; set; }
        [Display(Name = "purchase Dt")]
        public string Asset_purchase_dt { get; set; }
        [Display(Name = "purchase Place")]
        [StringLength(50)]
        public string Asset_puch_place { get; set; }
        [Display(Name = "Asset Price")]
        [StringLength(50)]
        public string Asset_price { get; set; }
        [Display(Name = "purchase Bill No")]
        [StringLength(50)]
        public string Asset_purchase_bill_no { get; set; }
        [Display(Name = "Availabality")]
        public string Asset_Status { get; set; }
        [Display(Name = "Remarks")]
        [StringLength(250)]
        public string Asset_Remarks { get; set; }


        public RamModel ramModel { get; set; }
        public HardDiskModel hardDiskModel { get; set; }
        //public OperatingSystem operatingSystem { get; set; }
        public ItemsBrand itemsBrand { get; set; }
        public GraphicsCardModel graphicsCard { get; set; }
    }
}
