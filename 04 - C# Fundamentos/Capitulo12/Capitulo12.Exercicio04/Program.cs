namespace Capitulo12.Exercicio4
{
    internal class Program
    {
        /*
         4. Todo restaurante, embora por lei não possa obrigar o cliente a pagar, cobra 10% para o garçom. Fazer um
            algoritmo que leia o valor gasto com despesas realizadas em um restaurante e imprima o valor total com
            gorjeta.
         */
        static void Main(string[] args)
        {
            var valorGastorestaurante = SolicitarValor("Qual o valor gasto?");

            // aplicando mais 10% na comanda de gasto
            var valorComGorjeta = valorGastorestaurante * 1.1;
            Console.WriteLine($"O valor gasto com a gorjeta foi de {valorComGorjeta}");
        }

        private static double SolicitarValor(string mensagemSolicitacao)
        {
            Console.WriteLine(mensagemSolicitacao);
            var valorGastorestaurante = double.Parse(Console.ReadLine());
            return valorGastorestaurante;
        }
    }
}