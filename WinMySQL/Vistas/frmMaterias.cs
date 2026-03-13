using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Vistas
{
    public partial class frmMaterias : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public frmMaterias()
        {
            InitializeComponent();
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Materias");
                if (ds != null)
                {
                    dgvMaterias.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            FrmMateria mat = new FrmMateria();
            mat.Show();
        }

        private void frmMaterias_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Materias");
                if (ds != null)
                {
                    dgvMaterias.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvMaterias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmMateria materia = new FrmMateria(
            Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value),
                dgvMaterias.CurrentRow.Cells[1].Value.ToString(),
                dgvMaterias.CurrentRow.Cells[2].Value.ToString());
            materia.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idmateria = Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas eliminar la materia: " + dgvMaterias.CurrentRow.Cells[1].Value.ToString(), "sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarcomando($"delete from Materias where IdMaterias={idmateria}");
                if (f == true)
                {
                    MessageBox.Show("materia eliminada con exito", "Sistema");
                }
                else MessageBox.Show("error al eliminar la materia", "Sistema");
            }

        }


        private void Busqueda()
        {
            ds = datos.ejecutar($"Select * from Alumnos where Nombre like ('%{txtMaterias.Text}%')");
            if (ds != null)
            {
                dgvMaterias.DataSource = ds.Tables[0];
            }
        }

        private void txtMaterias_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Busqueda();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
