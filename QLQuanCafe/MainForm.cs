namespace QLQuanCafe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCao form = new frmBaoCao();
            form.ShowDialog();
        }

        private void DashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDashboard form = new frmDashboard();
            form.ShowDialog();
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
