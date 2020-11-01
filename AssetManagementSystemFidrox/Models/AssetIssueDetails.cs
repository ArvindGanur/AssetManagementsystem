using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models
{
    public class AssetIssueDetails
    {
        [Key]
        public int IssueID { get; set; }
        [Display(Name = "Emp ID")]
        [Required]
        public int Fdx_Emp_Id { get; set; }
        [Display(Name = "Emp Name")]
        [StringLength(50)]
        public string Fdx_Emp_Name { get; set; }
        [Display(Name = "Work Location")]
        public string Fdx_Emp_wrk_loc { get; set; }
        [Display(Name = "Designamtion")]
        [StringLength(50)]
        public string Fdx_Emp_Designation { get; set; }
        [Display(Name = "Recived Item")]
        public string Fdx_Emp_Recived_item { get; set; }
        [Display(Name = "Email Id")]
        [Required]
        [StringLength(50)]
        public string Fdx_Emp_EmailId { get; set; }
        [Display(Name = "Replace Item")]
        public string Fdx_Emp_Replace_Item { get; set; }
        [Display(Name = "Acknowledge")]
        [Required]
        public string Fdx_Emp_Acknowledge { get; set; }
        [Display(Name = "Asset No")]
        [Required]
        [StringLength(50)]
        //[ForeignKey("Asset_No")]
        public string Fdx_Asset_no { get; set; }
        [Display(Name = "Issued Dt")]
        [Required]
        public string Fdx_Asset_issued_dt { get; set; }
        [Display(Name = "Return Dt")]
        public string Fdx_Asset_return_dt { get; set; }
        [Display(Name = "Availabelity")]
        [StringLength(10)]
        public string Fdx_Asset_Status { get; set; }
        [Display(Name = "Remarks")]
        [StringLength(250)]
        public string Fdx_Asset_Remarks { get; set; }
        [Display(Name = "New/Old")]
        public string Fdx_Asset_New_Old { get; set; }
        [Display(Name = "Model Name")]
        [StringLength(150)]
        public string Fdx_Asset_Model_name { get; set; }

        public AssetDetails assetDetails { get; set; }
    }
}
