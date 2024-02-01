using Assignment.Models;

namespace Assignment.IResponsitories
{
    public interface ISanPhamRepos
    {
        List<SanPham> GetSanPhamAll();
        SanPham GetByIdSanPhamAll(int id);
        void DeleteSp(SanPham sp);
        void AddSp(SanPham sp);
        void Update(SanPham sp);

    }
}
