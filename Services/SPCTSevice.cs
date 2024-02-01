using Assignment.IResponsitories;
using Assignment.IServices;
using Assignment.Models;

namespace Assignment.Services
{
    public class SPCTSevice : ISPCTService
    {
        private readonly ISPCTRepos _spctrepos;
        public SPCTSevice(ISPCTRepos SPCTRepos)
        {
            _spctrepos = SPCTRepos;
        }
        public void AddSpCT(SanPhamCT spCT)
        {
            _spctrepos.AddSpCT(spCT);
        }

        public void DeleteSPCT(SanPhamCT spCT)
        {
           _spctrepos.DeleteSPCT(spCT);
        }

        public List<SanPhamCT> GetAllSPCTs()
        {
            return _spctrepos.GetAllSPCTs();
        }

        public SanPhamCT GetByIdSPCT(SanPhamCT spCT)
        {
          return _spctrepos.GetByIdSPCT(spCT);
        }

        public void UpdateSPCT(SanPhamCT spCT)
        {
            _spctrepos.UpdateSPCT(spCT);
        }
    }
}
