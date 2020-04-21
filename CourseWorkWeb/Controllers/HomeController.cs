using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CourseWorkWeb.Models;

namespace CourseWorkWeb.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        
        public IActionResult Index()
        {
            return View(db.Exercises.ToList());
        }
        
        [HttpGet]
        public IActionResult Show(int? id)
        {   
            if (id == null) return RedirectToAction("Index");
            List<Exercise> exercises = new List<Exercise>();
            Exercise ex = db.Exercises.FirstOrDefault(s => s.Id == id);
            ViewBag.exerciseId = id;
            ViewBag.exerciseName = ex.Name;
            ViewBag.exerciseInstruction = ex.Instruction;
            ViewBag.exerciseImg = ex.Img;
            ViewBag.exerciseLevel = ex.Level;
            ViewBag.exerciseShortDesc = ex.ShortDesc;
            return View();
        }
        [HttpPost]
        public string Buy()
        {
            //db.Orders.Add(order);
            // сохраняем в бд все изменения
            //db.SaveChanges();
            return "Спасибо";
        }
    }
}




