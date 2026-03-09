namespace WinMySQL.Vistas
{
    partial class FrmProfesores
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
            btnAgregarProfesor = new Button();
            txtMaterias = new TextBox();
            label1 = new Label();
            dgvProfesores = new DataGridView();
            cmsProfesor = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).BeginInit();
            cmsProfesor.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(btnAgregarProfesor);
            splitContainer1.Panel1.Controls.Add(txtMaterias);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvProfesores);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 94;
            splitContainer1.TabIndex = 0;
            // 
            // btnAgregarProfesor
            // 
            btnAgregarProfesor.Location = new Point(713, 34);
            btnAgregarProfesor.Name = "btnAgregarProfesor";
            btnAgregarProfesor.Size = new Size(75, 23);
            btnAgregarProfesor.TabIndex = 8;
            btnAgregarProfesor.Text = "Agregar";
            btnAgregarProfesor.UseVisualStyleBackColor = true;
            btnAgregarProfesor.Click += btnAgregarProfesor_Click;
            // 
            // txtMaterias
            // 
            txtMaterias.Location = new Point(12, 34);
            txtMaterias.Name = "txtMaterias";
            txtMaterias.Size = new Size(531, 23);
            txtMaterias.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Buscar";
            // 
            // dgvProfesores
            // 
            dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesores.Dock = DockStyle.Fill;
            dgvProfesores.Location = new Point(0, 0);
            dgvProfesores.Name = "dgvProfesores";
            dgvProfesores.Size = new Size(800, 352);
            dgvProfesores.TabIndex = 0;
            dgvProfesores.CellContentDoubleClick += dgvProfesores_CellContentDoubleClick;
            // 
            // cmsProfesor
            // 
            cmsProfesor.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cmsProfesor.Name = "contextMenuStrip1";
            cmsProfesor.Size = new Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // FrmProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = cmsProfesor;
            Controls.Add(splitContainer1);
            Name = "FrmProfesores";
            Text = "FrmProfesores";
            Activated += FrmProfesores_Activated;
            Load += FrmProfesores_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).EndInit();
            cmsProfesor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvProfesores;
        private Button btnAgregarProfesor;
        private TextBox txtMaterias;
        private Label label1;
        private ContextMenuStrip cmsProfesor;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}