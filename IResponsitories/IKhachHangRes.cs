using Assignment.Models;

namespace Assignment.IResponsitories
{
    public interface IKhachHangRes
    {
        List<KhachHang> GetKhachHangAll();
        KhachHang GetKhachHangById(Guid id);
        void AddKhachHang(KhachHang khachHang);
        void UpdateKhachHang(KhachHang khachHang);
        void DeleteKhachHang(KhachHang khachHang);
    }
}
