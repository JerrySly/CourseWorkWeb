using CourseWorkWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CourseWorkWeb.Controllers
{
    public class AuthorizationController:Controller
    {
        private ApplicationContext _db;
        public AuthorizationController(ApplicationContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
       /*public  async Task<IActionResult> Index()
        {
            return View( await _db.Users.ToListAsync());
        }*/
     
        public IActionResult Registred()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Registred(User user)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return  RedirectToAction("Index");

        }
    }
}
