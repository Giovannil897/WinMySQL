using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Vistas
{
    public partial class FrmMateria : Form
    {
        Datos datos = new Datos();
        bool updating = false;
        int id = 0;
        public FrmMateria()
        {
            InitializeComponent();
        }
        public FrmMateria(int id, String materia, string CVE)
        {
            InitializeComponent();
            this.id = id;
            txtMateria.Text = materia;
            txtClaveMateria.Text = CVE;
            updating = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating==false)
            {
                bool resultado = datos.ejecutarcomando(
                    $"Insert into Materias (Materia,CVE) " +
                    $"values ('{txtMateria.Text}','{txtClaveMateria.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Materia agregada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la materia");
                }
            }
            else
            {
                bool resultado = datos.ejecutarcomando(
                    $"Update Materias set Materia='{txtMateria.Text}', CVE='{txtClaveMateria.Text}' " +
                    $"where IdMaterias={id}");
                if (resultado)
                {
                    MessageBox.Show("Materia actualizada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la materia");
                }
            }
        }
    }
}
