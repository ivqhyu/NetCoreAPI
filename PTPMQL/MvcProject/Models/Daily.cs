namespace MvcProject.Models
{
    public class DaiLy
    {
        public required string MaDaiLy { get; set; }
        public required string TenDaiLy { get; set; }
        public required string DiaChi { get; set; }
        public required string NguoiDaiDien { get; set; }
        public required string DienThoai { get; set; }
        public required string MaHTPP { get; set; } // Khóa ngoại liên kết với HeThongPhanPhoi
    }
}
