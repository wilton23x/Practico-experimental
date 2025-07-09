
namespace TorresDeHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese el número de discos:");
            int numDiscos = int.Parse(System.Console.ReadLine());

            System.Collections.Generic.Stack<int> torreOrigen = new System.Collections.Generic.Stack<int>();
            System.Collections.Generic.Stack<int> torreDestino = new System.Collections.Generic.Stack<int>();
            System.Collections.Generic.Stack<int> torreAuxiliar = new System.Collections.Generic.Stack<int>();

            for (int i = numDiscos; i >= 1; i--)
            {
                torreOrigen.Push(i);
            }

            System.Console.WriteLine("\nMovimientos:");
            Hanoi(numDiscos, torreOrigen, torreDestino, torreAuxiliar, "Origen", "Destino", "Auxiliar");
        }

        static void Hanoi(int n, 
            System.Collections.Generic.Stack<int> origen, 
            System.Collections.Generic.Stack<int> destino, 
            System.Collections.Generic.Stack<int> auxiliar, 
            string nombreOrigen, string nombreDestino, string nombreAuxiliar)
        {
            if (n == 1)
            {
                int disco = origen.Pop();
                destino.Push(disco);
                System.Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            }
            else
            {
                Hanoi(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);
                Hanoi(1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);
                Hanoi(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
            }
        }
    }
}
