using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class SanPham
    {
        [Key]
        public Guid IdSP { get; set; }
        public string TenSP { get; set; }
        public List<SanPhamCT> SanPhamCT { get; set; }

        public List<HoaDonCT> HoaDonCT { get; set; }
        public List<GioHangCT> GioHangCT { get; set; }
    }
}
