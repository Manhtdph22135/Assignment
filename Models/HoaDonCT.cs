using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class HoaDonCT
    {
        [Key]
        public Guid IDHDCT { get; set; }
        public Guid IdBill { get; set; }
        public Guid IdSP { get; set; }
        public Guid IDKhachHang { get; set; }
        public string MaHD { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
        public decimal TongThanhToan { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayNhan { get; set; }
        public DateTime NgayShip { get; set; }
        public string TenNguoiNhan { get; set; }
        public string SDTNguoiNhan { get; set; }
        public string DiaChiNguoiNhan { get; set; }
        public int TrangThai { get; set; }
        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }
        public KhachHang KhachHang { get; set; }

    }
}
