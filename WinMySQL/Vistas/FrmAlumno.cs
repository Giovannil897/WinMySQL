using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Vistas
{
    public partial class FrmAlumno : Form
    {
        Datos datos = new Datos();
        bool updating = false;
        int id = 0;
        public FrmAlumno()
        {
            InitializeComponent();
        }
        public FrmAlumno(int id,String Nombre,String paterno,String Materno,int NC,int semestre, String carrera)
        {
            InitializeComponent();
            this.id = id;
            txtNombre.Text= Nombre;
            txtPaterno.Text= paterno;
            txtMaterno.Text= Materno;
            txtNumeroControl.Text = NC.ToString();
            txtSemestre.Text = semestre.ToString();
            txtCarrera.Text = carrera.ToString();
            updating = true;

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = datos.ejecutarcomando(
                    $"Insert into Alumnos (Nombre,ApellidoPat,ApellidoMat,NumeroControl,Semestre,Carrera) " +
                    $"values ('{txtNombre.Text}','{txtPaterno.Text}','{txtMaterno.Text}',{txtNumeroControl.Text},{txtSemestre.Text},'{txtCarrera.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Alumno agregada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el Alumno");
                }
            }
            else
            {
                bool resultado = datos.ejecutarcomando($"Update Alumnos set Nombre='{txtNombre.Text}', ApellidoPat='{txtPaterno.Text}', " +
                    $"ApellidoMat='{txtMaterno.Text}', NumeroControl={txtNumeroControl.Text}, " +
                    $"Semestre={txtSemestre.Text}, Carrera='{txtCarrera.Text}' " +
                    $"where IdAlumnos={id}");
                if (resultado)
                {
                    MessageBox.Show("Alumno actualizada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar al Alumno");
                }
            }
        }
    }
}
