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
            this.btnActualizarEsp = new System.Windows.Forms.Button();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.btnLimpiarEsp = new System.Windows.Forms.Button();
            this.btnGuardarEsp = new System.Windows.Forms.Button();
            this.txtNombreEsp = new System.Windows.Forms.TextBox();
            this.lblNombreEsp = new System.Windows.Forms.Label();
            this.txtIdEsp = new System.Windows.Forms.TextBox();
            this.lblIdEsp = new System.Windows.Forms.Label();
            this.tabMedico = new System.Windows.Forms.TabPage();
            this.btnActualizarMed = new System.Windows.Forms.Button();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.btnLimpiarMed = new System.Windows.Forms.Button();
            this.btnGuardarMed = new System.Windows.Forms.Button();
            this.cmbEspecialidadMed = new System.Windows.Forms.ComboBox();
            this.lblEspecialidadMed = new System.Windows.Forms.Label();
            this.txtApellidoMed = new System.Windows.Forms.TextBox();
            this.lblApellidoMed = new System.Windows.Forms.Label();
            this.txtNombreMed = new System.Windows.Forms.TextBox();
            this.lblNombreMed = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.cmbEspecialidadConsulta = new System.Windows.Forms.ComboBox();
            this.lblSelEsp = new System.Windows.Forms.Label();
            this.tabMedicos.SuspendLayout();
            this.tabEspecialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.tabMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMedicos
            // 
            this.tabMedicos.Controls.Add(this.tabConsulta);
            this.tabMedicos.Controls.Add(this.tabEspecialidad);
            this.tabMedicos.Controls.Add(this.tabMedico);
            this.tabMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMedicos.Location = new System.Drawing.Point(0, 0);
            this.tabMedicos.Margin = new System.Windows.Forms.Padding(4);
            this.tabMedicos.Name = "tabMedicos";
            this.tabMedicos.SelectedIndex = 0;
            this.tabMedicos.Size = new System.Drawing.Size(783, 480);
            this.tabMedicos.TabIndex = 0;
            // 
            // tabEspecialidad
            // 
            this.tabEspecialidad.Controls.Add(this.btnActualizarEsp);
            this.tabEspecialidad.Controls.Add(this.dgvEspecialidades);
            this.tabEspecialidad.Controls.Add(this.btnLimpiarEsp);
            this.tabEspecialidad.Controls.Add(this.btnGuardarEsp);
            this.tabEspecialidad.Controls.Add(this.txtNombreEsp);
            this.tabEspecialidad.Controls.Add(this.lblNombreEsp);
            this.tabEspecialidad.Controls.Add(this.txtIdEsp);
            this.tabEspecialidad.Controls.Add(this.lblIdEsp);
            this.tabEspecialidad.Location = new System.Drawing.Point(4, 25);
            this.tabEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.tabEspecialidad.Name = "tabEspecialidad";
            this.tabEspecialidad.Padding = new System.Windows.Forms.Padding(4);
            this.tabEspecialidad.Size = new System.Drawing.Size(775, 451);
            this.tabEspecialidad.TabIndex = 0;
            this.tabEspecialidad.Text = "Especialidades";
            this.tabEspecialidad.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEsp
            // 
            this.btnActualizarEsp.Location = new System.Drawing.Point(10, 420);
            this.btnActualizarEsp.Name = "btnActualizarEsp";
            this.btnActualizarEsp.Size = new System.Drawing.Size(100, 25);
            this.btnActualizarEsp.TabIndex = 7;
            this.btnActualizarEsp.Text = "Actualizar Lista";
            this.btnActualizarEsp.UseVisualStyleBackColor = true;
            this.btnActualizarEsp.Click += new System.EventHandler(this.btnActualizarEsp_Click);
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Location = new System.Drawing.Point(10, 110);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.RowHeadersWidth = 51;
            this.dgvEspecialidades.Size = new System.Drawing.Size(760, 300);
            this.dgvEspecialidades.TabIndex = 6;
            // 
            // btnLimpiarEsp
            // 
            this.btnLimpiarEsp.Location = new System.Drawing.Point(120, 70);
            this.btnLimpiarEsp.Name = "btnLimpiarEsp";
            this.btnLimpiarEsp.Size = new System.Drawing.Size(100, 25);
            this.btnLimpiarEsp.TabIndex = 5;
            this.btnLimpiarEsp.Text = "Limpiar";
            this.btnLimpiarEsp.UseVisualStyleBackColor = true;
            this.btnLimpiarEsp.Click += new System.EventHandler(this.btnLimpiarEsp_Click);
            // 
            // btnGuardarEsp
            // 
            this.btnGuardarEsp.Location = new System.Drawing.Point(10, 70);
            this.btnGuardarEsp.Name = "btnGuardarEsp";
            this.btnGuardarEsp.Size = new System.Drawing.Size(100, 25);
            this.btnGuardarEsp.TabIndex = 4;
            this.btnGuardarEsp.Text = "Guardar";
            this.btnGuardarEsp.UseVisualStyleBackColor = true;
            this.btnGuardarEsp.Click += new System.EventHandler(this.btnGuardarEsp_Click);
            // 
            // txtNombreEsp
            // 
            this.txtNombreEsp.Location = new System.Drawing.Point(120, 40);
            this.txtNombreEsp.Name = "txtNombreEsp";
            this.txtNombreEsp.Size = new System.Drawing.Size(150, 22);
            this.txtNombreEsp.TabIndex = 3;
            // 
            // lblNombreEsp
            // 
            this.lblNombreEsp.AutoSize = true;
            this.lblNombreEsp.Location = new System.Drawing.Point(10, 40);
            this.lblNombreEsp.Name = "lblNombreEsp";
            this.lblNombreEsp.Size = new System.Drawing.Size(59, 16);
            this.lblNombreEsp.TabIndex = 2;
            this.lblNombreEsp.Text = "Nombre:";
            // 
            // txtIdEsp
            // 
            this.txtIdEsp.Location = new System.Drawing.Point(120, 10);
            this.txtIdEsp.Name = "txtIdEsp";
            this.txtIdEsp.Size = new System.Drawing.Size(150, 22);
            this.txtIdEsp.TabIndex = 1;
            // 
            // lblIdEsp
            // 
            this.lblIdEsp.AutoSize = true;
            this.lblIdEsp.Location = new System.Drawing.Point(10, 10);
            this.lblIdEsp.Name = "lblIdEsp";
            this.lblIdEsp.Size = new System.Drawing.Size(106, 16);
            this.lblIdEsp.TabIndex = 0;
            this.lblIdEsp.Text = "ID Especialidad:";
            // 
            // tabMedico
            // 
            this.tabMedico.Controls.Add(this.btnActualizarMed);
            this.tabMedico.Controls.Add(this.dgvMedicos);
            this.tabMedico.Controls.Add(this.btnLimpiarMed);
            this.tabMedico.Controls.Add(this.btnGuardarMed);
            this.tabMedico.Controls.Add(this.cmbEspecialidadMed);
            this.tabMedico.Controls.Add(this.lblEspecialidadMed);
            this.tabMedico.Controls.Add(this.txtApellidoMed);
            this.tabMedico.Controls.Add(this.lblApellidoMed);
            this.tabMedico.Controls.Add(this.txtNombreMed);
            this.tabMedico.Controls.Add(this.lblNombreMed);
            this.tabMedico.Controls.Add(this.txtMatricula);
            this.tabMedico.Controls.Add(this.lblMatricula);
            this.tabMedico.Location = new System.Drawing.Point(4, 25);
            this.tabMedico.Margin = new System.Windows.Forms.Padding(4);
            this.tabMedico.Name = "tabMedico";
            this.tabMedico.Padding = new System.Windows.Forms.Padding(4);
            this.tabMedico.Size = new System.Drawing.Size(775, 451);
            this.tabMedico.TabIndex = 1;
            this.tabMedico.Text = "Médicos";
            this.tabMedico.UseVisualStyleBackColor = true;
            // 
            // btnActualizarMed
            // 
            this.btnActualizarMed.Location = new System.Drawing.Point(10, 420);
            this.btnActualizarMed.Name = "btnActualizarMed";
            this.btnActualizarMed.Size = new System.Drawing.Size(100, 25);
            this.btnActualizarMed.TabIndex = 11;
            this.btnActualizarMed.Text = "Actualizar Lista";
            this.btnActualizarMed.UseVisualStyleBackColor = true;
            this.btnActualizarMed.Click += new System.EventHandler(this.btnActualizarMed_Click);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(10, 170);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.RowHeadersWidth = 51;
            this.dgvMedicos.Size = new System.Drawing.Size(760, 240);
            this.dgvMedicos.TabIndex = 10;
            // 
            // btnLimpiarMed
            // 
            this.btnLimpiarMed.Location = new System.Drawing.Point(120, 130);
            this.btnLimpiarMed.Name = "btnLimpiarMed";
            this.btnLimpiarMed.Size = new System.Drawing.Size(100, 25);
            this.btnLimpiarMed.TabIndex = 9;
            this.btnLimpiarMed.Text = "Limpiar";
            this.btnLimpiarMed.UseVisualStyleBackColor = true;
            this.btnLimpiarMed.Click += new System.EventHandler(this.btnLimpiarMed_Click);
            // 
            // btnGuardarMed
            // 
            this.btnGuardarMed.Location = new System.Drawing.Point(10, 130);
            this.btnGuardarMed.Name = "btnGuardarMed";
            this.btnGuardarMed.Size = new System.Drawing.Size(100, 25);
            this.btnGuardarMed.TabIndex = 8;
            this.btnGuardarMed.Text = "Guardar";
            this.btnGuardarMed.UseVisualStyleBackColor = true;
            this.btnGuardarMed.Click += new System.EventHandler(this.btnGuardarMed_Click);
            // 
            // cmbEspecialidadMed
            // 
            this.cmbEspecialidadMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadMed.FormattingEnabled = true;
            this.cmbEspecialidadMed.Location = new System.Drawing.Point(120, 100);
            this.cmbEspecialidadMed.Name = "cmbEspecialidadMed";
            this.cmbEspecialidadMed.Size = new System.Drawing.Size(150, 24);
            this.cmbEspecialidadMed.TabIndex = 7;
            // 
            // lblEspecialidadMed
            // 
            this.lblEspecialidadMed.AutoSize = true;
            this.lblEspecialidadMed.Location = new System.Drawing.Point(10, 100);
            this.lblEspecialidadMed.Name = "lblEspecialidadMed";
            this.lblEspecialidadMed.Size = new System.Drawing.Size(90, 16);
            this.lblEspecialidadMed.TabIndex = 6;
            this.lblEspecialidadMed.Text = "Especialidad:";
            // 
            // txtApellidoMed
            // 
            this.txtApellidoMed.Location = new System.Drawing.Point(120, 70);
            this.txtApellidoMed.Name = "txtApellidoMed";
            this.txtApellidoMed.Size = new System.Drawing.Size(150, 22);
            this.txtApellidoMed.TabIndex = 5;
            // 
            // lblApellidoMed
            // 
            this.lblApellidoMed.AutoSize = true;
            this.lblApellidoMed.Location = new System.Drawing.Point(10, 70);
            this.lblApellidoMed.Name = "lblApellidoMed";
            this.lblApellidoMed.Size = new System.Drawing.Size(60, 16);
            this.lblApellidoMed.TabIndex = 4;
            this.lblApellidoMed.Text = "Apellido:";
            // 
            // txtNombreMed
            // 
            this.txtNombreMed.Location = new System.Drawing.Point(120, 40);
            this.txtNombreMed.Name = "txtNombreMed";
            this.txtNombreMed.Size = new System.Drawing.Size(150, 22);
            this.txtNombreMed.TabIndex = 3;
            // 
            // lblNombreMed
            // 
            this.lblNombreMed.AutoSize = true;
            this.lblNombreMed.Location = new System.Drawing.Point(10, 40);
            this.lblNombreMed.Name = "lblNombreMed";
            this.lblNombreMed.Size = new System.Drawing.Size(59, 16);
            this.lblNombreMed.TabIndex = 2;
            this.lblNombreMed.Text = "Nombre:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(120, 10);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(150, 22);
            this.txtMatricula.TabIndex = 1;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(10, 10);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(64, 16);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.dgvConsulta);
            this.tabConsulta.Controls.Add(this.cmbEspecialidadConsulta);
            this.tabConsulta.Controls.Add(this.lblSelEsp);
            this.tabConsulta.Location = new System.Drawing.Point(4, 25);
            this.tabConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(4);
            this.tabConsulta.Size = new System.Drawing.Size(775, 451);
            this.tabConsulta.TabIndex = 2;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(10, 50);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.Size = new System.Drawing.Size(760, 360);
            this.dgvConsulta.TabIndex = 2;
            // 
            // cmbEspecialidadConsulta
            // 
            this.cmbEspecialidadConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadConsulta.FormattingEnabled = true;
            this.cmbEspecialidadConsulta.Location = new System.Drawing.Point(177, 7);
            this.cmbEspecialidadConsulta.Name = "cmbEspecialidadConsulta";
            this.cmbEspecialidadConsulta.Size = new System.Drawing.Size(200, 24);
            this.cmbEspecialidadConsulta.TabIndex = 1;
            this.cmbEspecialidadConsulta.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidadConsulta_SelectedIndexChanged);
            // 
            // lblSelEsp
            // 
            this.lblSelEsp.AutoSize = true;
            this.lblSelEsp.Location = new System.Drawing.Point(10, 10);
            this.lblSelEsp.Name = "lblSelEsp";
            this.lblSelEsp.Size = new System.Drawing.Size(161, 16);
            this.lblSelEsp.TabIndex = 0;
            this.lblSelEsp.Text = "Seleccione Especialidad:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 480);
            this.Controls.Add(this.tabMedicos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Médicos y Especialidades";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabMedicos.ResumeLayout(false);
            this.tabEspecialidad.ResumeLayout(false);
            this.tabEspecialidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.tabMedico.ResumeLayout(false);
            this.tabMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMedicos;
        private System.Windows.Forms.TabPage tabEspecialidad;
        private System.Windows.Forms.TabPage tabMedico;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.Label lblIdEsp;
        private System.Windows.Forms.TextBox txtIdEsp;
        private System.Windows.Forms.Label lblNombreEsp;
        private System.Windows.Forms.TextBox txtNombreEsp;
        private System.Windows.Forms.Button btnGuardarEsp;
        private System.Windows.Forms.Button btnLimpiarEsp;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnActualizarEsp;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblNombreMed;
        private System.Windows.Forms.TextBox txtNombreMed;
        private System.Windows.Forms.Label lblApellidoMed;
        private System.Windows.Forms.TextBox txtApellidoMed;
        private System.Windows.Forms.Label lblEspecialidadMed;
        private System.Windows.Forms.ComboBox cmbEspecialidadMed;
        private System.Windows.Forms.Button btnGuardarMed;
        private System.Windows.Forms.Button btnLimpiarMed;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Button btnActualizarMed;
        private System.Windows.Forms.Label lblSelEsp;
        private System.Windows.Forms.ComboBox cmbEspecialidadConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
    }
}

