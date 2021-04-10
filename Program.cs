using System;

namespace Exercicio_Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nota1, nota2, nota3, nota4, resultado;

            
            Console.Write("Digite sua primeira nota...: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Digite sua segunda nota...: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Digite sua terceira nota...: ");
            nota3 = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Digite sua quarta nota...: ");
            nota4 = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            resultado = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine($"Sua nota é {resultado:N1}");
            Console.ResetColor();

            Console.WriteLine();

            if (resultado < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você foi reprovado!");
                Console.ResetColor();
            }

            else if (resultado <= 6 || resultado >= 5) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você está de recuperação! Bons estudos, nos vemos mais tarde...");
                Console.ResetColor();
            }
     
            else if (resultado > 6 && resultado <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você foi Aprovado!");
                Console.ResetColor();
            }
        }
    }
}
