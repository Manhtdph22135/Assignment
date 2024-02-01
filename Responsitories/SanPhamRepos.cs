using Assignment.IResponsitories;
using Assignment.Models;

namespace Assignment.Responsitories
{
    public class SanPhamRepos : ISanPhamRepos
    {
        private readonly Context _context;
        public SanPhamRepos(Context context)
        {
            _context = context;
        }
        public void AddSp(SanPham sp)
        {
            try
            {
                _context.SanPhams.Add(sp);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        public void DeleteSp(SanPham sp)
        {
            try
            {
                _context.SanPhams.Remove(sp);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        public SanPham GetByIdSanPhamAll(int id)
        {
            return _context.SanPhams.Find(id);

        }

        public List<SanPham> GetSanPhamAll()
        {
            return _context.SanPhams.ToList();
        }

        public void Update(SanPham sp)
        {
            try
            {
                _context.SanPhams.Attach(sp);
                _context.SanPhams.Update(sp);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}
