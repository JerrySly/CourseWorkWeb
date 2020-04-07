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
                        Id = 1,
                        Name = "Отжимания",
                        ShortDesc = "Отжимания от пола",
                        Instruction = "Исходное положение – упор лежа. Согнуть руки в локтях, " +
                        "опустив при этом тело до параллели с полом, после чего, напрягая тело, " +
                        "медленно разогнуть руки, вернувшись в исходное положение.",
                        Img = "https://avatars.mds.yandex.net/get-zen_doc/1540250/pub_5d8621136d29c100addda47a_5d86250b04af1f00ad9d03dc/scale_1200",
                        IsFavourite = false,
                        Level = 0.2,


                    },
                   new Exercise
                   {
                       Id = 2,
                       Name = "Махи ногами",
                       ShortDesc = "Махи ногами вперёд",
                       Instruction = "Исходное положение стоя. Махи ногами с вытягиванием рук вперед " +
                        "(попеременно) и касанием носком кончика ладоней.",
                       Img = "https://24smi.org/public/media/resize/800x-/person/2018/05/17/ntqzdkjv4kaw-dasha-vasnetsova.jpeg",
                       IsFavourite = false,
                       Level = 0.2,

                   },
                   new Exercise
                   {
                       Id = 3,
                       Name = "Наклоны с гантелями",
                       ShortDesc = "Наклон туловища с гантелями вперёд",
                       Instruction = "Исходное положение – ноги врозь. С выдохом наклониться вперед, со вздохом вернуться в исходное положение. Колени не сгибать.",
                       Img = "https://www.rutv.net/static/papiny-dochki/2-sezon/4-seriya-kadr-5.jpg",
                       IsFavourite = false,
                       Level = 0.2,

                   }
                 );

                context.SaveChanges();
            }
        }
    }
}
