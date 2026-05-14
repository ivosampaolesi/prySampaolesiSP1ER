using prySampaolesiClaseBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace prySampaolesiSP1
{
    public class GestorDatos
    {
        private clsConexion conexion;
        private List<Especialidad> especialidades;
        private List<ClaseMedico> medicos;

        public GestorDatos()
        {
            string rutaBD = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BD", "ClinicaBD.accdb"); 
            conexion = new clsConexion(rutaBD);
            especialidades = new List<Especialidad>();
            medicos = new List<ClaseMedico>();

            if (conexion.Conectar())
            {
                CargarDatosDelBD();
            }
        }

        private void CargarDatosDelBD()
        {
            // Cargar especialidades
            DataTable dtEsp = conexion.ObtenerDatos("Especialidades");
            if (dtEsp != null)
            {
                foreach (DataRow row in dtEsp.Rows)
                {
                    especialidades.Add(new Especialidad(
                        (int)row["ID"],
                        row["Nombre"].ToString()
                    ));
                }
            }

            // Cargar médicos
            DataTable dtMed = conexion.ObtenerDatos("Medicos");
            if (dtMed != null)
            {
                foreach (DataRow row in dtMed.Rows)
                {
                    medicos.Add(new ClaseMedico(
                        (int)row["Matricula"],
                        row["Nombre"].ToString(),
                        row["Apellido"].ToString(),
                        (int)row["Especialidad"]
                    ));
                }
            }
        }

        // Métodos para Especialidades
        public bool AgregarEspecialidad(int idEspecialidad, string nombre)
        {
            if (especialidades.Any(e => e.IdEspecialidad == idEspecialidad))
                return false;

            string comando = $"INSERT INTO Especialidades (ID, Nombre) VALUES ({idEspecialidad}, '{nombre.Replace("'", "''")}')";
            if (conexion.EjecutarComando(comando))
            {
                especialidades.Add(new Especialidad(idEspecialidad, nombre));
                return true;
            }
            return false;
        }

        public List<Especialidad> ObtenerEspecialidades()
        {
            return new List<Especialidad>(especialidades);
        }

        public bool ExisteEspecialidad(int idEspecialidad)
        {
            return especialidades.Any(e => e.IdEspecialidad == idEspecialidad);
        }

        // Métodos para Médicos
        public bool AgregarMedico(int matricula, string nombre, string apellido, int idEspecialidad)
        {
            if (medicos.Any(m => m.Matricula == matricula))
                return false;

            string comando = $"INSERT INTO Medicos (Matricula, Nombre, Apellido, Especialidad) VALUES ({matricula}, '{nombre.Replace("'", "''")}', '{apellido.Replace("'", "''")}', {idEspecialidad})";
            if (conexion.EjecutarComando(comando))
            {
                medicos.Add(new ClaseMedico(matricula, nombre, apellido, idEspecialidad));
                return true;
            }
            return false;
        }

        public List<ClaseMedico> ObtenerMedicosPorEspecialidad(int idEspecialidad)
        {
            return medicos.Where(m => m.IdEspecialidad == idEspecialidad).ToList();
        }

        public List<ClaseMedico> ObtenerTodosMedicos()
        {
            return new List<ClaseMedico>(medicos);
        }

        public bool ExisteMedico(int matricula)
        {
            return medicos.Any(m => m.Matricula == matricula);
        }

        public void Desconectar()
        {
            if (conexion != null)
            {
                conexion.Desconectar();
            }
        }
    }
}
