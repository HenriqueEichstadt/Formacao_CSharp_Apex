namespace Capitulo12.Exercicio1
{
    internal class Program
    {
        /*
         1. Antes do racionamento de energia ser decretado, quase ninguém falava em quilowatts; mas, agora, todos
            incorporaram essa palavra em seu vocabulário. Sabendo-se que 100 quilowatts de energia custa um sétimo do
            salário mínimo, fazer um algoritmo que receba o valor do salário mínimo e a quantidade de quilowatts gasta
            por uma residência e calcule. Imprima:
                
                • O valor em reais de cada quilowatt
                • O valor em reais a ser pago
                • O novo valor a ser pago por essa residência com um desconto de 10%
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o salário mínimo");
            var salarioMinimo = double.Parse(Console.ReadLine());


            Console.WriteLine("Quantidade de quilowatts gasta");
            var quilowattsGastos = double.Parse(Console.ReadLine());


            // O valor em reais de cada quilowatt
            var precoDeUmQuilowatt = (salarioMinimo / 7) / 100;
            Console.WriteLine("O valor em reais de cada quilowatt: " + precoDeUmQuilowatt);

            // O valor em reais a ser pago
            var valorPago = quilowattsGastos * precoDeUmQuilowatt;
            Console.WriteLine("O valor em reais a ser pago: " + valorPago);


            // O novo valor a ser pago por essa residência com um desconto de 10%
            var valorComDesconto = valorPago * 0.9;
            Console.WriteLine("O novo valor a ser pago por essa residência com um desconto de 10%: " + valorComDesconto);

        }
    }
}