using System.Security.Cryptography;

public class AgendaTurnos
{
    public Paciente[] Turnos { get; set; }
    public AgendaTurnos(int maxTurnos)
    {
        Turnos = new Paciente[maxTurnos];
    }

    public void AgendarTurno(Paciente paciente, int posicion)
    {
        Turnos[posicion] = paciente;
    }

    public void ImprimirTurnos()
    {
        System.Console.WriteLine("Agenda de Turnos");
        System.Console.WriteLine("================");

        for (int i = 0; i < Turnos.Length; i++)
        {
            if (Turnos[i] != null)
            {
                System.Console.WriteLine($"Turno asignado a ==> Paciente: {Turnos[i].Nombre}, Cédula: {Turnos[i].Cedula}, Edad: {Turnos[i].Edad}");
            }
        }
    }

    public void BuscarCedula(string cedula)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Búsqueda de Paciente por Cédula");
        System.Console.WriteLine("===============================");
        if (encontrar(cedula))
        {
            System.Console.WriteLine("El registro ha sido encontrado");
        }
        else
        {
            System.Console.WriteLine("Registro no encontrado");
        }
    }
    private bool encontrar(string Nombre)
    {
        bool encontrado = true;
        for (int i = 0; i < Turnos.Length; i++)
        {
            if (Turnos[i] != null)
            {
                if (Nombre == Turnos[i].Nombre)
                {
                    encontrado = false;
                }
            }
        }
        return encontrado;
    }
}    