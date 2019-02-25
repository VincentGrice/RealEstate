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
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public AppointmentViewModel AppointmentVM { get; set; }

        public AppointmentsController(ApplicationDbContext db)
        {
            _db = db;

        }

        public async Task<IActionResult> Index()
        {
            var appointments = _db.Appointments;
            return View(await appointments.ToListAsync());
        }

        //GET : Create Appointment
        public IActionResult Create()
        {
            return View(AppointmentVM);
        }
        

        //POST : Homes Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if (!ModelState.IsValid)
            {
                return View(AppointmentVM);
            }

            _db.Appointments.Add(AppointmentVM.Appointments);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}