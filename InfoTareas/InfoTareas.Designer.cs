namespace InfoTareas
{
    partial class InfoTareas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoTareas));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreNosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(60)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InfoTareas.Properties.Resources.lista_de_tareas;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.tareasToolStripMenuItem,
            this.creditosToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTareaToolStripMenuItem,
            this.agregarTareasToolStripMenuItem,
            this.buscarTareasToolStripMenuItem,
            this.eliminarTareasToolStripMenuItem});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            resources.ApplyResources(this.tareasToolStripMenuItem, "tareasToolStripMenuItem");
            // 
            // agregarTareaToolStripMenuItem
            // 
            this.agregarTareaToolStripMenuItem.Name = "agregarTareaToolStripMenuItem";
            resources.ApplyResources(this.agregarTareaToolStripMenuItem, "agregarTareaToolStripMenuItem");
            // 
            // agregarTareasToolStripMenuItem
            // 
            this.agregarTareasToolStripMenuItem.Name = "agregarTareasToolStripMenuItem";
            resources.ApplyResources(this.agregarTareasToolStripMenuItem, "agregarTareasToolStripMenuItem");
            // 
            // buscarTareasToolStripMenuItem
            // 
            this.buscarTareasToolStripMenuItem.Name = "buscarTareasToolStripMenuItem";
            resources.ApplyResources(this.buscarTareasToolStripMenuItem, "buscarTareasToolStripMenuItem");
            // 
            // eliminarTareasToolStripMenuItem
            // 
            this.eliminarTareasToolStripMenuItem.Name = "eliminarTareasToolStripMenuItem";
            resources.ApplyResources(this.eliminarTareasToolStripMenuItem, "eliminarTareasToolStripMenuItem");
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreNosotrosToolStripMenuItem,
            this.versiónToolStripMenuItem});
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            resources.ApplyResources(this.creditosToolStripMenuItem, "creditosToolStripMenuItem");
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            resources.ApplyResources(this.salirToolStripMenuItem1, "salirToolStripMenuItem1");
            // 
            // sobreNosotrosToolStripMenuItem
            // 
            this.sobreNosotrosToolStripMenuItem.Name = "sobreNosotrosToolStripMenuItem";
            resources.ApplyResources(this.sobreNosotrosToolStripMenuItem, "sobreNosotrosToolStripMenuItem");
            // 
            // versiónToolStripMenuItem
            // 
            this.versiónToolStripMenuItem.Name = "versiónToolStripMenuItem";
            resources.ApplyResources(this.versiónToolStripMenuItem, "versiónToolStripMenuItem");
            // 
            // InfoTareas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InfoTareas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreNosotrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versiónToolStripMenuItem;
    }
}

