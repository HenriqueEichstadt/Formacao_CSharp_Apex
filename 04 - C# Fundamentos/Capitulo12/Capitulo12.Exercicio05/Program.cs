namespace Capitulo12.Exercicio5
{
    internal class Program
    {
        /*
         5. Uma pessoa resolveu fazer uma aplicação em uma poupança programada. Para calcular seu rendimento, ela
            devera fornecer o valor constante da aplicação mensal, a taxa e o número de meses. Sabendo-se que a
            formula usada para este calculo é:
                
                Valor acumulado = P * ((1+i)n -1)/i
                i = taxa
                P = aplicação mensal
                n = número de meses (obs. (1+i) elevado a n)
         */
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da aplicação mensal (P): ");
            var p = double.Parse(Console.ReadLine());

            Console.Write("Digite a taxa de juros (i): ");
            var i = double.Parse(Console.ReadLine()) / 100; //divide por 100 para transformar a taxa em decimal

            Console.Write("Digite o número de meses (n): ");
            var n = int.Parse(Console.ReadLine());

            var valorAcumulado = p * ((Math.Pow(1 + i, n) - 1) / i);

            Console.WriteLine("O valor acumulado na poupança programada é: " + valorAcumulado);
        }
    }
}