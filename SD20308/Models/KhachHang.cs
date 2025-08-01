using System;
using System.Collections.Generic;

namespace SD20308.Models;

public partial class KhachHang
{
    public long MaKhachHang { get; set; }

    public string HoTen { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public string? Email { get; set; }

    public string? DiaChi { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
