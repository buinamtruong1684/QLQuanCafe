using QLQuanCafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanCafe
{
    public partial class frmNhanVien : Form
    {
        QLQuanCafeContext db = new QLQuanCafeContext();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();

            // Thiết lập ComboBox chuyên nghiệp
            cboCaLam.Items.Clear();
            cboCaLam.Items.AddRange(new string[] { "Sáng", "Chiều", "Tối" });
            cboCaLam.DropDownStyle = ComboBoxStyle.DropDownList; // Ngăn người dùng tự gõ
        }

        void CapNhatTrangThaiUI(string text, Color backColor)
        {
            lblTrangThai.Text = text;
            lblTrangThai.BackColor = backColor;
            lblTrangThai.ForeColor = Color.Black;
            lblTrangThai.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            lblTrangThai.BorderStyle = BorderStyle.FixedSingle;
            lblTrangThai.AutoSize = false;
            lblTrangThai.Dock = DockStyle.Fill; 
        }

        // LOAD & ĐỊNH DẠNG
        void LoadNV()
        {
            dgvNV.DataSource = db.NhanViens.ToList();
            DinhDangLuoi();
        }

        void DinhDangLuoi()
        {
            if (dgvNV.Columns["MaNv"] != null) dgvNV.Columns["MaNv"].HeaderText = "Mã NV";
            if (dgvNV.Columns["TenNv"] != null) dgvNV.Columns["TenNv"].HeaderText = "Tên Nhân Viên";
            if (dgvNV.Columns["Sdt"] != null) dgvNV.Columns["Sdt"].HeaderText = "Số Điện Thoại";
            if (dgvNV.Columns["CaLam"] != null) dgvNV.Columns["CaLam"].HeaderText = "Ca Trực";

            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNV.AllowUserToAddRows = false;
        }

        void ClearInput()
        {
            txtTenNV.Clear();
            txtSDT.Clear();
            cboCaLam.SelectedIndex = -1;
            txtTenNV.Focus();
        }

        // THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            nv.TenNv = txtTenNV.Text;
            nv.Sdt = txtSDT.Text;
            nv.CaLam = cboCaLam.Text;

            db.NhanViens.Add(nv);
            db.SaveChanges();

            LoadNV();
        }

        // SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = (int)dgvNV.CurrentRow.Cells["MaNv"].Value;

            var nv = db.NhanViens.Find(id);

            if (nv != null)
            {
                nv.TenNv = txtTenNV.Text;
                nv.Sdt = txtSDT.Text;
                nv.CaLam = cboCaLam.Text;

                db.SaveChanges();
                LoadNV();
            }
        }

        // XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = (int)dgvNV.CurrentRow.Cells["MaNv"].Value;

            var nv = db.NhanViens.Find(id);

            if (nv != null)
            {
                db.NhanViens.Remove(nv);
                db.SaveChanges();
                LoadNV();
            }
        }

        // CLICK GRID
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNV.CurrentRow != null)
            {
                txtTenNV.Text = dgvNV.CurrentRow.Cells["TenNv"].Value?.ToString();
                txtSDT.Text = dgvNV.CurrentRow.Cells["Sdt"].Value?.ToString();
                cboCaLam.Text = dgvNV.CurrentRow.Cells["CaLam"].Value?.ToString();

                // --- CẬP NHẬT KHU VỰC 3 KHI CLICK ---
                CapNhatTrangThaiUI("Trạng thái: Đang làm", Color.LimeGreen);
            }
        }
    }
}
