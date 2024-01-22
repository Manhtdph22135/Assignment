using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class Context : DbContext
    {
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<SanPhamCT> SanPhamCTs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangCT> GioHangCTs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonCT> HoaDonCTs { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPhamCT>()
                .HasOne(p => p.SanPham)
                .WithMany(b => b.SanPhamCT)
                .HasForeignKey(p => p.IDSP);
            modelBuilder.Entity<SanPhamCT>()
                .HasOne(p => p.GioHang)
                .WithMany(b => b.SanPhamCTs)
                .HasForeignKey(p => p.IDGioHang);
            modelBuilder.Entity<SanPhamCT>()
                .HasOne(p => p.HoaDon)
                .WithMany(b => b.SanPhamct)
                .HasForeignKey(p => p.IdBill);

            modelBuilder.Entity<GioHangCT>()
                .HasOne(p => p.GioHang)
                .WithMany(b => b.GioHangcts)
                .HasForeignKey(p => p.IDGioHang);
            modelBuilder.Entity<GioHangCT>()
                .HasOne(p => p.SanPham)
                .WithMany(b => b.GioHangCT)
                .HasForeignKey(p => p.IdSP);
            modelBuilder.Entity<GioHangCT>()
                .HasOne(p => p.KhachHang)
                .WithMany(b => b.GioHangCTs)
                .HasForeignKey(p => p.IDKhachHang);

            modelBuilder.Entity<HoaDonCT>()
                .HasOne(p => p.HoaDon)
                .WithMany(b => b.HoaDonCTs)
                .HasForeignKey(p => p.IdBill);
            modelBuilder.Entity<HoaDonCT>()
                .HasOne(p => p.SanPham)
                .WithMany(b => b.HoaDonCT)
                .HasForeignKey(p => p.IdSP);
            modelBuilder.Entity<HoaDonCT>()
                .HasOne(p => p.KhachHang)
                .WithMany(b => b.HoaDonCTs)
                .HasForeignKey(p => p.IDKhachHang);
        }
    }
}
