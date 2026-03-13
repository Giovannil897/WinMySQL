namespace WinMySQL.Vistas
{
    partial class FrmAlumnos
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btnImportar = new Button();
            btnAgregarAlumno = new Button();
            txtAlumnos = new TextBox();
            label1 = new Label();
            dgvAlumnos = new DataGridView();
            cmsAlumno = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            cmsAlumno.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(btnImportar);
            splitContainer1.Panel1.Controls.Add(btnAgregarAlumno);
            splitContainer1.Panel1.Controls.Add(txtAlumnos);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAlumnos);
            splitContainer1.Size = new Size(883, 450);
            splitContainer1.SplitterDistance = 105;
            splitContainer1.TabIndex = 0;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(690, 40);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(75, 23);
            btnImportar.TabIndex = 6;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.Location = new Point(568, 40);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(75, 23);
            btnAgregarAlumno.TabIndex = 5;
            btnAgregarAlumno.Text = "Agregar";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // txtAlumnos
            // 
            txtAlumnos.Location = new Point(3, 41);
            txtAlumnos.Name = "txtAlumnos";
            txtAlumnos.Size = new Size(531, 23);
            txtAlumnos.TabIndex = 4;
            txtAlumnos.TextChanged += txtMaterias_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Buscar";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.ContextMenuStrip = cmsAlumno;
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.Location = new Point(0, 0);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(883, 341);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellContentDoubleClick += dgvAlumnos_CellContentDoubleClick;
            // 
            // cmsAlumno
            // 
            cmsAlumno.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cmsAlumno.Name = "cmsAlumno";
            cmsAlumno.Size = new Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(splitContainer1);
            Name = "FrmAlumnos";
            Text = "Alumnos";
            Activated += FrmAlumnos_Activated;
            Load += FrmAlumnos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            cmsAlumno.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvAlumnos;
        private Button btnAgregarAlumno;
        private TextBox txtAlumnos;
        private Label label1;
        private ContextMenuStrip cmsAlumno;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Button btnImportar;
    }
}