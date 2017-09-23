using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCBilar.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCBilar.Controllers
{
    public class CarsController : Controller
    {
        MVCBilarDbContext context;

        public CarsController(MVCBilarDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new CarsCreateVM();
            model.DoorItems = new SelectListItem[]
            {
                new SelectListItem { Text = "2", Value = "1" },
                new SelectListItem { Text = "4", Value = "2" },
                new SelectListItem { Text = "6", Value = "3" }
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CarsCreateVM car)
        {
            if (!ModelState.IsValid)
                return View(car);

            context.AddCar(car);

            return RedirectToAction(nameof(CarsController.Index));
        }

        public IActionResult Details(int id)
        {
            return View(context.GetCarByID(id));
        }
    }
}
