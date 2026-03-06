using WinMySQL.Vistas;

namespace WinMySQL
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias mat = new frmMaterias();
            mat.ShowDialog();

        }
    }
}
