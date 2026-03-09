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
    public partial class FrmProfesores : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public FrmProfesores()
        {
            InitializeComponent();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idProfesor = Convert.ToInt32(dgvProfesores.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas eliminar al Profesor: " + dgvProfesores.CurrentRow.Cells[1].Value.ToString() +" "+ dgvProfesores.CurrentRow.Cells[2].Value.ToString() +" "+ dgvProfesores.CurrentRow.Cells[3].Value.ToString(),
                "sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarcomando($"delete from Profesores where IdProfesores={idProfesor}");
                if (f == true)
                {
                    MessageBox.Show("Profesor eliminado con exito", "Sistema");
                }
                else MessageBox.Show("error al eliminar el Profesor", "Sistema");
            }
        }

        private void FrmProfesores_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Profesores");
                if (ds != null)
                {
                    dgvProfesores.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmProfesores_Load(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Profesores");
                if (ds != null)
                {
                    dgvProfesores.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            FrmProfesor prof = new FrmProfesor();
            prof.Show();
        }

        private void dgvProfesores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmProfesor alumno = new FrmProfesor(
            Convert.ToInt32(dgvProfesores.CurrentRow.Cells[0].Value),
                dgvProfesores.CurrentRow.Cells[1].Value.ToString(),
                dgvProfesores.CurrentRow.Cells[2].Value.ToString(),
                dgvProfesores.CurrentRow.Cells[3].Value.ToString(),
                dgvProfesores.CurrentRow.Cells[4].Value.ToString(),
                Convert.ToInt32(dgvProfesores.CurrentRow.Cells[5].Value));
            alumno.ShowDialog();
        }
    }
}
