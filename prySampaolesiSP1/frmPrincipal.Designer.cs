namespace prySampaolesiSP1
{
    partial class frmPrincipal
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
            this.tabMedicos = new System.Windows.Forms.TabControl();
            this.tabEspecialidad = new System.Windows.Forms.TabPage();
            this.tabMedico = new System.Windows.Forms.TabPage();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.tabMedicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMedicos
            // 
            this.tabMedicos.Controls.Add(this.tabEspecialidad);
            this.tabMedicos.Controls.Add(this.tabMedico);
            this.tabMedicos.Controls.Add(this.tabConsulta);
            this.tabMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMedicos.Location = new System.Drawing.Point(0, 0);
            this.tabMedicos.Name = "tabMedicos";
            this.tabMedicos.SelectedIndex = 0;
            this.tabMedicos.Size = new System.Drawing.Size(800, 450);
            this.tabMedicos.TabIndex = 0;
            // 
            // tabEspecialidad
            // 
            this.tabEspecialidad.Location = new System.Drawing.Point(4, 22);
            this.tabEspecialidad.Name = "tabEspecialidad";
            this.tabEspecialidad.Padding = new System.Windows.Forms.Padding(3);
            this.tabEspecialidad.Size = new System.Drawing.Size(792, 424);
            this.tabEspecialidad.TabIndex = 0;
            this.tabEspecialidad.Text = "Especialidades";
            this.tabEspecialidad.UseVisualStyleBackColor = true;
            // 
            // tabMedico
            // 
            this.tabMedico.Location = new System.Drawing.Point(4, 22);
            this.tabMedico.Name = "tabMedico";
            this.tabMedico.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedico.Size = new System.Drawing.Size(792, 424);
            this.tabMedico.TabIndex = 1;
            this.tabMedico.Text = "Médicos";
            this.tabMedico.UseVisualStyleBackColor = true;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(792, 424);
            this.tabConsulta.TabIndex = 2;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMedicos);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Médicos y Especialidades";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabMedicos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMedicos;
        private System.Windows.Forms.TabPage tabEspecialidad;
        private System.Windows.Forms.TabPage tabMedico;
        private System.Windows.Forms.TabPage tabConsulta;
    }
}

