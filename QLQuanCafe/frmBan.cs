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
    public partial class frmBan : Form
    {
        QLQuanCafeContext db = new QLQuanCafeContext();

        public frmBan()
        {
            InitializeComponent();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            LoadBan();

            // Nạp dữ liệu vào Combobox
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Trống");
            cboTrangThai.Items.Add("Có khách");

            // Cấu hình giao diện bảng cho chuyên nghiệp
            SetupDataGridView();
        }

        // --- CÁC HÀM HỖ TRỢ NÂNG CẤP ---

        void SetupDataGridView()
        {
            if (dgvBan.Columns.Count > 0)
            {
                dgvBan.Columns["MaBan"].HeaderText = "Mã Số";
                dgvBan.Columns["TenBan"].HeaderText = "Tên Bàn";
                dgvBan.Columns["TrangThai"].HeaderText = "Trạng Thái";

                // Tự động giãn cột
                dgvBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvBan.ReadOnly = true;
            }
        }

        bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtTenBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBan.Focus();
                return false;
            }
            if (cboTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        void ClearInput()
        {
            txtTenBan.Clear();
            cboTrangThai.SelectedIndex = -1;
            txtTenBan.Focus();
        }

        // --- CỐT LÕI XỬ LÝ DỮ LIỆU ---

        void LoadBan()
        {
            dgvBan.DataSource = db.Bans.ToList();
        }




        // CLICK GRID
        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBan.CurrentRow == null) return;

            txtTenBan.Text = dgvBan.CurrentRow.Cells["TenBan"].Value.ToString();
            cboTrangThai.Text = dgvBan.CurrentRow.Cells["TrangThai"].Value.ToString();

            // HIỆU ỨNG: Thay đổi màu panel hiển thị trạng thái (giống hình nhân viên)
            string tinhTrang = cboTrangThai.Text;
            if (tinhTrang == "Trống")
            {
                lblTrangThai.BackColor = Color.LimeGreen;
                lblTrangThai.Text = "Trạng thái: Đang Trống";
            }
            else
            {
                lblTrangThai.BackColor = Color.OrangeRed;
                lblTrangThai.Text = "Trạng thái: Có Khách";
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Ban b = new Ban();

            b.TenBan = txtTenBan.Text;
            b.TrangThai = cboTrangThai.Text;

            db.Bans.Add(b);
            db.SaveChanges();

            LoadBan();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int id = (int)dgvBan.CurrentRow.Cells["MaBan"].Value;

            var b = db.Bans.Find(id);

            if (b != null)
            {
                db.Bans.Remove(b);
                db.SaveChanges();
                LoadBan();
            }
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            LoadBan();
            ClearInput();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            int id = (int)dgvBan.CurrentRow.Cells["MaBan"].Value;

            var b = db.Bans.Find(id);

            if (b != null)
            {
                b.TenBan = txtTenBan.Text;
                b.TrangThai = cboTrangThai.Text;

                db.SaveChanges();
                LoadBan();
            }
        }

        private void lblTrangThai_Click(object sender, EventArgs e)
        {

        }
    }
}
