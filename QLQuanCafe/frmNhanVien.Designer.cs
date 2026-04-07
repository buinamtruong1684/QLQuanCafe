
namespace QLQuanCafe
{
    partial class frmNhanVien
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtSDT = new TextBox();
            btnLoad = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboCaLam = new ComboBox();
            txtTenNV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvNV = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboCaLam);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 193);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 143);
            label4.Name = "label4";
            label4.Size = new Size(66, 22);
            label4.TabIndex = 9;
            label4.Text = "Ca làm";
            // 
            // txtSDT
            // 
            txtSDT.BackColor = SystemColors.Info;
            txtSDT.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDT.Location = new Point(156, 86);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(226, 30);
            txtSDT.TabIndex = 8;
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
            // cboCaLam
            // 
            cboCaLam.BackColor = SystemColors.Info;
            cboCaLam.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCaLam.FormattingEnabled = true;
            cboCaLam.Location = new Point(156, 134);
            cboCaLam.Name = "cboCaLam";
            cboCaLam.Size = new Size(226, 30);
            cboCaLam.TabIndex = 3;
            // 
            // txtTenNV
            // 
            txtTenNV.BackColor = SystemColors.Info;
            txtTenNV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenNV.Location = new Point(156, 36);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(226, 30);
            txtTenNV.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 94);
            label3.Name = "label3";
            label3.Size = new Size(47, 22);
            label3.TabIndex = 1;
            label3.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 44);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 38);
            label1.TabIndex = 3;
            label1.Text = "Quản lí nhân viên";
            // 
            // dgvNV
            // 
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.Location = new Point(16, 235);
            dgvNV.Name = "dgvNV";
            dgvNV.RowHeadersWidth = 51;
            dgvNV.Size = new Size(767, 265);
            dgvNV.TabIndex = 5;
            dgvNV.CellClick += dgvNV_CellClick;
            dgvNV.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(801, 505);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dgvNV);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtSDT;
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboCaLam;
        private TextBox txtTenNV;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvNV;
    }
}