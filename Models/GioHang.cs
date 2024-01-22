using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class GioHang
    {
        [Key]
        public Guid IDGioHang { get; set; }
        public string Description { get; set; }

        public List<GioHangCT> GioHangcts { get; set; }
        public List<SanPhamCT> SanPhamCTs { get; set; }
    }
}
