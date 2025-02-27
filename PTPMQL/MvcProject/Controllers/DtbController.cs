using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers;


    public class DtbController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string TenSv, string TenMonHoc, double DiemA, double DiemB, double DiemC)
        {
            if (DiemA < 0 || DiemA > 10 || DiemB < 0 || DiemB > 10 || DiemC < 0 || DiemC > 10)
            {
                ViewBag.Message = "Điểm phải nằm trong khoảng từ 0 - 10";
                return View();
            }

            double DTB = (DiemA * 0.6) + (DiemB * 0.3) + (DiemC * 0.1);
            string  xeploai;

            if (DTB >= 8.5)
                xeploai = "Giỏi";
            else if (DTB >= 6.5)
                xeploai = "Khá";
            else if (DTB >= 5.0)
                xeploai = "Trung bình";
            else
                xeploai = "Yếu";

            ViewBag.TenSv = TenSv; 
            ViewBag.TenMonHoc = TenMonHoc; 
            ViewBag.DTB = DTB; 
            ViewBag.xeploai = xeploai;
            return View();
        }
    }

