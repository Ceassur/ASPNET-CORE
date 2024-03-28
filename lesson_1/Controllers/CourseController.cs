using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using lesson_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace lesson_1.Controllers
{

    public class CourseController : Controller
    {
        public IActionResult Index()
        {

            Course courseItem = new Course();
            courseItem.Title = "12. Hafta asp.net core eğitimi";
            courseItem.Id = 12;
            return View(courseItem);
        }
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult ContactNew()
        {
            return View("ConractV2");
        }
        public IActionResult List()
        {
            List<Course> courseList = new List<Course>();

            Course lists = new Course();
            Course lists1 = new Course();
            Course lists2 = new Course();

            lists.Title = "Genişletilmiş Yazılım Eğitimi";
            lists.Id = 1;
            lists.TeacherName = "Hakan Hakyemez";

            courseList.Add(lists);

            lists1.Title = "Gastronomi";
            lists1.Id = 2;
            lists1.TeacherName = "Berat Cesur";

            courseList.Add(lists1);

            lists2.Title = "Dijital Pazarlama";
            lists2.Id = 3;
            lists2.TeacherName = "Selim Odabaş";

            courseList.Add(lists2);

            return View("CourseList", courseList);
        }





    }

}