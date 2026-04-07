using Microsoft.Data.SqlClient;
using QLQuanCafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QLQuanCafe
{
    public partial class FormThanhToan : Form
    {
        public DataGridView dgvData;
        public int maBan;
        SqlConnection conn = new SqlConnection(
           @"Data Source=.;Initial Catalog=QLQuanCafe;Integrated Security=True;TrustServerCertificate=True");

        double subTotal = 0;
        double discount = 0;
        double vat = 0;
        double grandTotal = 0;

        public FormThanhToan(DataGridView data, int ban)
        {
            InitializeComponent();
            dgvData = data;
            maBan = ban;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {

            if (dgvData == null)
            {
                MessageBox.Show("Không có dữ liệu!");
                return;
            }

            lblBan.Text = "Bàn: " + maBan;
            lblMaHD.Text = "HD-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            rbTienMat.Checked = true;
            pnlChuyenKhoan.Visible = false;

            // 🔥 TẠO CỘT (KHÔNG CẦN DESIGNER)
            dgvThanhToan.Columns.Clear();

            dgvThanhToan.Columns.Add("colTen", "Tên món");
            dgvThanhToan.Columns.Add("colSL", "Số lượng");
            dgvThanhToan.Columns.Add("colGia", "Giá");
            dgvThanhToan.Columns.Add("colThanhTien", "Thành tiền");

            dgvThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThanhToan.AllowUserToAddRows = false;

            // 🔥 COPY DATA
            foreach (DataGridViewRow r in dgvData.Rows)
            {
                if (r.IsNewRow) continue;

                dgvThanhToan.Rows.Add(
                    r.Cells[0].Value?.ToString(),
                    Convert.ToInt32(r.Cells[1].Value ?? 0),
                    Convert.ToInt32(r.Cells[2].Value ?? 0),
                    Convert.ToInt32(r.Cells[3].Value ?? 0)
                );
            }

            TinhTien();




        }

        void TinhTien()
        {
            subTotal = 0;

            foreach (DataGridViewRow r in dgvThanhToan.Rows)
            {
                if (r.Cells[3].Value == null) continue;
                subTotal += Convert.ToDouble(r.Cells[3].Value);
            }

            discount = (double)numGiamGia.Value;
            if (discount > subTotal) discount = subTotal;

            vat = (subTotal - discount) * 0.1;
            grandTotal = (subTotal - discount) + vat;

            lblSubTotal.Text = subTotal.ToString("N0") + " đ";
            lblVAT.Text = vat.ToString("N0") + " đ";
            lblTongFinal.Text = grandTotal.ToString("N0") + " đ";

            lblSoTienQR.Text = grandTotal.ToString("N0") + " đ";
        }

        void LuuHoaDon()
        {
            try
            {
                conn.Open();

                // 1. Tạo hóa đơn
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO HoaDon(MaBan, TrangThai) OUTPUT INSERTED.MaHD VALUES(@MaBan, N'DaThanhToan')",
                    conn
                );
                cmd.Parameters.AddWithValue("@MaBan", maBan);

                object resultHD = cmd.ExecuteScalar();

                if (resultHD == null)
                {
                    MessageBox.Show("Không tạo được hóa đơn!");
                    return;
                }

                int maHD = Convert.ToInt32(resultHD);

                // 2. Lưu chi tiết
                foreach (DataGridViewRow r in dgvThanhToan.Rows)
                {
                    if (r.Cells[0].Value == null) continue;

                    string ten = r.Cells[0].Value.ToString();
                    int sl = Convert.ToInt32(r.Cells[1].Value);
                    int gia = Convert.ToInt32(r.Cells[2].Value);

                    // lấy mã sản phẩm
                    SqlCommand cmdSP = new SqlCommand(
                        "SELECT MaSP FROM SanPham WHERE TenSP = @Ten",
                        conn
                    );
                    cmdSP.Parameters.AddWithValue("@Ten", ten);

                    object resultSP = cmdSP.ExecuteScalar();

                    if (resultSP == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm: " + ten);
                        continue;
                    }

                    int maSP = Convert.ToInt32(resultSP);

                    // insert chi tiết
                    SqlCommand insertCT = new SqlCommand(
                        @"INSERT INTO ChiTietHoaDon(MaHD, MaSP, SoLuong, DonGia)
                  VALUES(@MaHD, @MaSP, @SL, @Gia)", conn);

                    insertCT.Parameters.AddWithValue("@MaHD", maHD);
                    insertCT.Parameters.AddWithValue("@MaSP", maSP);
                    insertCT.Parameters.AddWithValue("@SL", sl);
                    insertCT.Parameters.AddWithValue("@Gia", gia);

                    insertCT.ExecuteNonQuery();
                }

                // 3. Update bàn
                SqlCommand updateBan = new SqlCommand(
                   "UPDATE Ban SET TrangThai = N'Trống' WHERE MaBan = @MaBan",
                   conn
               );
                updateBan.Parameters.AddWithValue("@MaBan", maBan);
                updateBan.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                conn.Close();
            }
        }



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numGiamGia_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void txtTienKhach_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtTienKhach.Text, out double tienKhach))
            {
                double tienThua = tienKhach - grandTotal;
                lblTienThua.Text = tienThua.ToString("N0") + " đ";
            }
            else
            {
                lblTienThua.Text = "0 đ";
            }
        }

        private void rbTienMat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTienMat.Checked)
            {
                pnlChuyenKhoan.Visible = false;
            }
        }

        private void rbChuyenKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChuyenKhoan.Checked)
            {
                pnlChuyenKhoan.Visible = true;

                string stk = "123456789999";
                string ten = "QUAN CAFE ABC";
                string amount = grandTotal.ToString();
                string noidung = lblMaHD.Text;

                lblBankInfo.Text =
                    "Ngân hàng: MB Bank\n" +
                    "Số tài khoản: " + stk + "\n" +
                    "Chủ tài khoản: " + ten + "\n" +
                    "* Nội dung: " + noidung;

                string url = $"https://img.vietqr.io/image/MB-{stk}-compact2.png?amount={amount}&addInfo={noidung}&accountName={ten}";

                picQR.Load(url);
            }
        }

        private void rbThe_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThe.Checked)
            {
                pnlChuyenKhoan.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            LuuHoaDon();
            MessageBox.Show("Thanh toán & in thành công!");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LuuHoaDon();
            MessageBox.Show("Thanh toán thành công!");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void picQR_Click(object sender, EventArgs e)
        {

        }
    }
}
