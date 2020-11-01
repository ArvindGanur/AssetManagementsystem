using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.Models.ViewModels
{
    public class AssetViewModel
    {
        public AssetIssueDetails AssetIssueDetails { get; set; }

        public IEnumerable<AssetDetails> AssetDetails { get; set; }

        
    }
}
