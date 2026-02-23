namespace WinMySQL.Vistas
{
    partial class frmMaterias
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
            splitContainer1 = new SplitContainer();
            dgvMaterias = new DataGridView();
            label1 = new Label();
            txtMaterias = new TextBox();
            btnAgregarMateria = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnAgregarMateria);
            splitContainer1.Panel1.Controls.Add(txtMaterias);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvMaterias);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 83;
            splitContainer1.TabIndex = 0;
            // 
            // dgvMaterias
            // 
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Dock = DockStyle.Fill;
            dgvMaterias.Location = new Point(0, 0);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.Size = new Size(800, 363);
            dgvMaterias.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            // 
            // txtMaterias
            // 
            txtMaterias.Location = new Point(12, 27);
            txtMaterias.Name = "txtMaterias";
            txtMaterias.Size = new Size(531, 23);
            txtMaterias.TabIndex = 1;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Location = new Point(713, 27);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(75, 23);
            btnAgregarMateria.TabIndex = 2;
            btnAgregarMateria.Text = "Agregar";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            // 
            // frmMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmMaterias";
            Text = "frmMaterias";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnAgregarMateria;
        private TextBox txtMaterias;
        private Label label1;
        private DataGridView dgvMaterias;
    }
}