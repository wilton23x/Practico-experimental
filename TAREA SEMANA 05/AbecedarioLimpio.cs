// Tarea Semana 05 - Ejercicio 3

class Abecedario
{
    private List<char> letras;

    public Abecedario()
    {
        letras = new List<char>();
        for (char c = 'A'; c <= 'Z'; c++)
        {
            letras.Add(c);
        }
    }

    public void EliminarLetras()
    {
        for (int i = letras.Count - 1; i >= 0; i--)
        {
            if ((i + 1) % 3 == 0)
            {
                letras.RemoveAt(i);
            }
        }
    }

    public void Mostrar()
    {
        Console.WriteLine("Letras restantes:");
        foreach (char letra in letras)
        {
            Console.Write(letra + " ");
        }
    }
}

class Program
{
    static void Main()
    {
        Abecedario abc = new Abecedario();
        abc.EliminarLetras();
        abc.Mostrar();
    }
}
