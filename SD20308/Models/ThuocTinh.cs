using System;
using System.Collections.Generic;

namespace SD20308.Models;

public partial class ThuocTinh
{
    public long Ma { get; set; }

    public string TenThuocTinh { get; set; } = null!;

    public virtual ICollection<SanPhamChiTietThuocTinh> SanPhamChiTietThuocTinhs { get; set; } = new List<SanPhamChiTietThuocTinh>();
}
