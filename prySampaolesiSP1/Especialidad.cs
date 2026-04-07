namespace prySampaolesiSP1
{
    public class Especialidad
    {
        public int IdEspecialidad { get; set; }
        public string Nombre { get; set; }

        public Especialidad(int idEspecialidad, string nombre)
        {
            IdEspecialidad = idEspecialidad;
            Nombre = nombre;
        }

        public Especialidad() { }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
