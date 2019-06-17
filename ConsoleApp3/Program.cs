using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string c;
            int x = 0;
            double resultado = 0;

            do
            {
                Console.WriteLine("digite um numero:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("digite a operção:");
                c = (Console.ReadLine());
                Console.WriteLine("digite outro numero:");
                b = double.Parse(Console.ReadLine());

                if (c == "+")
                    resultado = soma(a, b);
                if (c == "-")
                    resultado = subtracao(a, b);
                if (c == "*")
                    resultado = multiplicacao(a, b);
                if (c == "/")
                    resultado = divisao(a, b);
                if (c == "^")
                    resultado = potencia(a, b);
                if (c == "%")
                    resultado = porcentagem(a, b);

                Console.WriteLine("o resultado é:" + resultado.ToString());

            } while (x < 10);

        }
        static double soma(double a, double b) { return a + b; }

        static double subtracao(double a, double b) { return a - b; }

        static double multiplicacao(double a, double b) { return a * b; }

        static double divisao(double a, double b) { try {return a / b; } catch (Exception) { throw new Exception(); } }

        static double potencia(double a, double b) { return Math.Pow(a, b); }

        static double porcentagem(double a, double b) { return a * (b / 100); }

    }
}
