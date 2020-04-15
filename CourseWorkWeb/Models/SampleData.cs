﻿using System;
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
                        ShortDesc = "Отжимания от пола",
                        Instruction = "Для того, чтобы занять позицию для отжиманий, ложитесь на пол, руки должны"+
                        "быть на ширине плеч, спину держите ровно, так, чтобы от головы до пят образовалась прямая"+
                        "линия через ягодицы. Опускайте тело до тех пор, пока грудь не будет в сантиметре от пола, " +
                        "затем быстро поднимайтесь, полностью выпрямляя руки. Повторяйте."+
                        "Для выполнения отжиманий максимально задействуется множество групп мышц, благодаря чему ваши" +
                        "плечи становятся крепче и сильнее. Это упражнение легко делать дома. Оно подготавливает вас к " +
                        "дальнейшим большим нагрузкам на плечевой пояс, с которыми вы встретитесь в ходе занятий, как, " +
                        "например, при выполнении жима лёжа на наклонной скамье.",
                        Img = "/pic/отжимания.jpg",
                        IsFavourite = false,
                        Level = 0.4,


                    },
                   new Exercise
                   {
                       
                       Name = "Планка",
                       ShortDesc = "Планка с упором на предплечья",
                       Instruction = "Займите положение для отжиманий, но опирайтесь на предплечья, а не на руки. " +
                       "Убедитесь, что вы выпрямили спину и напрягайте мышцы живота и ягодиц. Удерживайте позицию, "+
                       "не позволяя бёдрам прогибаться. Бесконечные скручивания оказывают давление на ваш позвоночник," +
                       "и, если делать их неправильно, в итоге мышцы живота примут странные и растянутые формы.Упражнение" +
                       "«планка» прекрасно подходит для корпуса, не приводя к каким - либо травмам.Выполняя его," +
                       "вы получите плоский живот с шестью кубиками пресса.",
                       Img = "/pic/планка.jpg",
                       IsFavourite = false,
                       Level = 0.4,

                   },
                   new Exercise
                   {
                       
                       Name = "Подъём ног",
                       ShortDesc = "Подъём ног лёжа на спине",
                       Instruction = "Ложитесь на спину, руки вдоль туловища, ноги прямые. Поднимайте ноги, помогая себе мышцами"  +
                       "живота, до тех пор, пока ноги не окажутся над головой. Удерживайте корпус неподвижным, медленно опускайте ноги на пол" +
                       "и повторяйте. Удерживая неподвижным корпус и не позволяя двигаться тазу, вы активируете прямые мышцы живота(ваши внутренние" +
                       "шесть кубиков).Выбирайте это упражнение после приседаний каждый раз",
                       Img = "/pic/подъём ног лёжа.jpg",
                       IsFavourite = false,
                       Level = 0.2,

                   },
                   new Exercise
                   {

                       Name = "Приседания",
                       ShortDesc = "Классические приседания",
                       Instruction = "Приседания - одно из самых простых и эффективных упражнений. Это упражнение особенно результативно," +
                       "если выполнять его с утяжелением, но делать это можно только при условии хорошей физической подготовки, в противном" +
                       "случае можно повредить коленные суставы. Лучше всего выполнять 2-3 подхода по 10-15 раз. Исходное положение стоя, "+
                       "ноги на ширине плеч, грудь расправлена, руки вытянуты вперед, плечи отведены назад.Сгибаем ноги в коленях," +
                       "выдвигая таз назад, как будто хотите сесть на стул.Корпус слегка подать вперед, держа спину прямой.Затем возвращаемся " +
                       "в исходное положение. При выполнении не опускаем ягодицы ниже колен, в нижней точке бедра должны быть " +
                       "параллельны полу.Не отрываем пятки от пола.Спину держим прямой.Приседаем медленно.Работает большая " +
                       "ягодичная мышца, передняя и задняя поверхности бедра.",
                       Img = "/pic/приседания.jpg",
                       IsFavourite = false,
                       Level = 0.2,

                   },
                   new Exercise
                   {

                       Name = "Пресс",
                       ShortDesc = "Скручивания на пресс",
                       Instruction = "Лягте на специальный коврик, ноги согните в коленях. Разместите руки на затылке. " +
                       "На выдохе начинайте подъем тела к коленям (поясница при этом плотно прижата к поверхности пола), " +
                       "после чего опускайтесь обратно. Необходимо сделать 3-4 подхода по 15-20 раз.",
                       Img = "/pic/пресс.jpg",
                       IsFavourite = false,
                       Level = 0.3,

                   },
                   new Exercise
                   {

                       Name = "Растяжка",
                       ShortDesc = "Растяжка на разные группы мышц",
                       Instruction = "Ноги расположите на ширине собственных плеч, подтяните одно колено к груди и задержитесь на 20 секунд. " +
                       "Сделайте аналогичное движение для другой ноги. Поднимите левую руку вверх и тянитесь кончиками пальцев к потолку в течение " +
                       "10 - 20 секунд.Повторите то же движение для правой руки. Выполните упор лежа на коленях и, прогнув поясницу, опустите таз за пятки." +
                       "Задержитесь в таком положении на 10 секунд и возвращайтесь в начальную позицию.Повторите движения 3 - 4 раза.",
                       Img = "/pic/растяжка.jpg",
                       IsFavourite = false,
                       Level = 0.1,

                   }
                 );

                context.SaveChanges();
            }
        }
    }
}
