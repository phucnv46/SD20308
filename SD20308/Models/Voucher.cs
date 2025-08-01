using System;
using System.Collections.Generic;

namespace SD20308.Models;

public partial class Voucher
{
    public string MaVoucher { get; set; } = null!;

    public string TenVouCher { get; set; } = null!;

    public int LoaiGiam { get; set; }

    public decimal GiaTriGiam { get; set; }

    public DateOnly HanSuDung { get; set; }

    public decimal? GiaTriApDung { get; set; }

    public decimal? GiaTriGiamToiDa { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
