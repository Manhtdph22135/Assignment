using Assignment.Models;

namespace Assignment.IServices
{
    public interface IKhachHangSer
    {
        List<KhachHang> GetKhachHangAll();
        KhachHang GetKhachHangById(Guid id);
        void AddKhachHang(KhachHang khachHang);
        void UpdateKhachHang(KhachHang khachHang);
        void DeleteKhachHang(KhachHang khachHang);
    }
}
