namespace Capitulo12.Exercicio3
{
    internal class Program
    {
        /*
         3. Criar um algoritmo que efetue o cálculo do salário líquido de um professor. Os dados fornecidos serão: valor
            da hora aula, numero de aulas dadas no mês e percentual de desconto do INSS.

            Considere a tabela do INSS de 2023:
                - Até R$1.302,00 – 7,5%
                - De R$1.302,01 até R$2.571,29 – 9%
                - De R$2.571,30 até R$3.856,94 – 12%
                - De R$3.856,95 até R$7.507,49 – 14%
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Valor da hora aula");
            var valorHoraAula = double.Parse(Console.ReadLine());

            Console.WriteLine("Número de aulas");
            var numeroAulas = int.Parse(Console.ReadLine());

            // Descobrindo o valor do salário bruto (sem os descontos)
            var salarioBruto = valorHoraAula * numeroAulas;


            // descobrindo qual o percentual de desconto de INSS devemos aplicar
            var percentualDesconto = ObterPercentualDescontoInss(salarioBruto);

            var salarioLiquido = salarioBruto * ((100 - percentualDesconto) / 100);
            Console.WriteLine($"O salário líquido é de: {salarioLiquido}");
        }

        static double ObterPercentualDescontoInss(double salarioBruto)
        {
            double percentualDesconto = 0;

            if (salarioBruto <= 1302.00)
            {
                percentualDesconto = 7.5;
            }
            else if (salarioBruto > 1302.01 && salarioBruto <= 2571.29)
            {
                percentualDesconto = 9;
            }
            else if (salarioBruto > 2571.30 && salarioBruto <= 3856.94)
            {
                percentualDesconto = 12;
            }
            else if (salarioBruto > 3856.95 && salarioBruto <= 7507.49)
            {
                percentualDesconto = 14;
            }

            return percentualDesconto;
        }
    }
}