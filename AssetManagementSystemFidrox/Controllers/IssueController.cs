using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using AssetManagementSystemFidrox.AssetDbContextEF;
using AssetManagementSystemFidrox.Models;
using AssetManagementSystemFidrox.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssetManagementSystemFidrox.Controllers
{
    //[Authorize(Roles = "Admin,Executive")]
    public class IssueController : Controller
    {

        private readonly AssetDbContext _db;

        [BindProperty]
        public AssetViewModel AssetVM { get; set; }

        public IssueController(AssetDbContext db)
        {
            _db = db;
            AssetVM = new AssetViewModel()
            {
                AssetDetails = _db.AssetDetails.ToList(),
                AssetIssueDetails = new AssetIssueDetails()
            };
        }

        public IActionResult Index()
        {
            //return View(_db.AssetIssueDetails.ToList());
            var model = _db.AssetIssueDetails.Include(m => m.assetDetails);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AssetIssueDetails assetIssueDetails)
        {
            if (ModelState.IsValid)
            {
                _db.Add(assetIssueDetails);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(assetIssueDetails);
        }

        public IActionResult Edit(int Fdx_Emp_Id)
        {
            AssetVM.AssetIssueDetails = _db.AssetIssueDetails.Include(m => m.assetDetails).SingleOrDefault(m => m.Fdx_Emp_Id == Fdx_Emp_Id);
            if (AssetVM.AssetIssueDetails==null)
            {
                return NotFound();
            }
            return View(AssetVM);

        }

        [HttpPost]
        public IActionResult Edit()
        {
            if (!ModelState.IsValid)
            {
                return View(AssetVM);

            }
            _db.Update(AssetVM.AssetIssueDetails);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int AssetId)
        {
            AssetIssueDetails assetIssueDetails = _db.AssetIssueDetails.Find(AssetId);
            if (assetIssueDetails == null)
            {
                return NotFound();
            }
            _db.AssetIssueDetails.Remove(assetIssueDetails);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));


        }

       
    }
}
