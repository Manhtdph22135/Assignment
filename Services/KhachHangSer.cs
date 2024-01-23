using Assignment.IResponsitories;
using Assignment.IServices;
using Assignment.Models;

namespace Assignment.Services
{
    public class KhachHangSer : IKhachHangSer
    {
        private readonly IKhachHangRes _khachHangRes;
        public KhachHangSer(IKhachHangRes khachHangRes)
        {
            _khachHangRes = khachHangRes;
        }

        public void AddKhachHang(KhachHang khachHang)
        {
            _khachHangRes.AddKhachHang(khachHang);
        }

        public void DeleteKhachHang(KhachHang khachHang)
        {
            _khachHangRes.DeleteKhachHang(khachHang);
        }

        public List<KhachHang> GetKhachHangAll()
        {
            return _khachHangRes.GetKhachHangAll();
        }

        public KhachHang GetKhachHangById(Guid id)
        {
            return _khachHangRes.GetKhachHangById(id);
        }

        public void UpdateKhachHang(KhachHang khachHang)
        {
            _khachHangRes.UpdateKhachHang(khachHang);
        }
    }
}
