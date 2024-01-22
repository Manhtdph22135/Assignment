using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GioHangs",
                columns: table => new
                {
                    IDGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.IDGioHang);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    IdBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.IdBill);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    IDKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.IDKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.IdSP);
                });

            migrationBuilder.CreateTable(
                name: "GioHangCTs",
                columns: table => new
                {
                    IDGHCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangCTs", x => x.IDGHCT);
                    table.ForeignKey(
                        name: "FK_GioHangCTs_GioHangs_IDGioHang",
                        column: x => x.IDGioHang,
                        principalTable: "GioHangs",
                        principalColumn: "IDGioHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangCTs_KhachHangs_IDKhachHang",
                        column: x => x.IDKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "IDKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangCTs_SanPhams_IdSP",
                        column: x => x.IdSP,
                        principalTable: "SanPhams",
                        principalColumn: "IdSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCTs",
                columns: table => new
                {
                    IDHDCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayNhan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayShip = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDTNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCTs", x => x.IDHDCT);
                    table.ForeignKey(
                        name: "FK_HoaDonCTs_HoaDons_IdBill",
                        column: x => x.IdBill,
                        principalTable: "HoaDons",
                        principalColumn: "IdBill",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCTs_KhachHangs_IDKhachHang",
                        column: x => x.IDKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "IDKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCTs_SanPhams_IdSP",
                        column: x => x.IdSP,
                        principalTable: "SanPhams",
                        principalColumn: "IdSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamCTs",
                columns: table => new
                {
                    IDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaSale = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Anh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamCTs", x => x.IDSPCT);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_GioHangs_IDGioHang",
                        column: x => x.IDGioHang,
                        principalTable: "GioHangs",
                        principalColumn: "IDGioHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_HoaDons_IdBill",
                        column: x => x.IdBill,
                        principalTable: "HoaDons",
                        principalColumn: "IdBill",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_SanPhams_IDSP",
                        column: x => x.IDSP,
                        principalTable: "SanPhams",
                        principalColumn: "IdSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCTs_IDGioHang",
                table: "GioHangCTs",
                column: "IDGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCTs_IDKhachHang",
                table: "GioHangCTs",
                column: "IDKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCTs_IdSP",
                table: "GioHangCTs",
                column: "IdSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCTs_IdBill",
                table: "HoaDonCTs",
                column: "IdBill");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCTs_IDKhachHang",
                table: "HoaDonCTs",
                column: "IDKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCTs_IdSP",
                table: "HoaDonCTs",
                column: "IdSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_IdBill",
                table: "SanPhamCTs",
                column: "IdBill");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_IDGioHang",
                table: "SanPhamCTs",
                column: "IDGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_IDSP",
                table: "SanPhamCTs",
                column: "IDSP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangCTs");

            migrationBuilder.DropTable(
                name: "HoaDonCTs");

            migrationBuilder.DropTable(
                name: "SanPhamCTs");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "SanPhams");
        }
    }
}
