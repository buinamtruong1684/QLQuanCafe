
namespace QLQuanCafe
{
    partial class frmBan
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
            groupBox1 = new GroupBox();
            btnLoad = new Button();
            cboTrangThai = new ComboBox();
            btnXoa = new Button();
            btnSua = new Button();
            txtTenBan = new TextBox();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            dgvBan = new DataGridView();
            groupBox2 = new GroupBox();
            lblTrangThai = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBan).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản lí bàn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtTenBan);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 193);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bàn";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.Info;
            btnLoad.Image = Properties.Resources._4213447_arrow_load_loading_refresh_reload_restart_sync_115423;
            btnLoad.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoad.Location = new Point(600, 95);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(106, 38);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click_1;
            // 
            // cboTrangThai
            // 
            cboTrangThai.BackColor = SystemColors.Info;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(156, 98);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(226, 31);
            cboTrangThai.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Image = Properties.Resources.trash_can_icon_198337;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(600, 36);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 42);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.HotTrack;
            btnSua.Image = Properties.Resources.Pencil512_44200;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(446, 95);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 38);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click_1;
            // 
            // txtTenBan
            // 
            txtTenBan.BackColor = SystemColors.Info;
            txtTenBan.Location = new Point(156, 36);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(226, 30);
            txtTenBan.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.PaleGreen;
            btnThem.Image = Properties.Resources.add_icon_icons_com_74429__1_;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(446, 38);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 40);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 107);
            label3.Name = "label3";
            label3.Size = new Size(89, 22);
            label3.TabIndex = 1;
            label3.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 44);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên bàn";
            // 
            // dgvBan
            // 
            dgvBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBan.Location = new Point(12, 249);
            dgvBan.Name = "dgvBan";
            dgvBan.RowHeadersWidth = 51;
            dgvBan.Size = new Size(767, 265);
            dgvBan.TabIndex = 2;
            dgvBan.CellClick += dgvBan_CellClick;
            dgvBan.CellContentClick += dgvBan_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTrangThai);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 520);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(767, 101);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trạng thái bàn";
            // 
            // lblTrangThai
            // 
            lblTrangThai.BackColor = Color.Lime;
            lblTrangThai.Dock = DockStyle.Fill;
            lblTrangThai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.Black;
            lblTrangThai.Location = new Point(3, 26);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(761, 72);
            lblTrangThai.TabIndex = 1;
            lblTrangThai.Text = "Trạng thái:";
            lblTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            lblTrangThai.Click += lblTrangThai_Click;
            // 
            // frmBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(791, 635);
            Controls.Add(groupBox2);
            Controls.Add(dgvBan);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmBan";
            Text = "frmBan";
            Load += frmBan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBan).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cboTrangThai;
        private TextBox txtTenBan;
        private Label label3;
        private Label label2;
        private DataGridView dgvBan;
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private Label lblTrangThai;
    }
}