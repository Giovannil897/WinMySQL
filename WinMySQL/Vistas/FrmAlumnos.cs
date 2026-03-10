
using OfficeOpenXml;
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
        OpenFileDialog ofdExcel = new OpenFileDialog();

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
            if (MessageBox.Show("Deseas eliminar al alumno: " + dgvAlumnos.CurrentRow.Cells[1].Value.ToString() + " " + dgvAlumnos.CurrentRow.Cells[2].Value.ToString() + " " + dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
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

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string path;
            DialogResult dr = ofdExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = ofdExcel.FileName;
                ExcelPackage.License.SetNonCommercialPersonal("Giovanni");
                using (ExcelPackage excel = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet ws = excel.Workbook.Worksheets[0];
                    int rowCount = ws.Dimension.Rows;
                    int columnn = ws.Dimension.Columns;
                    DataTable dt = new DataTable();
                    for (int col = 1; col <= columnn; col++)
                    {
                        dt.Columns.Add(ws.Cells[1, col].Value.ToString());
                    }
                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow drnew = dt.NewRow();
                        for (int col = 1; col <= columnn; col++)
                        {
                            drnew[col - 1] = ws.Cells[row, col].Value.ToString();
                        }
                        dt.Rows.Add(drnew);
                        String comando;
                    }
                }
            }

        }
    }
}
