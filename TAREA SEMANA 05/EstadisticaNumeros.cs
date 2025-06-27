// Tarea Semana 05 - Ejercicio 5

class Estadistica
{
    private List<double> datos;

    public Estadistica(string entrada)
    {
        datos = entrada.Split(',').Select(x => double.Parse(x.Trim())).ToList();
    }

    public double CalcularMedia()
    {
        return datos.Average();
    }

    public double CalcularDesviacion()
    {
        double media = CalcularMedia();
        double suma = 0;

        foreach (double n in datos)
        {
            suma += Math.Pow(n - media, 2);
        }

        return Math.Sqrt(suma / datos.Count);
    }

    public void Mostrar()
    {
        Console.WriteLine("Media: " + CalcularMedia().ToString("F2"));
        Console.WriteLine("Desviación típica: " + CalcularDesviacion().ToString("F2"));
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa los números separados por comas:");
        string entrada = Console.ReadLine();

        Estadistica est = new Estadistica(entrada);
        est.Mostrar();
    }
}

