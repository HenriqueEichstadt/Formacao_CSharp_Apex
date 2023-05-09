namespace Capitulo13.TratamentoErros
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira um número (divisor)");
            var divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira um número (dividendo)");
            var dividendo = Convert.ToInt32(Console.ReadLine());

            var resultado = divisor / dividendo;
            Console.WriteLine("O resultado da divisão é: " + resultado);

            Console.ReadKey();
        }
    }
}