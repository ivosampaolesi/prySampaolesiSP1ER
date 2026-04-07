namespace prySampaolesiSP1
{
    public class ClaseMedico
    {
        //Atributos
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdEspecialidad { get; set; }

        //Constructor
        public ClaseMedico(int matricula, string nombre, string apellido, int idEspecialidad)
        {
            Matricula = matricula;
            Nombre = nombre;
            Apellido = apellido;
            IdEspecialidad = idEspecialidad;
        }

        
    }
}
