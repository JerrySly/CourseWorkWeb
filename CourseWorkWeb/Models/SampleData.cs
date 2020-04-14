using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseWorkWeb.Models;

namespace CourseWorkWeb.Models
{
    public static class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {

            if (!context.Exercises.Any())
            {
                context.Exercises.AddRange(
                    new Exercise
                    {
                        
                        Name = "Отжимания",
                        ShortDesc = "Отжимания от пола.....",
                        Instruction = "Исходное положение – упор лежа. Согнуть руки в локтях, " +
                        "опустив при этом тело до параллели с полом, после чего, напрягая тело, " +
                        "медленно разогнуть руки, вернувшись в исходное положение.",
                        Img = "/pic/DSC_0100.jpg",
                        IsFavourite = false,
                        Level = 0.2,


                    },
                   new Exercise
                   {
                       
                       Name = "Махи ногами",
                       ShortDesc = "Махи ногами вперёд",
                       Instruction = "Исходное положение стоя. Махи ногами с вытягиванием рук вперед " +
                        "(попеременно) и касанием носком кончика ладоней.",
                       Img = "/pic/DSC_0088.jpg",
                       IsFavourite = false,
                       Level = 0.2,

                   },
                   new Exercise
                   {
                       
                       Name = "Наклоны с гантелями",
                       ShortDesc = "Наклон туловища с гантелями вперёд",
                       Instruction = "Исходное положение – ноги врозь. С выдохом наклониться вперед, со вздохом вернуться в исходное положение. Колени не сгибать.",
                       Img = "/pic/DSC_0085.jpg",
                       IsFavourite = false,
                       Level = 0.2,

                   }
                 );

                context.SaveChanges();
            }
        }
    }
}
