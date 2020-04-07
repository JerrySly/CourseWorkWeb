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
        [HttpPost]
        public  IActionResult Index(string Login,string Password)
        {
            bool isRegistred = false;
            foreach (User user in _db.Users)
            {
                if (user.Login == Login && user.Password == Password)
                {
                    isRegistred = true;
                    break;
                }
            }
            if (isRegistred) return Redirect("/General");
            return RedirectToAction("Index");

        }

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
