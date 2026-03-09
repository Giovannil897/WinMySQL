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
    public partial class FrmProfesor : Form
    {
        Datos datos = new Datos();
        bool updating = false;
        int id = 0;
        public FrmProfesor()
        {
            InitializeComponent();
        }
        public FrmProfesor(int id, String Nombre, String paterno, String Materno, String Area, int Materias)
        {
            InitializeComponent();
            this.id = id;
            txtNombre.Text = Nombre;
            txtPaterno.Text = paterno;
            txtMaterno.Text = Materno;
            txtArea.Text = Area.ToString();
            txtMaterias.Text = Materias.ToString();
            updating = true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = datos.ejecutarcomando(
                    $"Insert into Profesores (Nombre,ApellidoPat,ApellidoMat,Area,NoMaterias) " +
                    $"values ('{txtNombre.Text}','{txtPaterno.Text}','{txtMaterno.Text}','{txtArea.Text}',{txtMaterias.Text})");

                if (resultado)
                {
                    MessageBox.Show("Profesor agregada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar al Profesor");
                }
            }
            else
            {
                bool resultado = datos.ejecutarcomando($"Update Profesor set Nombre='{txtNombre.Text}', ApellidoPat='{txtPaterno.Text}', " +
                    $"ApellidoMat='{txtMaterno.Text}', Area={txtArea.Text}, " +
                    $"NoMaterias={txtMaterias.Text}" +
                    $"where IdProfesores={id}");
                if (resultado)
                {
                    MessageBox.Show("Profesor actualizada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar al Profesor");
                }
            }
        }
    }
}
