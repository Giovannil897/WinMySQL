namespace WinMySQL.Vistas
{
    partial class FrmAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtPaterno = new TextBox();
            txtMaterno = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNumeroControl = new TextBox();
            txtSemestre = new TextBox();
            txtCarrera = new TextBox();
            btnAceptar = new Button();
            txtSegundo = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 10);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 71);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(19, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(454, 28);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(184, 23);
            txtPaterno.TabIndex = 4;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(19, 89);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(184, 23);
            txtMaterno.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 128);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 6;
            label4.Text = "Numero de Control";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 71);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 7;
            label5.Text = "Semestre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 71);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 8;
            label6.Text = "Carrera";
            // 
            // txtNumeroControl
            // 
            txtNumeroControl.Location = new Point(19, 147);
            txtNumeroControl.Name = "txtNumeroControl";
            txtNumeroControl.Size = new Size(184, 23);
            txtNumeroControl.TabIndex = 9;
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(235, 89);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(184, 23);
            txtSemestre.TabIndex = 10;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(454, 89);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(184, 23);
            txtCarrera.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(514, 146);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtSegundo
            // 
            txtSegundo.Location = new Point(235, 28);
            txtSegundo.Name = "txtSegundo";
            txtSegundo.Size = new Size(184, 23);
            txtSegundo.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(235, 9);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 14;
            label7.Text = "Segundo Nombre*";
            // 
            // FrmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 181);
            Controls.Add(label7);
            Controls.Add(txtSegundo);
            Controls.Add(btnAceptar);
            Controls.Add(txtCarrera);
            Controls.Add(txtSemestre);
            Controls.Add(txtNumeroControl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMaterno);
            Controls.Add(txtPaterno);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAlumno";
            Text = "Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtPaterno;
        private TextBox txtMaterno;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNumeroControl;
        private TextBox txtSemestre;
        private TextBox txtCarrera;
        private Button btnAceptar;
        private TextBox txtSegundo;
        private Label label7;
    }
}