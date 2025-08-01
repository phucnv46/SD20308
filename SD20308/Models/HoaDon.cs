using System;
using System.Collections.Generic;

namespace SD20308.Models;

public partial class HoaDon
{
    public string MaHoaDon { get; set; } = null!;

    public DateTime ThoiGianTao { get; set; }

    public decimal TongHoaDon { get; set; }

    public decimal TongTienGiam { get; set; }

    public decimal ThanhTien { get; set; }

    public long MaNhanVien { get; set; }

    public long? MaKhachHang { get; set; }

    public string? MaVoucher { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang? MaKhachHangNavigation { get; set; }

    public virtual NhanVien MaNhanVienNavigation { get; set; } = null!;

    public virtual Voucher? MaVoucherNavigation { get; set; }
}
