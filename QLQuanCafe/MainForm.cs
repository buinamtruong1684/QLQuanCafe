namespace QLQuanCafe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gọiMónThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder f = new frmOrder();
            f.MdiParent = this;
            f.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
