using Assignment.IResponsitories;
using Assignment.Models;

namespace Assignment.Responsitories
{
    public class KhachHangRes : IKhachHangRes
    {
        private readonly Context _context;
        public KhachHangRes(Context context)
        {
            _context = context;
        }

        public void AddKhachHang(KhachHang khachHang)
        {
            try
            {
                _context.KhachHangs.Add(khachHang);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void DeleteKhachHang(KhachHang khachHang)
        {
            try
            {
                _context.KhachHangs.Attach(khachHang);
                _context.KhachHangs.Remove(khachHang);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<KhachHang> GetKhachHangAll()
        {
            return _context.KhachHangs.ToList();
        }

        public KhachHang GetKhachHangById(Guid id)
        {
            return _context.KhachHangs.Find(id);
        }

        public void UpdateKhachHang(KhachHang khachHang)
        {
            try
            {
                _context.KhachHangs.Attach(khachHang);
                _context.KhachHangs.Update(khachHang);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
