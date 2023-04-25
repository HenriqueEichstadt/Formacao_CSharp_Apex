namespace Capitulo12.Exercicio2
{
    internal class Program
    {
        /*
         2. Em época de pouco dinheiro, os comerciantes estão procurando aumentar suas vendas oferecendo
            desconto. Faça um algoritmo que possa entrar com o valor de um produto e imprima o novo valor tendo em
            vista que o desconto foi de 9%.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Valor de um produto");
            var valorProduto = double.Parse(Console.ReadLine());


            var valorComDesconto = valorProduto * 0.91;
            Console.WriteLine($"Valor com desconto: {valorComDesconto}");
        }
    }
}