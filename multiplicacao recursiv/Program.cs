using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicacao_recursiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("digite 1 numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite 1 numero: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(Multiplicar(a, b));
            Console.ReadKey();
        }
        static int Multiplicar(int A, int B)
        {
            int MultAux(int a, int aux, int b)
            {
                if (a == 0 || b == 0)
                    return 0;
                if (b == 1)
                    return a;
                a += aux;
                return MultAux(a, aux, b - 1);
            }
            return MultAux(A, A, B);
        }
    }
}
