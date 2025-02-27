using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace TinhHoaDon.Controllers
{
    public class TinhHoaDonController : Controller
    {
        // Hiển thị form
        public ActionResult Index()
        {
            return View();
        }

        // Xử lý dữ liệu gửi lên (POST)
        [HttpPost]
        public ActionResult Index(string TenSP, int SoLuong, double DonGia)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(TenSP))
            {
                ViewBag.Message = "Vui lòng nhập tên sản phẩm!";
                return View();
            }
            if (SoLuong <= 0 || DonGia <= 0)
            {
                ViewBag.Message = "Số lượng và đơn giá phải lớn hơn 0!";
                return View();
            }

            // Tính thành tiền
            double ThanhTien = SoLuong * DonGia;

            // Đưa kết quả ra View
            ViewBag.TenSP = TenSP;
            ViewBag.SoLuong = SoLuong;
            ViewBag.DonGia = DonGia;
            ViewBag.ThanhTien = ThanhTien;

            return View();
        }
    }
}
