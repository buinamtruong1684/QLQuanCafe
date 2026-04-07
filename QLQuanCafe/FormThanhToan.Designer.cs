namespace QLQuanCafe
{
    partial class FormThanhToan
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
            panel1 = new Panel();
            label1 = new Label();
            pnlChuyenKhoan = new Panel();
            groupBox5 = new GroupBox();
            lblSoTienQR = new Label();
            label4 = new Label();
            label13 = new Label();
            picQR = new PictureBox();
            groupBox3 = new GroupBox();
            lblBankInfo = new Label();
            groupBox2 = new GroupBox();
            rbThe = new RadioButton();
            rbChuyenKhoan = new RadioButton();
            rbTienMat = new RadioButton();
            panel2 = new Panel();
            panel5 = new Panel();
            lblMaHD = new Label();
            lblBan = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox4 = new GroupBox();
            label12 = new Label();
            groupBox1 = new GroupBox();
            lblTienThua = new Label();
            txtTienKhach = new TextBox();
            label10 = new Label();
            label9 = new Label();
            lblTongFinal = new Label();
            lblVAT = new Label();
            lblGiamGia = new Label();
            lblSubTotal = new Label();
            comboBox1 = new ComboBox();
            numGiamGia = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dgvThanhToan = new DataGridView();
            lbl1 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQR).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGiamGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 80);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 18);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "THANH TOÁN HÓA ĐƠN";
            // 
            // pnlChuyenKhoan
            // 
            pnlChuyenKhoan.Location = new Point(703, 334);
            pnlChuyenKhoan.Name = "pnlChuyenKhoan";
            pnlChuyenKhoan.Size = new Size(453, 309);
            pnlChuyenKhoan.TabIndex = 2;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblSoTienQR);
            groupBox5.Controls.Add(picQR);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label13);
            groupBox5.Location = new Point(700, 334);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(450, 317);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Quét mã QR";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // lblSoTienQR
            // 
            lblSoTienQR.AutoSize = true;
            lblSoTienQR.Location = new Point(249, 242);
            lblSoTienQR.Name = "lblSoTienQR";
            lblSoTienQR.Size = new Size(71, 15);
            lblSoTienQR.TabIndex = 8;
            lblSoTienQR.Text = "lblSoTienQR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 242);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "Số tiền";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(141, 271);
            label13.Name = "label13";
            label13.Size = new Size(174, 15);
            label13.TabIndex = 2;
            label13.Text = "Vui lòng quét QR để thanh toán";
            // 
            // picQR
            // 
            picQR.Image = Properties.Resources._1775533674852;
            picQR.Location = new Point(104, 12);
            picQR.Name = "picQR";
            picQR.Size = new Size(225, 227);
            picQR.SizeMode = PictureBoxSizeMode.StretchImage;
            picQR.TabIndex = 0;
            picQR.TabStop = false;
            picQR.Click += picQR_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.WhiteSmoke;
            groupBox3.Controls.Add(lblBankInfo);
            groupBox3.Location = new Point(709, 231);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(421, 98);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin chuyển khoản";
            // 
            // lblBankInfo
            // 
            lblBankInfo.AutoSize = true;
            lblBankInfo.Location = new Point(30, 30);
            lblBankInfo.Name = "lblBankInfo";
            lblBankInfo.Size = new Size(178, 60);
            lblBankInfo.TabIndex = 2;
            lblBankInfo.Text = "Ngân hàng: MB Bank\nSố tài khoản: 1234 5678 9999\nChủ tài khoản: QUAN CAFE ABC\n* Nội dung: HDxxxxx";
            lblBankInfo.Click += label11_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(rbThe);
            groupBox2.Controls.Add(rbChuyenKhoan);
            groupBox2.Controls.Add(rbTienMat);
            groupBox2.Location = new Point(706, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 132);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Phương thức thanh toán";
            // 
            // rbThe
            // 
            rbThe.AutoSize = true;
            rbThe.Location = new Point(60, 109);
            rbThe.Name = "rbThe";
            rbThe.Size = new Size(71, 19);
            rbThe.TabIndex = 2;
            rbThe.TabStop = true;
            rbThe.Text = "Quẹt thẻ";
            rbThe.UseVisualStyleBackColor = true;
            rbThe.CheckedChanged += rbThe_CheckedChanged;
            // 
            // rbChuyenKhoan
            // 
            rbChuyenKhoan.AutoSize = true;
            rbChuyenKhoan.Location = new Point(60, 74);
            rbChuyenKhoan.Name = "rbChuyenKhoan";
            rbChuyenKhoan.Size = new Size(102, 19);
            rbChuyenKhoan.TabIndex = 1;
            rbChuyenKhoan.TabStop = true;
            rbChuyenKhoan.Text = "Chuyển khoản\n";
            rbChuyenKhoan.UseVisualStyleBackColor = true;
            rbChuyenKhoan.CheckedChanged += rbChuyenKhoan_CheckedChanged;
            // 
            // rbTienMat
            // 
            rbTienMat.AutoSize = true;
            rbTienMat.Location = new Point(60, 33);
            rbTienMat.Name = "rbTienMat";
            rbTienMat.Size = new Size(71, 19);
            rbTienMat.TabIndex = 0;
            rbTienMat.TabStop = true;
            rbTienMat.Text = "Tiền mặt";
            rbTienMat.UseVisualStyleBackColor = true;
            rbTienMat.CheckedChanged += rbTienMat_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 563);
            panel2.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblMaHD);
            panel5.Controls.Add(lblBan);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(groupBox4);
            panel5.Controls.Add(groupBox1);
            panel5.Controls.Add(dgvThanhToan);
            panel5.Controls.Add(lbl1);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(697, 563);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Location = new Point(150, 13);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(38, 15);
            lblMaHD.TabIndex = 8;
            lblMaHD.Text = "label4";
            // 
            // lblBan
            // 
            lblBan.AutoSize = true;
            lblBan.Location = new Point(504, 13);
            lblBan.Name = "lblBan";
            lblBan.Size = new Size(38, 15);
            lblBan.TabIndex = 7;
            lblBan.Text = "label4";
            // 
            // button3
            // 
            button3.Location = new Point(15, 517);
            button3.Name = "button3";
            button3.Size = new Size(101, 34);
            button3.TabIndex = 6;
            button3.Text = "Quay lại";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Location = new Point(426, 518);
            button2.Name = "button2";
            button2.Size = new Size(274, 38);
            button2.TabIndex = 5;
            button2.Text = "Thanh toán , in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(150, 518);
            button1.Name = "button1";
            button1.Size = new Size(274, 42);
            button1.TabIndex = 4;
            button1.Text = "Thanh toán ko in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(700, 254);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(430, 211);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin chuyển khoản";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 30);
            label12.Name = "label12";
            label12.Size = new Size(178, 60);
            label12.TabIndex = 2;
            label12.Text = "Ngân hàng: MB Bank\nSố tài khoản: 1234 5678 9999\nChủ tài khoản: QUAN CAFE ABC\n* Nội dung: HDxxxxx";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTienThua);
            groupBox1.Controls.Add(txtTienKhach);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblTongFinal);
            groupBox1.Controls.Add(lblVAT);
            groupBox1.Controls.Add(lblGiamGia);
            groupBox1.Controls.Add(lblSubTotal);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(numGiamGia);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(3, 303);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(694, 209);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết thanh toán";
            // 
            // lblTienThua
            // 
            lblTienThua.AutoSize = true;
            lblTienThua.BackColor = Color.SteelBlue;
            lblTienThua.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTienThua.Location = new Point(501, 185);
            lblTienThua.Name = "lblTienThua";
            lblTienThua.Size = new Size(82, 17);
            lblTienThua.TabIndex = 14;
            lblTienThua.Text = "lblTienThua";
            // 
            // txtTienKhach
            // 
            txtTienKhach.Location = new Point(453, 148);
            txtTienKhach.Name = "txtTienKhach";
            txtTienKhach.Size = new Size(217, 23);
            txtTienKhach.TabIndex = 13;
            txtTienKhach.TextChanged += txtTienKhach_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 185);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 12;
            label10.Text = "Tiền thối lại";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 151);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 11;
            label9.Text = "Khách thanh toán";
            // 
            // lblTongFinal
            // 
            lblTongFinal.AutoSize = true;
            lblTongFinal.BackColor = Color.Brown;
            lblTongFinal.Location = new Point(573, 110);
            lblTongFinal.Name = "lblTongFinal";
            lblTongFinal.Size = new Size(71, 15);
            lblTongFinal.TabIndex = 10;
            lblTongFinal.Text = "lblTongFinal";
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.Location = new Point(590, 84);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(39, 15);
            lblVAT.TabIndex = 9;
            lblVAT.Text = "lblVAT";
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Location = new Point(590, 57);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(65, 15);
            lblGiamGia.TabIndex = 8;
            lblGiamGia.Text = "lblGiamGia";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(590, 26);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(65, 15);
            lblSubTotal.TabIndex = 7;
            lblSubTotal.Text = "lblSubTotal";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(423, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(39, 23);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "%";
            // 
            // numGiamGia
            // 
            numGiamGia.Location = new Point(270, 49);
            numGiamGia.Name = "numGiamGia";
            numGiamGia.Size = new Size(120, 23);
            numGiamGia.TabIndex = 5;
            numGiamGia.ValueChanged += numGiamGia_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 110);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 4;
            label8.Text = "Tổng cộng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 84);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 3;
            label7.Text = "Thuế VAT (10%)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 57);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 2;
            label6.Text = "Giảm giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 26);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 1;
            label5.Text = "Tổng tiền hàng";
            // 
            // dgvThanhToan
            // 
            dgvThanhToan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhToan.Location = new Point(0, 31);
            dgvThanhToan.Name = "dgvThanhToan";
            dgvThanhToan.Size = new Size(697, 279);
            dgvThanhToan.TabIndex = 2;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(426, 13);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(43, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Số bàn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 13);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 0;
            label3.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 59);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // FormThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 643);
            Controls.Add(groupBox5);
            Controls.Add(panel2);
            Controls.Add(groupBox3);
            Controls.Add(pnlChuyenKhoan);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "FormThanhToan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormThanhToan";
            Load += FormThanhToan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picQR).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGiamGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel pnlChuyenKhoan;
        private Panel panel2;
        private Panel panel5;
        private DataGridView dgvThanhToan;
        private Label lbl1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblTongFinal;
        private Label lblVAT;
        private Label lblGiamGia;
        private Label lblSubTotal;
        private ComboBox comboBox1;
        private NumericUpDown numGiamGia;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private Label lblTienThua;
        private TextBox txtTienKhach;
        private Label label10;
        private Label label9;
        private GroupBox groupBox3;
        private Label lblBankInfo;
        private RadioButton rbThe;
        private RadioButton rbChuyenKhoan;
        private RadioButton rbTienMat;
        private GroupBox groupBox4;
        private Label label12;
        private GroupBox groupBox5;
        private Label label13;
        private PictureBox picQR;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label lblBan;
        private Label lblMaHD;
        private Label lblSoTienQR;
        private Label label4;
    }
}