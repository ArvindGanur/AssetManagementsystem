using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetManagementSystemFidrox.Models;
using AssetManagementSystemFidrox.AssetDbContextEF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssetManagementSystemFidrox.Controllers
{

   // [Authorize(Roles ="Admin,Executive")]
    public class AssetDetailsController : Controller
    {

        private readonly AssetDbContext _db;

        public AssetDetailsController(AssetDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.AssetDetails.ToList());
        }

        public IActionResult NotFoundPage()
        {
            return Content("There is No data");
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<OperatingSystemModel> operatingSystems = _db.OperatingSystemModels.ToList();
            ViewBag.operatingSystems = new SelectList(operatingSystems, "OSId", "Operating_System");

            List<GraphicsCardModel> graphicsCardModel = _db.GraphicsCardModels.ToList();
            ViewBag.graphicsCardModel = new SelectList(graphicsCardModel, "Graphics_CardId", "Graphics_Card_GC");

            List<HardDiskModel> hardDiskModels = _db.HardDiskModels.ToList();
            ViewBag.hardDiskModels = new SelectList(operatingSystems, "Hard_DiskId", "Hard_Disk_HD");

            List<ItemsBrand> itemsBrands = _db.ItemsBrands.ToList();
            ViewBag.itemsBrands = new SelectList(itemsBrands, "brandsId", "brands_Name");

            List<RamModel> ramModels = _db.RamModels.ToList();
            ViewBag.ramModels = new SelectList(ramModels, "RAM_ID", "RAM");


            return View();
        }

        [HttpPost]
        public IActionResult Create(AssetDetails assetDetails)
        {

            if (ModelState.IsValid)
            {
                _db.Add(assetDetails);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(assetDetails);
        }


        
        public IActionResult Delete(int AssetId)
        {
            var make = _db.AssetDetails.Find(AssetId);
            if (make == null)
            {
                return NotFound();
            }
            _db.AssetDetails.Remove(make);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


       // int AssetId = 1;
        [HttpGet]
        public IActionResult Edit(int AssetId)
        {
            var make = _db.AssetDetails.Find(AssetId);
            if (make == null)
            {
                return NotFound();
            }
            return View(make);
        }


        [HttpPost]
        public IActionResult Edit(AssetDetails assetDetails)
        {
            if (ModelState.IsValid)
            {
                _db.Update(assetDetails);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(assetDetails);

        }

    }
}
