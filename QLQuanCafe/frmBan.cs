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
    public partial class frmBan : Form
    {
        QLQuanCafeContext db = new QLQuanCafeContext();

        public frmBan()
        {
            InitializeComponent();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            LoadBan();

            cboTrangThai.Items.Add("Trống");
            cboTrangThai.Items.Add("Có khách");
        }

        // LOAD
        void LoadBan()
        {
            dgvBan.DataSource = db.Bans.ToList();
        }

        // THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            Ban b = new Ban();

            b.TenBan = txtTenBan.Text;
            b.TrangThai = cboTrangThai.Text;

            db.Bans.Add(b);
            db.SaveChanges();

            LoadBan();
        }

        // SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = (int)dgvBan.CurrentRow.Cells["MaBan"].Value;

            var b = db.Bans.Find(id);

            if (b != null)
            {
                b.TenBan = txtTenBan.Text;
                b.TrangThai = cboTrangThai.Text;

                db.SaveChanges();
                LoadBan();
            }
        }

        // XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = (int)dgvBan.CurrentRow.Cells["MaBan"].Value;

            var b = db.Bans.Find(id);

            if (b != null)
            {
                db.Bans.Remove(b);
                db.SaveChanges();
                LoadBan();
            }
        }

        // CLICK GRID
        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenBan.Text = dgvBan.CurrentRow.Cells["TenBan"].Value.ToString();
            cboTrangThai.Text = dgvBan.CurrentRow.Cells["TrangThai"].Value.ToString();
        }
    }
}
