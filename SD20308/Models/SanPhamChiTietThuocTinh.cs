using System;
using System.Collections.Generic;

namespace SD20308.Models;

public partial class SanPhamChiTietThuocTinh
{
    public string MaSanPhamChiTiet { get; set; } = null!;

    public long MaThuocTinh { get; set; }

    public string GiaTri { get; set; } = null!;

    public string? KieuDuLieu { get; set; }

    public virtual SanPhamChiTiet MaSanPhamChiTietNavigation { get; set; } = null!;

    public virtual ThuocTinh MaThuocTinhNavigation { get; set; } = null!;
}
