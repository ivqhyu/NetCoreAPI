using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers;


    public class BMIController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(double weight, double height)
        {
            if (height <= 0 || weight <= 0)
            {
                ViewBag.Message = "Vui lòng nhập giá trị hợp lệ!";
                return View();
            }

            double bmi = weight / (height * height);
            string category;

            if (bmi < 18.5) category = "Gầy";
            else if (bmi < 24.9) category = "Bình thường";
            else if (bmi < 29.9) category = "Thừa cân";
            else category = "Béo phì";

            ViewBag.BMI = bmi.ToString("0.00");
            ViewBag.Category = category;
            return View();
        }
    }

