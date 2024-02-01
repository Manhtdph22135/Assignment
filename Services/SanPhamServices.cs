using Assignment.IResponsitories;
using Assignment.IServices;
using Assignment.Models;

namespace Assignment.Services
{
    public class SanPhamServices : ISanPhamServices
    {
        private readonly ISanPhamRepos _sanphamrepos;
        public SanPhamServices(ISanPhamRepos sanPhamRepos)
        {
            _sanphamrepos = sanPhamRepos;
        }
        public void AddSp(SanPham sp)
        {
            _sanphamrepos.AddSp(sp);
        }

        public void DeleteSp(SanPham sp)
        {
            _sanphamrepos.DeleteSp(sp);
        }

        public List<SanPham> GetSanPhamAll()
        {
            return _sanphamrepos.GetSanPhamAll();
        }

        public SanPham GetByIdSanPhamAll(int id)
        {
            return _sanphamrepos.GetByIdSanPhamAll(id);
        }

        public void Update(SanPham sp)
        {
            _sanphamrepos.Update(sp);
        }

        internal object GetByIdSanPhamAll()
        {
            throw new NotImplementedException();
        }
    }
}
