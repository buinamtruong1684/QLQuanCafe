namespace QLQuanCafe
{
    partial class frmBaoCao
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
            LabelTitle = new Label();
            dgvBaoCao = new DataGridView();
            panelButtons = new Panel();
            btnMonBanChay = new Button();
            btnDoanhThuTheoThang = new Button();
            btnDoanhThuTheoNgay = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LabelTitle.Location = new Point(12, 9);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(179, 25);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Báo cáo doanh thu";
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Dock = DockStyle.Fill;
            dgvBaoCao.Location = new Point(0, 60);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.ReadOnly = true;
            dgvBaoCao.Size = new Size(900, 440);
            dgvBaoCao.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.LightGray;
            panelButtons.Controls.Add(btnMonBanChay);
            panelButtons.Controls.Add(btnDoanhThuTheoThang);
            panelButtons.Controls.Add(btnDoanhThuTheoNgay);
            panelButtons.Controls.Add(LabelTitle);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(900, 60);
            panelButtons.TabIndex = 2;
            panelButtons.Paint += panelButtons_Paint;
            // 
            // btnMonBanChay
            // 
            btnMonBanChay.Location = new Point(570, 12);
            btnMonBanChay.Name = "btnMonBanChay";
            btnMonBanChay.Size = new Size(150, 35);
            btnMonBanChay.TabIndex = 3;
            btnMonBanChay.Text = "Món bán chạy";
            btnMonBanChay.Click += btnMonBanChay_Click;
            // 
            // btnDoanhThuTheoThang
            // 
            btnDoanhThuTheoThang.Location = new Point(410, 12);
            btnDoanhThuTheoThang.Name = "btnDoanhThuTheoThang";
            btnDoanhThuTheoThang.Size = new Size(150, 35);
            btnDoanhThuTheoThang.TabIndex = 2;
            btnDoanhThuTheoThang.Text = "Doanh thu theo tháng";
            btnDoanhThuTheoThang.Click += btnDoanhThuTheoThang_Click;
            // 
            // btnDoanhThuTheoNgay
            // 
            btnDoanhThuTheoNgay.Location = new Point(250, 12);
            btnDoanhThuTheoNgay.Name = "btnDoanhThuTheoNgay";
            btnDoanhThuTheoNgay.Size = new Size(150, 35);
            btnDoanhThuTheoNgay.TabIndex = 1;
            btnDoanhThuTheoNgay.Text = "Doanh thu theo ngày";
            btnDoanhThuTheoNgay.Click += btnDoanhThuTheoNgay_Click;
            // 
            // frmBaoCao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(dgvBaoCao);
            Controls.Add(panelButtons);
            Name = "frmBaoCao";
            Text = "Báo cáo thống kê";
            FormClosing += frmBaoCao_FormClosing;
            Load += frmBaoCao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelTitle;
        private DataGridView dgvBaoCao;
        private Panel panelButtons;
        private Button btnDoanhThuTheoNgay;
        private Button btnDoanhThuTheoThang;
        private Button btnMonBanChay;
    }
}
