using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkWeb.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Instruction { get; set; }
        public string Img { get; set; }
        public double Level { get; set; }
        public bool IsFavourite { get; set; }
    }
}
