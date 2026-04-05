using System;
using System.Collections.Generic;

namespace QLQuanCafe.Models;

public partial class ChiTietHoaDon
{
    public int MaHd { get; set; }

    public int MaSp { get; set; }

    public int? SoLuong { get; set; }

    public double? DonGia { get; set; }

    public virtual HoaDon MaHdNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}
