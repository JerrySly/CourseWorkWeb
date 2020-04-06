using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkWeb.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { set; get; }
        public string Email { set; get; }
        public string Password { get; set; }
    }
}
