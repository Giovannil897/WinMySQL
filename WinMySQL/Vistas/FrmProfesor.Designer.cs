namespace WinMySQL.Vistas
{
    partial class FrmProfesor
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtPaterno = new TextBox();
            txtMaterno = new TextBox();
            txtArea = new TextBox();
            txtMaterias = new TextBox();
            btnAceptar = new Button();
            label6 = new Label();
            txtSegundo = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(452, 82);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 13;
            label5.Text = "Numero de Materias";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 82);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 12;
            label4.Text = "Area de trabajo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 82);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 11;
            label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(452, 21);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 10;
            label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(17, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 23);
            txtNombre.TabIndex = 15;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(452, 39);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(175, 23);
            txtPaterno.TabIndex = 16;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(17, 100);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(175, 23);
            txtMaterno.TabIndex = 17;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(233, 100);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(175, 23);
            txtArea.TabIndex = 18;
            // 
            // txtMaterias
            // 
            txtMaterias.Location = new Point(452, 100);
            txtMaterias.Name = "txtMaterias";
            txtMaterias.Size = new Size(175, 23);
            txtMaterias.TabIndex = 19;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(265, 140);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(117, 23);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(233, 21);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 21;
            label6.Text = "Segundo Nombre*";
            // 
            // txtSegundo
            // 
            txtSegundo.Location = new Point(233, 39);
            txtSegundo.Name = "txtSegundo";
            txtSegundo.Size = new Size(175, 23);
            txtSegundo.TabIndex = 22;
            // 
            // FrmProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 185);
            Controls.Add(txtSegundo);
            Controls.Add(label6);
            Controls.Add(btnAceptar);
            Controls.Add(txtMaterias);
            Controls.Add(txtArea);
            Controls.Add(txtMaterno);
            Controls.Add(txtPaterno);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProfesor";
            Text = "Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtPaterno;
        private TextBox txtMaterno;
        private TextBox txtArea;
        private TextBox txtMaterias;
        private Button btnAceptar;
        private Label label6;
        private TextBox txtSegundo;
    }
}