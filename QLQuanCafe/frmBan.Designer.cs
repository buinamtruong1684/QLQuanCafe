
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
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboTrangThai = new ComboBox();
            txtTenBan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgvBan = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBan).BeginInit();
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
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(txtTenBan);
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
            btnLoad.Location = new Point(625, 98);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.Info;
            btnXoa.Location = new Point(625, 40);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Info;
            btnSua.Location = new Point(478, 98);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Info;
            btnThem.Location = new Point(478, 37);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
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
            // txtTenBan
            // 
            txtTenBan.BackColor = SystemColors.Info;
            txtTenBan.Location = new Point(156, 36);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(226, 30);
            txtTenBan.TabIndex = 2;
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
            dgvBan.Location = new Point(12, 244);
            dgvBan.Name = "dgvBan";
            dgvBan.RowHeadersWidth = 51;
            dgvBan.Size = new Size(767, 265);
            dgvBan.TabIndex = 2;
            dgvBan.CellClick += dgvBan_CellClick;
            dgvBan.CellContentClick += dgvBan_CellContentClick;
            // 
            // frmBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(791, 531);
            Controls.Add(dgvBan);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmBan";
            Text = "frmBan";
            Load += frmBan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBan).EndInit();
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
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboTrangThai;
        private TextBox txtTenBan;
        private Label label3;
        private Label label2;
        private DataGridView dgvBan;
    }
}