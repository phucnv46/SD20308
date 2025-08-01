using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SD20308.Models;

namespace SD20308.Data;

public partial class Sd20308DbContext : DbContext
{
    public Sd20308DbContext()
    {
    }

    public Sd20308DbContext(DbContextOptions<Sd20308DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; }

    public virtual DbSet<SanPhamChiTietThuocTinh> SanPhamChiTietThuocTinhs { get; set; }

    public virtual DbSet<ThuocTinh> ThuocTinhs { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=np:\\\\.\\pipe\\LOCALDB#FF3190D6\\tsql\\query;Database=SD20308_DB;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PK__HoaDon__835ED13BA716CAEA");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHoaDon).HasMaxLength(255);
            entity.Property(e => e.MaVoucher).HasMaxLength(255);
            entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ThoiGianTao).HasColumnType("datetime");
            entity.Property(e => e.TongHoaDon).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TongTienGiam).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKhachHang)
                .HasConstraintName("FK__HoaDon__MaKhachH__403A8C7D");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaNhanVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__MaNhanVi__3F466844");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaVoucher)
                .HasConstraintName("FK__HoaDon__MaVouche__412EB0B6");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => new { e.MaHoaDon, e.MaSanPham }).HasName("PK__HoaDonCh__4CF2A579A4BB4C52");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.MaHoaDon).HasMaxLength(255);
            entity.Property(e => e.MaSanPham).HasMaxLength(255);
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.MaHoaDon)
                .HasConstraintName("FK__HoaDonChi__MaHoa__440B1D61");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__HoaDonChi__MaSan__44FF419A");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhachHang).HasName("PK__KhachHan__88D2F0E5788ABCA7");

            entity.ToTable("KhachHang");

            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.HoTen).HasMaxLength(255);
            entity.Property(e => e.SoDienThoai).HasMaxLength(20);
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.MaLoai).HasName("PK__LoaiSanP__730A5759B0D08AB8");

            entity.ToTable("LoaiSanPham");

            entity.Property(e => e.TenLoai)
                .HasMaxLength(255)
                .HasDefaultValue("Chưa rõ");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NhanVien__77B2CA4770E4B1CA");

            entity.ToTable("NhanVien");

            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.SoDienThoai).HasMaxLength(20);
            entity.Property(e => e.TenNhanVien).HasMaxLength(255);
            entity.Property(e => e.VaiTro).HasMaxLength(255);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPham__FAC7442DAD0204CD");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSanPham).HasMaxLength(255);
            entity.Property(e => e.TenSanPham).HasMaxLength(255);

            entity.HasOne(d => d.MaLoaiSanPhamNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoaiSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPham__MaLoaiS__276EDEB3");
        });

        modelBuilder.Entity<SanPhamChiTiet>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK__SanPhamC__3214CC9FFBFCAEE1");

            entity.ToTable("SanPhamChiTiet");

            entity.Property(e => e.Ma).HasMaxLength(255);
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaSanPham).HasMaxLength(255);

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.SanPhamChiTiets)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__SanPhamCh__MaSan__2B3F6F97");
        });

        modelBuilder.Entity<SanPhamChiTietThuocTinh>(entity =>
        {
            entity.HasKey(e => new { e.MaSanPhamChiTiet, e.MaThuocTinh }).HasName("PK__SanPhamC__6DE37F5A93A70686");

            entity.ToTable("SanPhamChiTiet_ThuocTinh");

            entity.Property(e => e.MaSanPhamChiTiet).HasMaxLength(255);
            entity.Property(e => e.KieuDuLieu).HasMaxLength(50);

            entity.HasOne(d => d.MaSanPhamChiTietNavigation).WithMany(p => p.SanPhamChiTietThuocTinhs)
                .HasForeignKey(d => d.MaSanPhamChiTiet)
                .HasConstraintName("FK__SanPhamCh__MaSan__300424B4");

            entity.HasOne(d => d.MaThuocTinhNavigation).WithMany(p => p.SanPhamChiTietThuocTinhs)
                .HasForeignKey(d => d.MaThuocTinh)
                .HasConstraintName("FK__SanPhamCh__MaThu__30F848ED");
        });

        modelBuilder.Entity<ThuocTinh>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK__ThuocTin__3214CC9FD22B22B1");

            entity.ToTable("ThuocTinh");

            entity.Property(e => e.TenThuocTinh).HasMaxLength(255);
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B114A65A991");

            entity.ToTable("Voucher");

            entity.Property(e => e.MaVoucher).HasMaxLength(255);
            entity.Property(e => e.GiaTriApDung)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GiaTriGiam).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GiaTriGiamToiDa)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TenVouCher).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
