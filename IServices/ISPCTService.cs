using Assignment.Models;

namespace Assignment.IServices
{
    public interface ISPCTService
    {
        void AddSpCT(SanPhamCT spCT);
        void DeleteSPCT(SanPhamCT spCT);
        void UpdateSPCT(SanPhamCT spCT);
        SanPhamCT GetByIdSPCT(SanPhamCT spCT);
        List<SanPhamCT> GetAllSPCTs();
    }
}
