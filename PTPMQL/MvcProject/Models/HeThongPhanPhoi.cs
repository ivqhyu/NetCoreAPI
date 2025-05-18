using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        public required string MaHTPP { get; set; }
        public required string TenHTPP { get; set; }

        public required virtual ICollection<Daily> Daily { get; set; }
    }
}
