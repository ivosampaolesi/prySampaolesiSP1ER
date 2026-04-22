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

        public frmPrincipal()
        {
            InitializeComponent();
            gestor = new GestorDatos();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridViews();
            ActualizarComboBoxEspecialidades(cmbEspecialidadMed);
            ActualizarComboBoxEspecialidades(cmbEspecialidadConsulta);
            CargarEspecialidades(dgvEspecialidades);
            CargarMedicos(dgvMedicos);
        }

        private void ConfigurarDataGridViews()
        {
            // Configurar dgvEspecialidades
            dgvEspecialidades.Columns.Clear();
            dgvEspecialidades.Columns.Add("IdEspecialidad", "ID");
            dgvEspecialidades.Columns.Add("Nombre", "Nombre");

            // Configurar dgvMedicos
            dgvMedicos.Columns.Clear();
            dgvMedicos.Columns.Add("Matricula", "Matrícula");
            dgvMedicos.Columns.Add("Nombre", "Nombre");
            dgvMedicos.Columns.Add("Apellido", "Apellido");
            dgvMedicos.Columns.Add("IdEspecialidad", "ID Especialidad");

            // Configurar dgvConsulta
            dgvConsulta.Columns.Clear();
            dgvConsulta.Columns.Add("Matricula", "Matrícula");
            dgvConsulta.Columns.Add("Nombre", "Nombre");
            dgvConsulta.Columns.Add("Apellido", "Apellido");
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
                CargarEspecialidades(dgvEspecialidades);

                // Actualizar ComboBox de Médicos y Consulta
                ActualizarComboBoxEspecialidades(cmbEspecialidadMed);
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

        private void btnGuardarEsp_Click(object sender, EventArgs e)
        {
            GuardarEspecialidad(txtIdEsp, txtNombreEsp);
        }

        private void btnLimpiarEsp_Click(object sender, EventArgs e)
        {
            txtIdEsp.Clear();
            txtNombreEsp.Clear();
            txtIdEsp.Focus();
        }

        private void btnActualizarEsp_Click(object sender, EventArgs e)
        {
            CargarEspecialidades(dgvEspecialidades);
        }

        private void btnGuardarMed_Click(object sender, EventArgs e)
        {
            GuardarMedico(txtMatricula, txtNombreMed, txtApellidoMed, cmbEspecialidadMed);
        }

        private void btnLimpiarMed_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
            txtNombreMed.Clear();
            txtApellidoMed.Clear();
            cmbEspecialidadMed.SelectedIndex = -1;
            txtMatricula.Focus();
        }

        private void btnActualizarMed_Click(object sender, EventArgs e)
        {
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
                CargarMedicos(dgvMedicos);
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

        private void cmbEspecialidadConsulta_SelectedIndexChanged(object sender, EventArgs e)
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
