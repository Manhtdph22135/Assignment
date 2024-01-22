using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class KhachHang
    {
        [Key]
        public Guid IDKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public int TrangThai { get; set; }

        public List<HoaDonCT> HoaDonCTs { get; set; }
        public List<GioHangCT> GioHangCTs { get; set; }
    }
}
