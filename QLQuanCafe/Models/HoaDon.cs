using System;
using System.Collections.Generic;

namespace QLQuanCafe.Models;

public partial class HoaDon
{
    public int MaHd { get; set; }

    public DateTime? NgayLap { get; set; }

    public int? MaBan { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual Ban? MaBanNavigation { get; set; }
}
