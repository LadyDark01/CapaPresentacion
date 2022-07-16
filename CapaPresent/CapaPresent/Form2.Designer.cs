namespace CapaPresent
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Atras = new System.Windows.Forms.ToolStripMenuItem();
            this.Adelante = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.Pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Seleccionartodo = new System.Windows.Forms.ToolStripMenuItem();
            this.Eliminartodo = new System.Windows.Forms.ToolStripMenuItem();
            this.Formato = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnVolver = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.editarToolStripMenuItem,
            this.Formato});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Abrir,
            this.Guardar,
            this.Cerrar});
            this.Archivo.Image = ((System.Drawing.Image)(resources.GetObject("Archivo.Image")));
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(76, 20);
            this.Archivo.Text = "Archivo";
            // 
            // Abrir
            // 
            this.Abrir.Image = ((System.Drawing.Image)(resources.GetObject("Abrir.Image")));
            this.Abrir.Name = "Abrir";
            this.Abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Abrir.Size = new System.Drawing.Size(180, 22);
            this.Abrir.Text = "Abrir";
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Guardar
            // 
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.Name = "Guardar";
            this.Guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Guardar.Size = new System.Drawing.Size(180, 22);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.Cerrar.Size = new System.Drawing.Size(180, 22);
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Atras,
            this.Adelante,
            this.toolStripSeparator1,
            this.Copiar,
            this.Cortar,
            this.Pegar,
            this.toolStripSeparator2,
            this.Seleccionartodo,
            this.Eliminartodo});
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.editarToolStripMenuItem.Text = "Edición";
            // 
            // Atras
            // 
            this.Atras.Image = ((System.Drawing.Image)(resources.GetObject("Atras.Image")));
            this.Atras.Name = "Atras";
            this.Atras.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Atras.Size = new System.Drawing.Size(209, 22);
            this.Atras.Text = "Atrás";
            this.Atras.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // Adelante
            // 
            this.Adelante.Image = ((System.Drawing.Image)(resources.GetObject("Adelante.Image")));
            this.Adelante.Name = "Adelante";
            this.Adelante.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.Adelante.Size = new System.Drawing.Size(209, 22);
            this.Adelante.Text = "Adelante";
            this.Adelante.Click += new System.EventHandler(this.Adelante_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // Copiar
            // 
            this.Copiar.Image = ((System.Drawing.Image)(resources.GetObject("Copiar.Image")));
            this.Copiar.Name = "Copiar";
            this.Copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copiar.Size = new System.Drawing.Size(209, 22);
            this.Copiar.Text = "Copiar";
            this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // Cortar
            // 
            this.Cortar.Image = ((System.Drawing.Image)(resources.GetObject("Cortar.Image")));
            this.Cortar.Name = "Cortar";
            this.Cortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cortar.Size = new System.Drawing.Size(209, 22);
            this.Cortar.Text = "Cortar";
            this.Cortar.Click += new System.EventHandler(this.Cortar_Click);
            // 
            // Pegar
            // 
            this.Pegar.Image = ((System.Drawing.Image)(resources.GetObject("Pegar.Image")));
            this.Pegar.Name = "Pegar";
            this.Pegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Pegar.Size = new System.Drawing.Size(209, 22);
            this.Pegar.Text = "Pegar";
            this.Pegar.Click += new System.EventHandler(this.Pegar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // Seleccionartodo
            // 
            this.Seleccionartodo.Image = ((System.Drawing.Image)(resources.GetObject("Seleccionartodo.Image")));
            this.Seleccionartodo.Name = "Seleccionartodo";
            this.Seleccionartodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Seleccionartodo.Size = new System.Drawing.Size(209, 22);
            this.Seleccionartodo.Text = "Seleccionar todo";
            this.Seleccionartodo.Click += new System.EventHandler(this.Seleccionartodo_Click);
            // 
            // Eliminartodo
            // 
            this.Eliminartodo.Image = ((System.Drawing.Image)(resources.GetObject("Eliminartodo.Image")));
            this.Eliminartodo.Name = "Eliminartodo";
            this.Eliminartodo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.Eliminartodo.Size = new System.Drawing.Size(209, 22);
            this.Eliminartodo.Text = "Eliminar todo";
            this.Eliminartodo.Click += new System.EventHandler(this.Eliminartodo_Click);
            // 
            // Formato
            // 
            this.Formato.Image = ((System.Drawing.Image)(resources.GetObject("Formato.Image")));
            this.Formato.Name = "Formato";
            this.Formato.Size = new System.Drawing.Size(80, 20);
            this.Formato.Text = "Formato";
            this.Formato.Click += new System.EventHandler(this.Formato_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(503, 278);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Info;
            this.btnVolver.Location = new System.Drawing.Point(408, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver al inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 319);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Editor de Texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem Abrir;
        private System.Windows.Forms.ToolStripMenuItem Guardar;
        private System.Windows.Forms.ToolStripMenuItem Cerrar;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Atras;
        private System.Windows.Forms.ToolStripMenuItem Adelante;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Copiar;
        private System.Windows.Forms.ToolStripMenuItem Cortar;
        private System.Windows.Forms.ToolStripMenuItem Pegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Seleccionartodo;
        private System.Windows.Forms.ToolStripMenuItem Eliminartodo;
        private System.Windows.Forms.ToolStripMenuItem Formato;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnVolver;
    }
}