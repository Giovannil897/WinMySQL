namespace WinMySQL
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            alumnoToolStripMenuItem = new ToolStripMenuItem();
            catalogoToolStripMenuItem = new ToolStripMenuItem();
            alumnoToolStripMenuItem1 = new ToolStripMenuItem();
            materiaToolStripMenuItem = new ToolStripMenuItem();
            profesorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { alumnoToolStripMenuItem, catalogoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // alumnoToolStripMenuItem
            // 
            alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            alumnoToolStripMenuItem.Size = new Size(60, 20);
            alumnoToolStripMenuItem.Text = "Archivo";
            // 
            // catalogoToolStripMenuItem
            // 
            catalogoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alumnoToolStripMenuItem1, materiaToolStripMenuItem, profesorToolStripMenuItem });
            catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            catalogoToolStripMenuItem.Size = new Size(67, 20);
            catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // alumnoToolStripMenuItem1
            // 
            alumnoToolStripMenuItem1.Name = "alumnoToolStripMenuItem1";
            alumnoToolStripMenuItem1.Size = new Size(180, 22);
            alumnoToolStripMenuItem1.Text = "Alumno";
            // 
            // materiaToolStripMenuItem
            // 
            materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            materiaToolStripMenuItem.Size = new Size(180, 22);
            materiaToolStripMenuItem.Text = "Materia";
            materiaToolStripMenuItem.Click += materiaToolStripMenuItem_Click;
            // 
            // profesorToolStripMenuItem
            // 
            profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            profesorToolStripMenuItem.Size = new Size(180, 22);
            profesorToolStripMenuItem.Text = "Profesor";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Sistema Escolar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem alumnoToolStripMenuItem;
        private ToolStripMenuItem catalogoToolStripMenuItem;
        private ToolStripMenuItem alumnoToolStripMenuItem1;
        private ToolStripMenuItem materiaToolStripMenuItem;
        private ToolStripMenuItem profesorToolStripMenuItem;
    }
}
