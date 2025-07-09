
namespace VerificarBalanceo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese una expresión matemática:");
            string expresion = System.Console.ReadLine();

            if (Balanceada(expresion))
            {
                System.Console.WriteLine("Fórmula balanceada.");
            }
            else
            {
                System.Console.WriteLine("Fórmula no balanceada.");
            }
        }

        static bool Balanceada(string expresion)
        {
            System.Collections.Generic.Stack<char> pila = new System.Collections.Generic.Stack<char>();

            foreach (char c in expresion)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Count == 0)
                    {
                        return false;
                    }

                    char simboloApertura = pila.Pop();

                    if ((c == ')' && simboloApertura != '(') ||
                        (c == '}' && simboloApertura != '{') ||
                        (c == ']' && simboloApertura != '['))
                    {
                        return false;
                    }
                }
            }

            return pila.Count == 0;
        }
    }
}
