using System;

namespace ListaElementos
{
    class Nodo
    {
        public int valor;
        public Nodo siguiente;

        public Nodo(int v)
        {
            valor = v;
            siguiente = null;
        }
    }

    class Lista
    {
        public Nodo inicio;

        public Lista()
        {
            inicio = null;
        }

        public void Agregar(int numero)
        {
            Nodo nuevo = new Nodo(numero);
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Nodo aux = inicio;
                while (aux.siguiente != null)
                {
                    aux = aux.siguiente;
                }
                aux.siguiente = nuevo;
            }
        }

        public int ContarElementos()
        {
            int contador = 0;
            Nodo aux = inicio;
            while (aux != null)
            {
                contador++;
                aux = aux.siguiente;
            }
            return contador;
        }

        public void Mostrar()
        {
            Nodo aux = inicio;
            while (aux != null)
            {
                Console.Write(aux.valor + " -> ");
                aux = aux.siguiente;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lista miLista = new Lista();
            miLista.Agregar(5);
            miLista.Agregar(8);
            miLista.Agregar(12);
            miLista.Agregar(20);

            Console.WriteLine("Contenido de la lista:");
            miLista.Mostrar();

            int cantidad = miLista.ContarElementos();
            Console.WriteLine("Número total de elementos: " + cantidad);
        }
    }
}