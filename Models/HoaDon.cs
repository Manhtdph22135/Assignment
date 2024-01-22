using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class HoaDon
    {
        [Key]
        public Guid IdBill { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }

        public List<HoaDonCT> HoaDonCTs { get; set; }

        public List<SanPhamCT> SanPhamct { get; set; }

    }
}
