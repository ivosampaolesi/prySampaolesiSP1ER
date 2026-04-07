using System.Collections.Generic;
using System.Linq;

namespace prySampaolesiSP1
{
    public class GestorDatos
    {
        private List<Especialidad> especialidades;
        private List<ClaseMedico> medicos;

        public GestorDatos()
        {
            especialidades = new List<Especialidad>();
            medicos = new List<ClaseMedico>();
        }

        // Métodos para Especialidades
        public bool AgregarEspecialidad(int idEspecialidad, string nombre)
        {
            if (especialidades.Any(e => e.IdEspecialidad == idEspecialidad))
                return false;

            especialidades.Add(new Especialidad(idEspecialidad, nombre));
            return true;
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

            medicos.Add(new ClaseMedico(matricula, nombre, apellido, idEspecialidad));
            return true;
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
    }
}
