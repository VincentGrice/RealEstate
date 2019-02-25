using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Models;
using RealEstate.Models.ViewModel;

namespace RealEstate.Controllers
{
    public class HomesController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly HostingEnvironment _hostingEnvironment;

        [BindProperty]
        public HomesViewModel HomesVM { get; set; }

        public HomesController(ApplicationDbContext db, HostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            HomesVM = new HomesViewModel()
            {
                Homes = new Models.Homes()
            };
        }

        public async Task<IActionResult> Index()
        {
            var homes = _db.Homes;
            return View(await homes.ToListAsync());
        }

        //GET : Homes Create
        public IActionResult Create()
        {
            ViewData["Title"] = "Create";
            return View(HomesVM);
        }

        //POST : Homes Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if (!ModelState.IsValid)
            {
                return View(HomesVM);
            }

            _db.Homes.Add(HomesVM.Homes);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        //GET : Details
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            HomesVM.Homes = await _db.Homes.SingleOrDefaultAsync(m => m.Id == id);
            
                if(HomesVM.Homes == null)
            {
                return NotFound();
            }

            return View(HomesVM);
        }

        //GET : Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            HomesVM.Homes = await _db.Homes.SingleOrDefaultAsync(m => m.Id == id);

            if(HomesVM.Homes == null)
            {
                return NotFound();
            }

            return View(HomesVM);
        }

        //Edit : POST
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                var homeFromDb = _db.Homes.Where(m => m.Id == HomesVM.Homes.Id).FirstOrDefault();

                homeFromDb.HouseImageUrl = HomesVM.Homes.HouseImageUrl;
                homeFromDb.HouseImageUrl1 = HomesVM.Homes.HouseImageUrl1;
                homeFromDb.HouseImageUrl2 = HomesVM.Homes.HouseImageUrl2;
                homeFromDb.HouseImageUrl3 = HomesVM.Homes.HouseImageUrl3;
                homeFromDb.HouseImageUrl4 = HomesVM.Homes.HouseImageUrl4;
                homeFromDb.HouseImageUrl5 = HomesVM.Homes.HouseImageUrl5;
                homeFromDb.HouseImageUrl6 = HomesVM.Homes.HouseImageUrl6;
                homeFromDb.Bathrooms = HomesVM.Homes.Bathrooms;
                homeFromDb.Bedrooms = HomesVM.Homes.Bedrooms;
                homeFromDb.EstMortgage = HomesVM.Homes.EstMortgage;
                homeFromDb.Price = HomesVM.Homes.Price;
                homeFromDb.Type = HomesVM.Homes.Type;
                homeFromDb.YearBuilt = HomesVM.Homes.YearBuilt;

                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(HomesVM);
        }

        //GET : Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            HomesVM.Homes = await _db.Homes.SingleOrDefaultAsync(m=>m.Id == id);

            if(HomesVM.Homes == null)
            {
                return NotFound();
            }

            return View(HomesVM);
        }

        //POST : Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Homes homes = await _db.Homes.FindAsync(id);
            
            if(homes == null)
            {
                return NotFound();
            }
            else
            {
                _db.Homes.Remove(homes);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
        }
    }
}