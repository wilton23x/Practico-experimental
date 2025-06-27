// Tarea Semana 05 - Ejercicio 1

class Curso
{
    private List<string> asignaturas;

    public Curso()
    {
        asignaturas = new List<string>();
        asignaturas.Add("Estructura de Datos");
        asignaturas.Add("Sistemas Digitales");
        asignaturas.Add("Administracion de sistemas operativos");
        asignaturas.Add("Metodologia de la Investigación");
        asignaturas.Add("Instalaciones electricas y cableado");
    }

    public void MostrarAsignaturas()
    {
        Console.WriteLine("Asignaturas del curso:");
        foreach (string a in asignaturas)
        {
            Console.WriteLine("- " + a);
        }
    }
}

class Program
{
    static void Main()
    {
        Curso curso = new Curso();
        curso.MostrarAsignaturas();
    }
}
