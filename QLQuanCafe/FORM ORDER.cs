using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace QLQuanCafe
{
    public partial class frmOrder : Form
    {
        SqlConnection conn = new SqlConnection(
      "Data Source=.;Initial Catalog=QLQuanCafe;Integrated Security=True;TrustServerCertificate=True"
   );
        public frmOrder()
        {
            InitializeComponent();
        }

        private void FORM_ORDER_Load(object sender, EventArgs e)
        {

            LoadBan();
            LoadDanhMuc();
            LoadTrangThaiBan();

            dtpNgayLap.Value = DateTime.Now;
            txtSoHoaDon.Text = DateTime.Now.ToString("yyyyMMddHHmmss");

            // ===== TẠO CỘT DGV =====
            dgvOrder.Columns.Clear();

            dgvOrder.Columns.Add("colTen", "Tên món");
            dgvOrder.Columns.Add("colSL", "Số lượng");
            dgvOrder.Columns.Add("colGia", "Giá");
            dgvOrder.Columns.Add("colThanhTien", "Thành tiền");

            // Format đẹp
            dgvOrder.Columns["colGia"].DefaultCellStyle.Format = "N0";
            dgvOrder.Columns["colThanhTien"].DefaultCellStyle.Format = "N0";

            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.RowHeadersVisible = false;
        }
        void LoadBan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ban", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbBan.DataSource = dt;
            cbBan.DisplayMember = "TenBan";
            cbBan.ValueMember = "MaBan";
        }
        void LoadDanhMuc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DanhMuc", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbDanhMuc.DataSource = dt;
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "MaDanhMuc";
        }



        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDanhMuc.SelectedItem == null) return;

            DataRowView row = (DataRowView)cbDanhMuc.SelectedItem;
            int maDM = Convert.ToInt32(row["MaDanhMuc"]);

            SqlDataAdapter da = new SqlDataAdapter(
                $"SELECT * FROM SanPham WHERE MaDanhMuc = {maDM}", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cbMon.DataSource = dt;
            cbMon.DisplayMember = "TenSP";
            cbMon.ValueMember = "MaSP";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbMon.SelectedItem;

            string ten = row["TenSP"].ToString();
            int gia = Convert.ToInt32(row["Gia"]);
            int sl = (int)nmSoLuong.Value;

            bool found = false;

            foreach (DataGridViewRow r in dgvOrder.Rows)
            {
                if (r.Cells[0].Value?.ToString() == ten)
                {
                    int old = Convert.ToInt32(r.Cells[1].Value);
                    old += sl;

                    r.Cells[1].Value = old;
                    r.Cells[3].Value = old * gia;

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                dgvOrder.Rows.Add(ten, sl, gia, sl * gia);
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow != null)
            {
                dgvOrder.Rows.Remove(dgvOrder.CurrentRow);

            }
        }





        private void pnlTrangThaiBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvOrder.Rows.Clear();
        }


        void LoadTrangThaiBan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ban", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            pnlTrangThaiBan.Controls.Clear();

            foreach (DataRow r in dt.Rows)
            {
                Button btn = new Button();
                btn.Text = r["TenBan"].ToString();
                btn.Width = 80;
                btn.Height = 50;

                if (r["TrangThai"].ToString() == "Có khách")
                    btn.BackColor = System.Drawing.Color.Red;
                else
                    btn.BackColor = System.Drawing.Color.LightGreen;

                pnlTrangThaiBan.Controls.Add(btn);
            }
        }

        private void btnChuyenSangThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvOrder.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có món!");
                return;
            }

            FormThanhToan f = new FormThanhToan(
      dgvOrder,
      Convert.ToInt32(cbBan.SelectedValue)
  );

            f.ShowDialog();
        }
    }
}
