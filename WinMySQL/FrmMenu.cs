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

        private void alumnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAlumnos alu = new FrmAlumnos();
            alu.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfesores prof = new FrmProfesores();
            prof.Show();
        }
    }
}
