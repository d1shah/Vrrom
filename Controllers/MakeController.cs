using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vroom.AppDbContext;
using vroom.Models;

namespace Vroom.Controllers
{
    public class MakeController : Controller
    {
        private readonly VroomDbContext _db;

        public MakeController(VroomDbContext db)
        {
            _db = db;
        }
            public IActionResult Index()
        {
            return View(_db.Makes.ToList());

        }
        // get
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Make make)
        {
            if (ModelState.IsValid)
            {
                _db.Add(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var make = _db.Makes.Find(id);
            if (make == null)
            {
                return NotFound();
            }
            _db.Makes.Remove(make);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var make = _db.Makes.Find(id);
            if (make == null)
            {
                return NotFound();
            }
            return View(make);
        }

        [HttpPost]
        public IActionResult Edit(Make make)
        {
            if (ModelState.IsValid)
            {
                _db.Update(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);

        }





        //[Route("Make")]
        //[Route("Make/Bikes")]

        //public IActionResult Bikes()
        //{
        //    Make make = new Make { Id = 1, Name = "Harley" };
        //    return View(make);
        //}

        ////[Route("make / bikes /{ year: int:length(4)}/{ month: int:range(1.13)}")]
        //[Route("make / bikes /year/ month")]
        //public IActionResult ByYearMonth(int year, int month)
        //{
        //    return Content(year + ";" + month);
        //}
    }
}
