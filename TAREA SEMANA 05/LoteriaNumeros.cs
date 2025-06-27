// Tarea Semana 05 - Ejercicio 2

class Loteria
{
    private List<int> numeros;

    public Loteria()
    {
        numeros = new List<int>();
    }

    public void IngresarNumeros()
    {
        Console.WriteLine("Ingrese los números ganadores separados por espacios:");
        string entrada = Console.ReadLine();
        string[] partes = entrada.Split(' ');

        foreach (string p in partes)
        {
            int numero = int.Parse(p);
            numeros.Add(numero);
        }

        numeros.Sort();
    }

    public void Mostrar()
    {
        Console.WriteLine("Números ganadores ordenados:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }
    }
}

class Program
{
    static void Main()
    {
        Loteria l = new Loteria();
        l.IngresarNumeros();
        l.Mostrar();
    }
}
