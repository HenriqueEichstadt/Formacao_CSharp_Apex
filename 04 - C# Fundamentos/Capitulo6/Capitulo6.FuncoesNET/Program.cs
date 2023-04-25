using System.Dynamic;

namespace Capitulo6.FuncoesNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Funções de Manipulação de Texto
            string texto = "Este é um texto ANTIGO";
            texto = texto.Replace("ANTIGO", "NOVO");
            Console.WriteLine(texto);


            // ['o', 'l', 'á', ',', ' ', 'b']
            string textoAntigo = "olá, boa noite";
            string textoNovo = textoAntigo.Substring(0, 8);
            Console.WriteLine(textoNovo);

            string titulo = "olá, boa noite pessoal!";
            Console.WriteLine(titulo.ToUpper());

            string subtitulo = "PROGRAMANDO EM C#";
            Console.WriteLine(subtitulo.ToLower());

            // Funções Matemáticas e Trigonométricas

            double pi = Math.PI;
            Console.WriteLine(pi);

            double seno = Math.Sin(2.20);
            double coseno = Math.Cos(2.20);
            double tangente = Math.Tan(2.20);
            Console.WriteLine($"{seno} - {coseno} - {tangente}");

            // double potencia = (2 x 2 x 2 x 2 x 2 x 2 x 2 x 2);
            double potencia = Math.Pow(2, 8);
            Console.WriteLine(potencia);

            // arredondando valores
            double arredondado = Math.Round(50.1234543, 2);
            Console.WriteLine(arredondado);


            // raiz de um número
            double raiz = Math.Sqrt(100);
            Console.WriteLine(raiz);

            
            // Data

            DateTime dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);

            Console.WriteLine("Amanhã: " + dataAtual.AddDays(1));

            Console.WriteLine("Ontem: " + dataAtual.AddDays(-1));

            DateTime primeiroDiaDesseAno = new DateTime(2023, 1, 1);


            // convertendo valores
            Console.WriteLine("Preencha um valor");
            string textoSolicitado = Console.ReadLine();

            // convert texto para inteiro
            int textoInt = Convert.ToInt32(textoSolicitado);
            int textoInt2 = int.Parse(textoSolicitado);


            // convert texto para double
            double textoDouble = Convert.ToDouble(textoSolicitado);
            double textoDouble2 = double.Parse(textoSolicitado);


            int numeroSolicitado = int.Parse(Console.ReadLine());
        }
    }
}