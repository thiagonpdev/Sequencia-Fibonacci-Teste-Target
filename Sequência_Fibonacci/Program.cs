//Código identifica em uma Sequência de Fibonacci, e se o número digitado faz parte da sequência ou não;

namespace Sequência_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número, para saber se ele pertence à sequência Fibonacci: ");
            Console.WriteLine();
            int num = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Sequência de Fibonacci até o número informado: ");
            Console.WriteLine();

            int a = 0, b = 1, c = 0;

            while (c <= num)
            {
                Console.WriteLine();
                Console.Write(" " + c + " ");
                
                if (c == num)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("O número pertence à sequência de Fibonacci.");
                    return;
                }
                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine("O número não pertence à sequência de Fibonacci.");
        }
    }
}