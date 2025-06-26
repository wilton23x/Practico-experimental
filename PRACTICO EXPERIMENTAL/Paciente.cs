//Crear una Agenda de turnos de pacientes de una clínica
//Crear las clases paciente y turno

using System.Collections.Concurrent;
using System.Net.WebSockets;

public class Paciente
{
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }

    //Método para mostrar los datos del paciente
    public Paciente(string _cedula, string _nombre, int _edad)
    {
        Cedula = _cedula;
        Nombre = _nombre;
        Edad = _edad;
    }
}

