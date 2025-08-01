using System;
using System.Collections.Generic;

namespace SD20308.Models;

public partial class LoaiSanPham
{
    public long MaLoai { get; set; }

    public string TenLoai { get; set; } = null!;

    public string? MoTa { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
