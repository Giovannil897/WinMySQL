namespace WinMySQL.Vistas
{
    partial class FrmMateria
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
            txtMateria = new TextBox();
            txtClaveMateria = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 3);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Clave de Materia";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(21, 32);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(377, 23);
            txtMateria.TabIndex = 2;
            // 
            // txtClaveMateria
            // 
            txtClaveMateria.Location = new Point(21, 107);
            txtClaveMateria.Name = "txtClaveMateria";
            txtClaveMateria.Size = new Size(251, 23);
            txtClaveMateria.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(323, 106);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 175);
            Controls.Add(btnAceptar);
            Controls.Add(txtClaveMateria);
            Controls.Add(txtMateria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMateria";
            Text = "Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMateria;
        private TextBox txtClaveMateria;
        private Button btnAceptar;
    }
}