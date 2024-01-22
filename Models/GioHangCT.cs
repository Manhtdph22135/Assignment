using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class GioHangCT
    {
        [Key]
        public Guid IDGHCT { get; set; }
        public Guid IDGioHang { get; set; }
        public Guid IdSP { get; set; }
        public Guid IDKhachHang { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }

        public GioHang GioHang { get; set; }
        public SanPham SanPham { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}
