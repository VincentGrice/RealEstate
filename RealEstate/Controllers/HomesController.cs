using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
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
    }
}