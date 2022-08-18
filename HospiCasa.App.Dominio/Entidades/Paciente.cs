namespace HospiCasa.App.Dominio
{
    public class Paciente : Persona
    {
        public Paciente()
        {

        }

        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string FechaNacimiento { get; set; }
        public int longitud { get; set; }
        public int latitud { get; set; }
        public Familiar FamiliarAsignado { get; set; }
        public Enfermero EnfermeroAsignado { get; set; }


    }
}