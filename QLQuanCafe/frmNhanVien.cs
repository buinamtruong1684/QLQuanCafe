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
    public partial class frmNhanVien : Form
    {
        QLQuanCafeContext db = new QLQuanCafeContext();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();

            cboCaLam.Items.Add("Sáng");
            cboCaLam.Items.Add("Chiều");
            cboCaLam.Items.Add("Tối");
        }

        // LOAD
        void LoadNV()
        {
            dgvNV.DataSource = db.NhanViens.ToList();
        }

        // THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            nv.TenNv = txtTenNV.Text;
            nv.Sdt = txtSDT.Text;
            nv.CaLam = cboCaLam.Text;

            db.NhanViens.Add(nv);
            db.SaveChanges();

            LoadNV();
        }

        // SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = (int)dgvNV.CurrentRow.Cells["MaNv"].Value;

            var nv = db.NhanViens.Find(id);

            if (nv != null)
            {
                nv.TenNv = txtTenNV.Text;
                nv.Sdt = txtSDT.Text;
                nv.CaLam = cboCaLam.Text;

                db.SaveChanges();
                LoadNV();
            }
        }

        // XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = (int)dgvNV.CurrentRow.Cells["MaNv"].Value;

            var nv = db.NhanViens.Find(id);

            if (nv != null)
            {
                db.NhanViens.Remove(nv);
                db.SaveChanges();
                LoadNV();
            }
        }

        // CLICK GRID
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNV.Text = dgvNV.CurrentRow.Cells["TenNv"].Value.ToString();
            txtSDT.Text = dgvNV.CurrentRow.Cells["Sdt"].Value.ToString();
            cboCaLam.Text = dgvNV.CurrentRow.Cells["CaLam"].Value.ToString();
        }
    }
}
