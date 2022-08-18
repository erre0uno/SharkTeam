using System.Collections.Generic;
using HospiCasa.App.Dominio;

namespace HospiCasa.App.Persistencia{
    public interface IRepositorioPaciente{
        IEnumerable<Paciente> GetAllPacientes(); 
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void RemovePaciente(int IdPaciente);
        Paciente GetPaciente(int IdPaciente);


    }
}
