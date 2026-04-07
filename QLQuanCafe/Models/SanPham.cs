using System;
using System.Collections.Generic;

namespace QLQuanCafe.Models;

public partial class SanPham
{
    public int MaSp { get; set; }

    public string TenSp { get; set; } = null!;

    public double Gia { get; set; }

    public string? MoTa { get; set; }

    public int? MaDanhMuc { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual DanhMuc? MaDanhMucNavigation { get; set; }
}
