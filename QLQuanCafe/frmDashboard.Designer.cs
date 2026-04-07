namespace QLQuanCafe
{
    partial class frmDashboard
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
            pnlHeader = new Panel();
            lblHeader = new Label();
            lblDate = new Label();
            pnlTongTienHom = new Panel();
            lblTongTienHom = new Label();
            lblTongTienHomSub = new Label();
            lblTongTienHomTitle = new Label();
            pnlSoBanDangDung = new Panel();
            lblSoBanDangDung = new Label();
            lblSoBanDangDungSub = new Label();
            lblSoBanDangDungTitle = new Label();
            pnlSoHoaDonHom = new Panel();
            lblSoHoaDonHom = new Label();
            lblSoHoaDonHomSub = new Label();
            lblSoHoaDonHomTitle = new Label();
            pnlCards = new Panel();
            pnlBottom = new Panel();
            pnlRecentInvoices = new Panel();
            lblRecentInvoicesTitle = new Label();
            dgvRecentInvoices = new DataGridView();
            pnlTopSellingItems = new Panel();
            lblTopSellingItemsTitle = new Label();
            dgvTopSellingItems = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlTongTienHom.SuspendLayout();
            pnlSoBanDangDung.SuspendLayout();
            pnlSoHoaDonHom.SuspendLayout();
            pnlCards.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlRecentInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentInvoices).BeginInit();
            pnlTopSellingItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopSellingItems).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(lblDate);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(15);
            pnlHeader.Size = new Size(1000, 50);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.Location = new Point(15, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(219, 25);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "\U0001f950 Tổng quan hôm nay";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F);
            lblDate.ForeColor = Color.Gray;
            lblDate.Location = new Point(800, 18);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(141, 19);
            lblDate.TabIndex = 1;
            lblDate.Text = "Thứ Ba, 7 tháng 4, 21";
            // 
            // pnlTongTienHom
            // 
            pnlTongTienHom.BackColor = Color.White;
            pnlTongTienHom.BorderStyle = BorderStyle.FixedSingle;
            pnlTongTienHom.Controls.Add(lblTongTienHom);
            pnlTongTienHom.Controls.Add(lblTongTienHomSub);
            pnlTongTienHom.Controls.Add(lblTongTienHomTitle);
            pnlTongTienHom.Location = new Point(15, 15);
            pnlTongTienHom.Name = "pnlTongTienHom";
            pnlTongTienHom.Size = new Size(280, 100);
            pnlTongTienHom.TabIndex = 0;
            // 
            // lblTongTienHom
            // 
            lblTongTienHom.AutoSize = true;
            lblTongTienHom.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTongTienHom.Location = new Point(10, 28);
            lblTongTienHom.Name = "lblTongTienHom";
            lblTongTienHom.Size = new Size(57, 37);
            lblTongTienHom.TabIndex = 1;
            lblTongTienHom.Text = "0 đ";
            // 
            // lblTongTienHomSub
            // 
            lblTongTienHomSub.AutoSize = true;
            lblTongTienHomSub.Font = new Font("Segoe UI", 8F);
            lblTongTienHomSub.ForeColor = Color.Green;
            lblTongTienHomSub.Location = new Point(10, 66);
            lblTongTienHomSub.Name = "lblTongTienHomSub";
            lblTongTienHomSub.Size = new Size(87, 13);
            lblTongTienHomSub.TabIndex = 2;
            lblTongTienHomSub.Text = "↑ số vị hôm qua";
            // 
            // lblTongTienHomTitle
            // 
            lblTongTienHomTitle.AutoSize = true;
            lblTongTienHomTitle.Font = new Font("Segoe UI", 9F);
            lblTongTienHomTitle.ForeColor = Color.Gray;
            lblTongTienHomTitle.Location = new Point(10, 8);
            lblTongTienHomTitle.Name = "lblTongTienHomTitle";
            lblTongTienHomTitle.Size = new Size(107, 15);
            lblTongTienHomTitle.TabIndex = 0;
            lblTongTienHomTitle.Text = "🏪 Tổng doanh thu";
            // 
            // pnlSoBanDangDung
            // 
            pnlSoBanDangDung.BackColor = Color.White;
            pnlSoBanDangDung.BorderStyle = BorderStyle.FixedSingle;
            pnlSoBanDangDung.Controls.Add(lblSoBanDangDung);
            pnlSoBanDangDung.Controls.Add(lblSoBanDangDungSub);
            pnlSoBanDangDung.Controls.Add(lblSoBanDangDungTitle);
            pnlSoBanDangDung.Location = new Point(320, 15);
            pnlSoBanDangDung.Name = "pnlSoBanDangDung";
            pnlSoBanDangDung.Size = new Size(280, 100);
            pnlSoBanDangDung.TabIndex = 1;
            // 
            // lblSoBanDangDung
            // 
            lblSoBanDangDung.AutoSize = true;
            lblSoBanDangDung.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSoBanDangDung.Location = new Point(10, 28);
            lblSoBanDangDung.Name = "lblSoBanDangDung";
            lblSoBanDangDung.Size = new Size(75, 37);
            lblSoBanDangDung.TabIndex = 1;
            lblSoBanDangDung.Text = "0 / 0";
            // 
            // lblSoBanDangDungSub
            // 
            lblSoBanDangDungSub.AutoSize = true;
            lblSoBanDangDungSub.Font = new Font("Segoe UI", 8F);
            lblSoBanDangDungSub.ForeColor = Color.Gray;
            lblSoBanDangDungSub.Location = new Point(10, 66);
            lblSoBanDangDungSub.Name = "lblSoBanDangDungSub";
            lblSoBanDangDungSub.Size = new Size(72, 13);
            lblSoBanDangDungSub.TabIndex = 2;
            lblSoBanDangDungSub.Text = "Tổng số bàn";
            // 
            // lblSoBanDangDungTitle
            // 
            lblSoBanDangDungTitle.AutoSize = true;
            lblSoBanDangDungTitle.Font = new Font("Segoe UI", 9F);
            lblSoBanDangDungTitle.ForeColor = Color.Gray;
            lblSoBanDangDungTitle.Location = new Point(10, 8);
            lblSoBanDangDungTitle.Name = "lblSoBanDangDungTitle";
            lblSoBanDangDungTitle.Size = new Size(100, 15);
            lblSoBanDangDungTitle.TabIndex = 0;
            lblSoBanDangDungTitle.Text = "\U0001fa91 Bàn đang dùng";
            // 
            // pnlSoHoaDonHom
            // 
            pnlSoHoaDonHom.BackColor = Color.White;
            pnlSoHoaDonHom.BorderStyle = BorderStyle.FixedSingle;
            pnlSoHoaDonHom.Controls.Add(lblSoHoaDonHom);
            pnlSoHoaDonHom.Controls.Add(lblSoHoaDonHomSub);
            pnlSoHoaDonHom.Controls.Add(lblSoHoaDonHomTitle);
            pnlSoHoaDonHom.Location = new Point(625, 15);
            pnlSoHoaDonHom.Name = "pnlSoHoaDonHom";
            pnlSoHoaDonHom.Size = new Size(280, 100);
            pnlSoHoaDonHom.TabIndex = 2;
            // 
            // lblSoHoaDonHom
            // 
            lblSoHoaDonHom.AutoSize = true;
            lblSoHoaDonHom.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSoHoaDonHom.Location = new Point(10, 28);
            lblSoHoaDonHom.Name = "lblSoHoaDonHom";
            lblSoHoaDonHom.Size = new Size(33, 37);
            lblSoHoaDonHom.TabIndex = 1;
            lblSoHoaDonHom.Text = "0";
            // 
            // lblSoHoaDonHomSub
            // 
            lblSoHoaDonHomSub.AutoSize = true;
            lblSoHoaDonHomSub.Font = new Font("Segoe UI", 8F);
            lblSoHoaDonHomSub.ForeColor = Color.Gray;
            lblSoHoaDonHomSub.Location = new Point(10, 66);
            lblSoHoaDonHomSub.Name = "lblSoHoaDonHomSub";
            lblSoHoaDonHomSub.Size = new Size(109, 13);
            lblSoHoaDonHomSub.TabIndex = 2;
            lblSoHoaDonHomSub.Text = "Trung bình 0 đ / HĐ";
            // 
            // lblSoHoaDonHomTitle
            // 
            lblSoHoaDonHomTitle.AutoSize = true;
            lblSoHoaDonHomTitle.Font = new Font("Segoe UI", 9F);
            lblSoHoaDonHomTitle.ForeColor = Color.Gray;
            lblSoHoaDonHomTitle.Location = new Point(10, 8);
            lblSoHoaDonHomTitle.Name = "lblSoHoaDonHomTitle";
            lblSoHoaDonHomTitle.Size = new Size(116, 15);
            lblSoHoaDonHomTitle.TabIndex = 0;
            lblSoHoaDonHomTitle.Text = "📋 Hoá đơn hôm nay";
            // 
            // pnlCards
            // 
            pnlCards.BackColor = Color.White;
            pnlCards.Controls.Add(pnlTongTienHom);
            pnlCards.Controls.Add(pnlSoBanDangDung);
            pnlCards.Controls.Add(pnlSoHoaDonHom);
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(0, 50);
            pnlCards.Name = "pnlCards";
            pnlCards.Padding = new Padding(15);
            pnlCards.Size = new Size(1000, 130);
            pnlCards.TabIndex = 1;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(pnlRecentInvoices);
            pnlBottom.Controls.Add(pnlTopSellingItems);
            pnlBottom.Dock = DockStyle.Fill;
            pnlBottom.Location = new Point(0, 180);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(15);
            pnlBottom.Size = new Size(1000, 300);
            pnlBottom.TabIndex = 2;
            // 
            // pnlRecentInvoices
            // 
            pnlRecentInvoices.BackColor = Color.White;
            pnlRecentInvoices.BorderStyle = BorderStyle.FixedSingle;
            pnlRecentInvoices.Controls.Add(lblRecentInvoicesTitle);
            pnlRecentInvoices.Controls.Add(dgvRecentInvoices);
            pnlRecentInvoices.Dock = DockStyle.Left;
            pnlRecentInvoices.Location = new Point(15, 15);
            pnlRecentInvoices.Name = "pnlRecentInvoices";
            pnlRecentInvoices.Padding = new Padding(10);
            pnlRecentInvoices.Size = new Size(470, 270);
            pnlRecentInvoices.TabIndex = 0;
            // 
            // lblRecentInvoicesTitle
            // 
            lblRecentInvoicesTitle.AutoSize = true;
            lblRecentInvoicesTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRecentInvoicesTitle.Location = new Point(10, 10);
            lblRecentInvoicesTitle.Name = "lblRecentInvoicesTitle";
            lblRecentInvoicesTitle.Size = new Size(127, 20);
            lblRecentInvoicesTitle.TabIndex = 0;
            lblRecentInvoicesTitle.Text = "Hoá đơn gần đây";
            // 
            // dgvRecentInvoices
            // 
            dgvRecentInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentInvoices.BackgroundColor = Color.White;
            dgvRecentInvoices.BorderStyle = BorderStyle.None;
            dgvRecentInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentInvoices.Location = new Point(10, 35);
            dgvRecentInvoices.Name = "dgvRecentInvoices";
            dgvRecentInvoices.Size = new Size(450, 225);
            dgvRecentInvoices.TabIndex = 1;
            // 
            // pnlTopSellingItems
            // 
            pnlTopSellingItems.BackColor = Color.White;
            pnlTopSellingItems.BorderStyle = BorderStyle.FixedSingle;
            pnlTopSellingItems.Controls.Add(lblTopSellingItemsTitle);
            pnlTopSellingItems.Controls.Add(dgvTopSellingItems);
            pnlTopSellingItems.Dock = DockStyle.Right;
            pnlTopSellingItems.Location = new Point(500, 15);
            pnlTopSellingItems.Name = "pnlTopSellingItems";
            pnlTopSellingItems.Padding = new Padding(10);
            pnlTopSellingItems.Size = new Size(485, 270);
            pnlTopSellingItems.TabIndex = 1;
            // 
            // lblTopSellingItemsTitle
            // 
            lblTopSellingItemsTitle.AutoSize = true;
            lblTopSellingItemsTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTopSellingItemsTitle.Location = new Point(10, 10);
            lblTopSellingItemsTitle.Name = "lblTopSellingItemsTitle";
            lblTopSellingItemsTitle.Size = new Size(107, 20);
            lblTopSellingItemsTitle.TabIndex = 0;
            lblTopSellingItemsTitle.Text = "Món bán chạy";
            // 
            // dgvTopSellingItems
            // 
            dgvTopSellingItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopSellingItems.BackgroundColor = Color.White;
            dgvTopSellingItems.BorderStyle = BorderStyle.None;
            dgvTopSellingItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopSellingItems.Location = new Point(10, 35);
            dgvTopSellingItems.Name = "dgvTopSellingItems";
            dgvTopSellingItems.Size = new Size(465, 225);
            dgvTopSellingItems.TabIndex = 1;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 480);
            Controls.Add(pnlBottom);
            Controls.Add(pnlCards);
            Controls.Add(pnlHeader);
            Name = "frmDashboard";
            Text = "Tổng quan";
            FormClosing += frmDashboard_FormClosing;
            Load += frmDashboard_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlTongTienHom.ResumeLayout(false);
            pnlTongTienHom.PerformLayout();
            pnlSoBanDangDung.ResumeLayout(false);
            pnlSoBanDangDung.PerformLayout();
            pnlSoHoaDonHom.ResumeLayout(false);
            pnlSoHoaDonHom.PerformLayout();
            pnlCards.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlRecentInvoices.ResumeLayout(false);
            pnlRecentInvoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentInvoices).EndInit();
            pnlTopSellingItems.ResumeLayout(false);
            pnlTopSellingItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopSellingItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblDate;
        private Panel pnlTongTienHom;
        private Label lblTongTienHomTitle;
        private Label lblTongTienHom;
        private Label lblTongTienHomSub;
        private Panel pnlSoBanDangDung;
        private Label lblSoBanDangDungTitle;
        private Label lblSoBanDangDung;
        private Label lblSoBanDangDungSub;
        private Panel pnlSoHoaDonHom;
        private Label lblSoHoaDonHomTitle;
        private Label lblSoHoaDonHom;
        private Label lblSoHoaDonHomSub;
        private Panel pnlCards;
        private Panel pnlBottom;
        private Panel pnlRecentInvoices;
        private Label lblRecentInvoicesTitle;
        private DataGridView dgvRecentInvoices;
        private Panel pnlTopSellingItems;
        private Label lblTopSellingItemsTitle;
        private DataGridView dgvTopSellingItems;
    }
}
