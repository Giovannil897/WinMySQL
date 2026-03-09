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
    public partial class FrmAlumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void FrmAlumnos_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            FrmAlumno alumn = new FrmAlumno();
            alumn.Show();
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAlumno alumno = new FrmAlumno(
            Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value),
                dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[2].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[4].Value),
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[5].Value),
                dgvAlumnos.CurrentRow.Cells[6].Value.ToString());
            alumno.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idalumno = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas eliminar al alumno: " + dgvAlumnos.CurrentRow.Cells[1].Value.ToString()+" "+ dgvAlumnos.CurrentRow.Cells[2].Value.ToString()+" "+ dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
                "sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarcomando($"delete from Alumnos where IdAlumnos={idalumno}");
                if (f == true)
                {
                    MessageBox.Show("Alumno eliminado con exito", "Sistema");
                }
                else MessageBox.Show("error al eliminar al alumno", "Sistema");
            }
        }
    }
}
