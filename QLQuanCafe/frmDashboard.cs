using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQuanCafe.Models;
using Microsoft.EntityFrameworkCore;

namespace QLQuanCafe
{
    public partial class frmDashboard : Form
    {
        private QLQuanCafeContext _context;
        private System.Windows.Forms.Timer _refreshTimer;

        public frmDashboard()
        {
            InitializeComponent();
            _context = new QLQuanCafeContext();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
            
            // Cập nhật dữ liệu mỗi 5 giây
            _refreshTimer = new System.Windows.Forms.Timer();
            _refreshTimer.Interval = 5000;
            _refreshTimer.Tick += (s, ev) => LoadDashboard();
            _refreshTimer.Start();
        }

        private void LoadDashboard()
        {
            try
            {
                LoadTongTienHom();
                LoadSoBanDangDung();
                LoadSoHoaDonHom();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadTongTienHom()
        {
            try
            {
                var today = DateTime.Now.Date;
                
                var tongTien = _context.HoaDons
                    .Where(h => h.NgayLap.HasValue && h.NgayLap.Value.Date == today)
                    .SelectMany(h => h.ChiTietHoaDons)
                    .Sum(c => (c.SoLuong ?? 0) * (c.DonGia ?? 0));

                lblTongTienHom.Text = tongTien.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            }
            catch (Exception ex)
            {
                lblTongTienHom.Text = "Lỗi";
                MessageBox.Show("Lỗi tính tổng tiền: " + ex.Message);
            }
        }

        private void LoadSoBanDangDung()
        {
            try
            {
                var soBanDangDung = _context.Bans
                    .Where(b => b.TrangThai == "Có khách")
                    .Count();

                var tongSoBan = _context.Bans.Count();

                lblSoBanDangDung.Text = $"{soBanDangDung}/{tongSoBan}";
            }
            catch (Exception ex)
            {
                lblSoBanDangDung.Text = "Lỗi";
                MessageBox.Show("Lỗi tính số bàn: " + ex.Message);
            }
        }

        private void LoadSoHoaDonHom()
        {
            try
            {
                var today = DateTime.Now.Date;
                
                var soHoaDon = _context.HoaDons
                    .Where(h => h.NgayLap.HasValue && h.NgayLap.Value.Date == today)
                    .Count();

                lblSoHoaDonHom.Text = soHoaDon.ToString();
            }
            catch (Exception ex)
            {
                lblSoHoaDonHom.Text = "Lỗi";
                MessageBox.Show("Lỗi tính số hóa đơn: " + ex.Message);
            }
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _refreshTimer?.Stop();
            _refreshTimer?.Dispose();
            _context?.Dispose();
        }
    }
}
