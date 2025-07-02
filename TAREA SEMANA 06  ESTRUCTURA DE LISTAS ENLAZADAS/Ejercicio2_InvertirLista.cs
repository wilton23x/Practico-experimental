using System;

namespace ListaInvertida
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

        public void Invertir()
        {
            Nodo anterior = null;
            Nodo actual = inicio;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.siguiente;
                actual.siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }

            inicio = anterior;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lista miLista = new Lista();
            miLista.Agregar(10);
            miLista.Agregar(15);
            miLista.Agregar(25);
            miLista.Agregar(30);

            Console.WriteLine("Lista original:");
            miLista.Mostrar();

            miLista.Invertir();

            Console.WriteLine("Lista invertida:");
            miLista.Mostrar();
        }
    }
}