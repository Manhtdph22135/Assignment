using Assignment.IResponsitories;
using Assignment.Models;

namespace Assignment.Responsitories
{
    public class SPCTRepos : ISPCTRepos
    {
        private readonly Context _context;
        public SPCTRepos(Context context)
        {
            _context = context;
        }
        public void AddSpCT(SanPhamCT spCT)
        {
            try
            {
                _context.SanPhamCTs.Add(spCT);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }

        }

        public void DeleteSPCT(SanPhamCT spCT)
        {
            try
            {
                _context.SanPhamCTs.Remove(spCT);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        public List<SanPhamCT> GetAllSPCTs()
        {
            return _context.SanPhamCTs.ToList();
        }

        public SanPhamCT GetByIdSPCT(SanPhamCT spCT)
        {
            return _context.SanPhamCTs.Find(spCT);
        }

        public void UpdateSPCT(SanPhamCT spCT)
        {
            try
            {
                _context.SanPhamCTs.Attach(spCT);
                _context.SanPhamCTs.Update(spCT);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            };
        }
    }
}
