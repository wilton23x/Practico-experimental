// Tarea Semana 05 - Ejercicio 4

class Vector
{
    private List<int> valores;

    public Vector(List<int> v)
    {
        valores = v;
    }

    public List<int> GetValores()
    {
        return valores;
    }
}

class Program
{
    static void Main()
    {
        Vector v1 = new Vector(new List<int> { 1, 2, 3 });
        Vector v2 = new Vector(new List<int> { -1, 0, 2 });

        int producto = 0;

        for (int i = 0; i < v1.GetValores().Count; i++)
        {
            producto += v1.GetValores()[i] * v2.GetValores()[i];
        }

        Console.WriteLine("Producto escalar: " + producto);
    }
}
