using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcProject.Models
{
    public class Daily
    {
        [Key]
        public required string DaiLyID { get; set; }
        public required string TenDaiLy { get; set; }

        public required string DiaChi { get; set; }
        public required string NguoiDaiDien { get; set; }
        public required string DienThoai { get; set; }

        [ForeignKey("HeThongPhanPhoi")]
        public required string MaHTPP { get; set; }

        public required virtual HeThongPhanPhoi HeThongPhanPhoi { get; set; }
    }
}