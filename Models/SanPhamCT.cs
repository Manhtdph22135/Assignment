using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class SanPhamCT
    {
        [Key]
        public Guid IDSPCT { get; set; }
        public Guid IDSP { get; set; }
        public Guid IdBill { get; set; }
        public Guid IDGioHang { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiaSale { get; set; }
        public int SoLuong { get; set; }
        public string Anh { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public SanPham SanPham { get; set; }
        public HoaDon HoaDon { get; set; }
        public GioHang GioHang { get; set; }
    }
}
