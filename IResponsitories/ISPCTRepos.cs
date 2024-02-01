using Assignment.Models;

namespace Assignment.IResponsitories
{
    public interface ISPCTRepos
    {
        void AddSpCT(SanPhamCT spCT);
        void DeleteSPCT(SanPhamCT spCT);
        void UpdateSPCT(SanPhamCT spCT);
        SanPhamCT GetByIdSPCT(SanPhamCT spCT);
        List<SanPhamCT> GetAllSPCTs();
    }
}
