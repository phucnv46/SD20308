using System;
using System.Collections.Generic;

namespace SD20308.Models;

public partial class SanPhamChiTiet
{
    public string Ma { get; set; } = null!;

    public string MaSanPham { get; set; } = null!;

    public decimal Gia { get; set; }

    public int SoLuong { get; set; }

    public string? HinhAnh { get; set; }

    public virtual SanPham MaSanPhamNavigation { get; set; } = null!;

    public virtual ICollection<SanPhamChiTietThuocTinh> SanPhamChiTietThuocTinhs { get; set; } = new List<SanPhamChiTietThuocTinh>();
}
