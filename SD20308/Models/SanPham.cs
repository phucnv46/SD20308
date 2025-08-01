using System;
using System.Collections.Generic;

namespace SD20308.Models;

public partial class SanPham
{
    public string MaSanPham { get; set; } = null!;

    public string TenSanPham { get; set; } = null!;

    public string? MoTa { get; set; }

    public int SoLuong { get; set; }

    public long MaLoaiSanPham { get; set; }

    public string? HinhAnh { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual LoaiSanPham MaLoaiSanPhamNavigation { get; set; } = null!;

    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
}
