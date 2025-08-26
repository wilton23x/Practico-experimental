using System;
using System.Collections.Generic;

class TraductorBasico
{
    static void Main()
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"part", "parte"},
            {"child", "niño"},
            {"eye", "ojo"},
            {"woman", "mujer"},
            {"place", "lugar"},
            {"work", "trabajo"},
            {"week", "semana"},
            {"case", "caso"},
            {"point", "punto"},
            {"government", "gobierno"},
            {"company", "empresa"}
        };

        int opcion;
        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("⚠ Opción no válida. Intente nuevamente.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario);
                    break;
                case 2:
                    AgregarPalabra(diccionario);
                    break;
                case 0:
                    Console.WriteLine("👋 Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("⚠ Opción no válida. Intente nuevamente.");
                    break;
            }
        } while (opcion != 0);
    }

    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese una frase: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("\nTraducción parcial: ");
        foreach (string palabra in palabras)
        {
            string palabraLimpia = palabra.TrimEnd('.', ',', ';', ':', '!', '?');

            if (diccionario.ContainsKey(palabraLimpia.ToLower()))
            {
                Console.Write(diccionario[palabraLimpia.ToLower()]);
            }
            else
            {
                Console.Write(palabraLimpia);
            }

            if (".,;:!?".Contains(palabra[^1]))
                Console.Write(palabra[^1]);

            Console.Write(" ");
        }
        Console.WriteLine();
    }

    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la palabra en inglés: ");
        string ingles = Console.ReadLine().ToLower();

        Console.Write("Ingrese su traducción al español: ");
        string espanol = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine($"✅ Palabra '{ingles}' agregada con traducción '{espanol}'.");
        }
        else
        {
            Console.WriteLine("⚠ Esa palabra ya existe en el diccionario.");
        }
    }
}