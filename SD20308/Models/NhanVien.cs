using System;
using System.Collections.Generic;

namespace SD20308.Models;

public partial class NhanVien
{
    public long MaNhanVien { get; set; }

    public string TenNhanVien { get; set; } = null!;

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public bool? GioiTinh { get; set; }

    public string? VaiTro { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
