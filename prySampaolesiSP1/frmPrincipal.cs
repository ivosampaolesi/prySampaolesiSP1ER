using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySampaolesiSP1
{
    public partial class frmPrincipal : Form
    {
        private GestorDatos gestor;
        private ComboBox cmbEspecialidadMed;
        private ComboBox cmbEspecialidadConsulta;

        public frmPrincipal()
        {
            InitializeComponent();
            gestor = new GestorDatos();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            InicializarTab();
        }

        private void InicializarTab()
        {
            // Limpiar controles de tabs
            tabEspecialidad.Controls.Clear();
            tabMedico.Controls.Clear();
            tabConsulta.Controls.Clear();

            // Crear Tab Especialidad
            CrearTabEspecialidad();

            // Crear Tab Médico
            CrearTabMedico();

            // Crear Tab Consulta
            CrearTabConsulta();
        }

        private void CrearTabEspecialidad()
        {
            // Labels y TextBoxes
            Label lblIdEsp = new Label() { Text = "ID Especialidad:", Location = new Point(10, 10), AutoSize = true };
            TextBox txtIdEsp = new TextBox() { Location = new Point(120, 10), Width = 150, Name = "txtIdEsp" };

            Label lblNombreEsp = new Label() { Text = "Nombre:", Location = new Point(10, 40), AutoSize = true };
            TextBox txtNombreEsp = new TextBox() { Location = new Point(120, 40), Width = 150, Name = "txtNombreEsp" };

            // Botones
            Button btnGuardarEsp = new Button() { Text = "Guardar", Location = new Point(10, 70), Width = 100 };
            btnGuardarEsp.Click += (s, e) => GuardarEspecialidad(txtIdEsp, txtNombreEsp);

            Button btnLimpiarEsp = new Button() { Text = "Limpiar", Location = new Point(120, 70), Width = 100 };
            btnLimpiarEsp.Click += (s, e) =>
            {
                txtIdEsp.Clear();
                txtNombreEsp.Clear();
                txtIdEsp.Focus();
            };

            // DataGridView
            DataGridView dgvEspecialidades = new DataGridView()
            {
                Location = new Point(10, 110),
                Width = 760,
                Height = 300,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                Name = "dgvEspecialidades"
            };

            dgvEspecialidades.Columns.Add("IdEspecialidad", "ID");
            dgvEspecialidades.Columns.Add("Nombre", "Nombre");

            Button btnActualizarEsp = new Button() { Text = "Actualizar Lista", Location = new Point(10, 420) };
            btnActualizarEsp.Click += (s, e) => CargarEspecialidades(dgvEspecialidades);

            tabEspecialidad.Controls.Add(lblIdEsp);
            tabEspecialidad.Controls.Add(txtIdEsp);
            tabEspecialidad.Controls.Add(lblNombreEsp);
            tabEspecialidad.Controls.Add(txtNombreEsp);
            tabEspecialidad.Controls.Add(btnGuardarEsp);
            tabEspecialidad.Controls.Add(btnLimpiarEsp);
            tabEspecialidad.Controls.Add(dgvEspecialidades);
            tabEspecialidad.Controls.Add(btnActualizarEsp);

            CargarEspecialidades(dgvEspecialidades);
        }

        private void GuardarEspecialidad(TextBox txtId, TextBox txtNombre)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtId.Text, out int idEsp))
            {
                MessageBox.Show("El ID debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gestor.ExisteEspecialidad(idEsp))
            {
                MessageBox.Show("El ID de especialidad ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gestor.AgregarEspecialidad(idEsp, txtNombre.Text))
            {
                MessageBox.Show("Especialidad registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Clear();
                txtNombre.Clear();
                txtId.Focus();

                // Actualizar DataGridView
                DataGridView dgv = tabEspecialidad.Controls["dgvEspecialidades"] as DataGridView;
                if (dgv != null)
                    CargarEspecialidades(dgv);

                // Actualizar ComboBox de Médicos y Consulta
                if (cmbEspecialidadMed != null)
                    ActualizarComboBoxEspecialidades(cmbEspecialidadMed);
                if (cmbEspecialidadConsulta != null)
                    ActualizarComboBoxEspecialidades(cmbEspecialidadConsulta);
            }
            else
            {
                MessageBox.Show("Error al registrar la especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEspecialidades(DataGridView dgv)
        {
            dgv.Rows.Clear();
            List<Especialidad> especialidades = gestor.ObtenerEspecialidades();
            foreach (var esp in especialidades)
            {
                dgv.Rows.Add(esp.IdEspecialidad, esp.Nombre);
            }
        }

        private void CrearTabMedico()
        {
            // Labels y TextBoxes
            Label lblMatricula = new Label() { Text = "Matrícula:", Location = new Point(10, 10), AutoSize = true };
            TextBox txtMatricula = new TextBox() { Location = new Point(120, 10), Width = 150, Name = "txtMatricula" };

            Label lblNombreMed = new Label() { Text = "Nombre:", Location = new Point(10, 40), AutoSize = true };
            TextBox txtNombreMed = new TextBox() { Location = new Point(120, 40), Width = 150, Name = "txtNombreMed" };

            Label lblApellidoMed = new Label() { Text = "Apellido:", Location = new Point(10, 70), AutoSize = true };
            TextBox txtApellidoMed = new TextBox() { Location = new Point(120, 70), Width = 150, Name = "txtApellidoMed" };

            Label lblEspecialidadMed = new Label() { Text = "Especialidad:", Location = new Point(10, 100), AutoSize = true };
            cmbEspecialidadMed = new ComboBox() { Location = new Point(120, 100), Width = 150, DropDownStyle = ComboBoxStyle.DropDownList, Name = "cmbEspecialidadMed" };
            ActualizarComboBoxEspecialidades(cmbEspecialidadMed);

            // Botones
            Button btnGuardarMed = new Button() { Text = "Guardar", Location = new Point(10, 130), Width = 100 };
            btnGuardarMed.Click += (s, e) => GuardarMedico(txtMatricula, txtNombreMed, txtApellidoMed, cmbEspecialidadMed);

            Button btnLimpiarMed = new Button() { Text = "Limpiar", Location = new Point(120, 130), Width = 100 };
            btnLimpiarMed.Click += (s, e) =>
            {
                txtMatricula.Clear();
                txtNombreMed.Clear();
                txtApellidoMed.Clear();
                cmbEspecialidadMed.SelectedIndex = -1;
                txtMatricula.Focus();
            };

            // DataGridView
            DataGridView dgvMedicos = new DataGridView()
            {
                Location = new Point(10, 170),
                Width = 760,
                Height = 240,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                Name = "dgvMedicos"
            };

            dgvMedicos.Columns.Add("Matricula", "Matrícula");
            dgvMedicos.Columns.Add("Nombre", "Nombre");
            dgvMedicos.Columns.Add("Apellido", "Apellido");
            dgvMedicos.Columns.Add("IdEspecialidad", "ID Especialidad");

            Button btnActualizarMed = new Button() { Text = "Actualizar Lista", Location = new Point(10, 420) };
            btnActualizarMed.Click += (s, e) => CargarMedicos(dgvMedicos);

            tabMedico.Controls.Add(lblMatricula);
            tabMedico.Controls.Add(txtMatricula);
            tabMedico.Controls.Add(lblNombreMed);
            tabMedico.Controls.Add(txtNombreMed);
            tabMedico.Controls.Add(lblApellidoMed);
            tabMedico.Controls.Add(txtApellidoMed);
            tabMedico.Controls.Add(lblEspecialidadMed);
            tabMedico.Controls.Add(cmbEspecialidadMed);
            tabMedico.Controls.Add(btnGuardarMed);
            tabMedico.Controls.Add(btnLimpiarMed);
            tabMedico.Controls.Add(dgvMedicos);
            tabMedico.Controls.Add(btnActualizarMed);

            CargarMedicos(dgvMedicos);
        }

        private void GuardarMedico(TextBox txtMatricula, TextBox txtNombre, TextBox txtApellido, ComboBox cmbEspecialidad)
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMatricula.Text, out int matricula))
            {
                MessageBox.Show("La matrícula debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gestor.ExisteMedico(matricula))
            {
                MessageBox.Show("La matrícula ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Especialidad espSeleccionada = cmbEspecialidad.SelectedItem as Especialidad;
            if (espSeleccionada == null)
            {
                MessageBox.Show("Error al obtener la especialidad seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gestor.AgregarMedico(matricula, txtNombre.Text, txtApellido.Text, espSeleccionada.IdEspecialidad))
            {
                MessageBox.Show("Médico registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatricula.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                cmbEspecialidad.SelectedIndex = -1;
                txtMatricula.Focus();

                // Actualizar DataGridView
                DataGridView dgv = tabMedico.Controls["dgvMedicos"] as DataGridView;
                if (dgv != null)
                    CargarMedicos(dgv);
            }
            else
            {
                MessageBox.Show("Error al registrar el médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMedicos(DataGridView dgv)
        {
            dgv.Rows.Clear();
            List<ClaseMedico> medicos = gestor.ObtenerTodosMedicos();
            foreach (var med in medicos)
            {
                dgv.Rows.Add(med.Matricula, med.Nombre, med.Apellido, med.IdEspecialidad);
            }
        }

        private void CrearTabConsulta()
        {
            // Label y ComboBox
            Label lblSelEsp = new Label() { Text = "Seleccione Especialidad:", Location = new Point(10, 10), AutoSize = true };
            cmbEspecialidadConsulta = new ComboBox()
            {
                Location = new Point(150, 10),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Name = "cmbEspecialidadConsulta"
            };
            ActualizarComboBoxEspecialidades(cmbEspecialidadConsulta);

            // DataGridView
            DataGridView dgvConsulta = new DataGridView()
            {
                Location = new Point(10, 50),
                Width = 760,
                Height = 360,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                Name = "dgvConsulta"
            };

            dgvConsulta.Columns.Add("Matricula", "Matrícula");
            dgvConsulta.Columns.Add("Nombre", "Nombre");
            dgvConsulta.Columns.Add("Apellido", "Apellido");

            cmbEspecialidadConsulta.SelectedIndexChanged += (s, e) =>
            {
                if (cmbEspecialidadConsulta.SelectedIndex != -1)
                {
                    Especialidad espSeleccionada = cmbEspecialidadConsulta.SelectedItem as Especialidad;
                    if (espSeleccionada != null)
                    {
                        CargarMedicosPorEspecialidad(dgvConsulta, espSeleccionada.IdEspecialidad);
                    }
                }
                else
                {
                    dgvConsulta.Rows.Clear();
                }
            };

            tabConsulta.Controls.Add(lblSelEsp);
            tabConsulta.Controls.Add(cmbEspecialidadConsulta);
            tabConsulta.Controls.Add(dgvConsulta);
        }

        private void CargarMedicosPorEspecialidad(DataGridView dgv, int idEspecialidad)
        {
            dgv.Rows.Clear();
            List<ClaseMedico> medicos = gestor.ObtenerMedicosPorEspecialidad(idEspecialidad);
            foreach (var med in medicos)
            {
                dgv.Rows.Add(med.Matricula, med.Nombre, med.Apellido);
            }
        }

        private void ActualizarComboBoxEspecialidades(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.DataSource = gestor.ObtenerEspecialidades();
            cmb.DisplayMember = "Nombre";
            cmb.ValueMember = "IdEspecialidad";
        }
    }
}
