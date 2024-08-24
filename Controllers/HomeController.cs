using AjaxCallingInAspNetCoreMVC.Data;
using AjaxCallingInAspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxCallingInAspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly FleetManagementContext _context;

        public HomeController(FleetManagementContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var vehicles = _context.Vehicles.ToList();
            return View(vehicles);
        }

        [HttpPost]
        public IActionResult Create(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Vehicles.Add(vehicle);
                _context.SaveChanges();
                return Json(vehicle);
            }
            return BadRequest(ModelState);
        }
    }
}
