using System;
namespace HospiCasa.App.Dominio
{

    public class Persona
    {
        public int Id { get; set; } // forma de propiedades // private int id; // forma 
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        private string Telefono { get; set; }
        public Genero Genero { get; set; }


    }
}