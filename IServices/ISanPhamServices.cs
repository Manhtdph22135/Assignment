using Assignment.Models;

namespace Assignment.IServices
{
    public interface ISanPhamServices
    {
        List<SanPham> GetSanPhamAll();
        SanPham GetByIdSanPhamAll(int id);
        void DeleteSp(SanPham sp);
        void AddSp(SanPham sp);
        void Update(SanPham sp);
    }
}
