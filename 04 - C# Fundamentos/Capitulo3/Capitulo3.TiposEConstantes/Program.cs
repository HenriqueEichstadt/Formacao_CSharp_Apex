namespace Capitulo3.TiposEConstantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tipos de valor

            // variável de texto
            string nome = "Zé";

            // variável para um único caractere
            char letra = 'A';

            // variável de números inteiros
            int idade = 25;

            // número 'maior'
            long numeroGrande = 999999999999;

            // decimais 'monetários'
            decimal saldo = 500.5m;

            double numeroDecimalGrande = 456123.2500;

            // variável de (verdadeiro ou falso)
            bool hojeEhQuarta = true;

            // Data
            DateTime data = DateTime.Now;



            // tipos de referência

            Program teste = new Program();

            // CONTATANTES
            const int velMaxMargTiete = 90;
            const double pi = 3.14159265358979323846264338327950;

            // imprimindo um valor
            Console.WriteLine(pi);
        }
    }
}