namespace QLQuanCafe
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            dtpNgayLap = new DateTimePicker();
            txtSoHoaDon = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            cbMon = new ComboBox();
            cbDanhMuc = new ComboBox();
            nmSoLuong = new NumericUpDown();
            cbBan = new ComboBox();
            txtSearch = new TextBox();
            btnHuy = new Button();
            btnThem = new Button();
            dgvOrder = new DataGridView();
            groupBox3 = new GroupBox();
            btnChuyenSangThanhToan = new Button();
            btnXoa = new Button();
            groupBox5 = new GroupBox();
            pnlTrangThaiBan = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 91);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Bàn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 133);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Danh mục";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 174);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Món";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 209);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Số lượng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Controls.Add(txtSoHoaDon);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 111);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(73, 56);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(142, 23);
            dtpNgayLap.TabIndex = 9;
            // 
            // txtSoHoaDon
            // 
            txtSoHoaDon.Location = new Point(73, 21);
            txtSoHoaDon.Name = "txtSoHoaDon";
            txtSoHoaDon.Size = new Size(142, 23);
            txtSoHoaDon.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 66);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 8;
            label6.Text = "Ngày giờ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 29);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 7;
            label5.Text = "Số hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbMon);
            groupBox2.Controls.Add(cbDanhMuc);
            groupBox2.Controls.Add(nmSoLuong);
            groupBox2.Controls.Add(cbBan);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(221, 306);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm & Chọn món";
            // 
            // cbMon
            // 
            cbMon.FormattingEnabled = true;
            cbMon.Location = new Point(73, 172);
            cbMon.Name = "cbMon";
            cbMon.Size = new Size(142, 23);
            cbMon.TabIndex = 13;
            // 
            // cbDanhMuc
            // 
            cbDanhMuc.FormattingEnabled = true;
            cbDanhMuc.Location = new Point(73, 130);
            cbDanhMuc.Name = "cbDanhMuc";
            cbDanhMuc.Size = new Size(142, 23);
            cbDanhMuc.TabIndex = 12;
            cbDanhMuc.SelectedIndexChanged += cbDanhMuc_SelectedIndexChanged;
            // 
            // nmSoLuong
            // 
            nmSoLuong.Location = new Point(73, 207);
            nmSoLuong.Name = "nmSoLuong";
            nmSoLuong.Size = new Size(142, 23);
            nmSoLuong.TabIndex = 11;
            // 
            // cbBan
            // 
            cbBan.FormattingEnabled = true;
            cbBan.Location = new Point(73, 83);
            cbBan.Name = "cbBan";
            cbBan.Size = new Size(142, 23);
            cbBan.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(17, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(198, 23);
            txtSearch.TabIndex = 7;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(120, 236);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 48);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy toàn bộ đơn";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(17, 236);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 48);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm món";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(253, 25);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.Size = new Size(399, 401);
            dgvOrder.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnChuyenSangThanhToan);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Location = new Point(652, 25);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(146, 143);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btnChuyenSangThanhToan
            // 
            btnChuyenSangThanhToan.Location = new Point(40, 72);
            btnChuyenSangThanhToan.Name = "btnChuyenSangThanhToan";
            btnChuyenSangThanhToan.Size = new Size(77, 65);
            btnChuyenSangThanhToan.TabIndex = 10;
            btnChuyenSangThanhToan.Text = "Chuyển sang thanh toán";
            btnChuyenSangThanhToan.UseVisualStyleBackColor = true;
            btnChuyenSangThanhToan.Click += btnChuyenSangThanhToan_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(40, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 44);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(pnlTrangThaiBan);
            groupBox5.Location = new Point(658, 312);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(140, 134);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Trạng thái bàn";
            // 
            // pnlTrangThaiBan
            // 
            pnlTrangThaiBan.Location = new Point(6, 22);
            pnlTrangThaiBan.Name = "pnlTrangThaiBan";
            pnlTrangThaiBan.Size = new Size(134, 104);
            pnlTrangThaiBan.TabIndex = 0;
            pnlTrangThaiBan.Paint += pnlTrangThaiBan_Paint;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(dgvOrder);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmOrder";
            Text = "FORM_ORDER";
            Load += FORM_ORDER_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox txtSearch;
        private Button btnHuy;
        private Button btnThem;
        private TextBox txtSoHoaDon;
        private NumericUpDown nmSoLuong;
        private ComboBox cbBan;
        private DataGridView dgvOrder;
        private GroupBox groupBox3;
        private Button btnChuyenSangThanhToan;
        private Button btnXoa;
        private GroupBox groupBox5;
        private DateTimePicker dtpNgayLap;
        private Panel pnlTrangThaiBan;
        private ComboBox cbMon;
        private ComboBox cbDanhMuc;
    }
}