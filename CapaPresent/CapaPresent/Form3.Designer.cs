namespace CapaPresent
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.btnCambiarcolor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresar.Location = new System.Drawing.Point(12, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(91, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Volver al inicio";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "";
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 56);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Lisbeth María Morales Eusebio \r\n  2020-10658";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCambiarcolor
            // 
            this.btnCambiarcolor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarcolor.Location = new System.Drawing.Point(136, 147);
            this.btnCambiarcolor.Name = "btnCambiarcolor";
            this.btnCambiarcolor.Size = new System.Drawing.Size(97, 33);
            this.btnCambiarcolor.TabIndex = 4;
            this.btnCambiarcolor.Text = "Cambiar color";
            this.btnCambiarcolor.UseVisualStyleBackColor = false;
            this.btnCambiarcolor.Click += new System.EventHandler(this.btnCambiarcolor_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 210);
            this.Controls.Add(this.btnCambiarcolor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRegresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Paint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button btnCambiarcolor;
    }
}