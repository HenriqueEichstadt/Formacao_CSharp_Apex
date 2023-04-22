using System.Reflection;

namespace Capitulo4.Operadores
{
    internal class Program
    {
        /// <summary>
        /// Este objeto faz alguma coisa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // + Adição
            int valor1 = 10;
            int valor2 = 25;
            //Console.WriteLine(valor1 + valor2);

            // - Subtração
            int valorA = 50;
            int valorB = 20;
            //Console.WriteLine(valorA - valorB);

            // * Multiplicação
            //Console.WriteLine(10 * 10);

            // / Divisão
            //Console.WriteLine(100 / 5);

            // % Resto / Módulo
            //Console.WriteLine(7 % 2);


            // Comparação ou relacionais

            int a = 5; 
            int b = 3;

            // == Igualdade
            //Console.WriteLine(a == b);


            // > Maior
            //Console.WriteLine(a > b);

            // < Menor
            //Console.WriteLine(a < b);

            // <= Menor Igual
            //Console.WriteLine(a <= b);

            // >= Maior igual
            //Console.WriteLine(a >= b);

            // != Diferente
            //Console.WriteLine(a != b);

            // Operadores Lógicos
            int num1 = 1; 
            int num2 = 3;

            // && (E)
            bool primeiroTeste = num1 > 3 && num2 < 10;
            Console.WriteLine("Condição &&: " + primeiroTeste);

            // || (OU)
            bool segundoTeste = num1 > 3 || num2 < 10;
            Console.WriteLine("Condição ||: " + segundoTeste);

            // ! (NOT/Não)
            bool naoFalso = !false;
            Console.WriteLine("Condição !: " + naoFalso);

            // Atribuição / Operadores de Atribuição:

            // = Atribuição Simples
            long atribuicao = 12345789;

            // ++ Adição de 1 unidade
            int contador1 = 1;
            contador1++;


            // -- Subtração de 1 unidade
            int contador2 = 1;
            contador2--;
            Console.WriteLine(contador2);

            // += Atribuição Aditiva
            int quantidade = 10;
            quantidade += 15;
            // quantidade = quantidade + 15


            // Concatenação

            int idade = 10;
            string texto = "Olá, mundo. Você tem " + idade + " anos";

            string texto2 = $"Olá, mundo. Você tem {idade} anos";
            Console.WriteLine(texto2);

            string texto3 = $@"Teste

sdadad
asdasd
asdasd
- 123
- 456
- 789


hskajdhskj";
            Console.WriteLine(texto3);


            // Operadores Ternários
            int valorC = 10;
            int valorD = 20;

            // forma convencional de fazer
            if(valorC > valorD)
            {
                //Console.WriteLine($"O valor {valorC} é maior que o {valorD}");
            }

            // usando ternário
            //condição ? valor_se_verdadeiro : valor_se_falso
            string resultado = valorC > valorD ?
                $"O valor {valorC} é maior que o {valorD}"
                : "É uma condição falsa";

            Console.WriteLine(resultado);


            // Linhas de Comentário

            // Comentário de uma linha

            /*
             dlkfjdsl
            - 123
            - 456
             */

            // Input e Output

            // Output
            Console.WriteLine("Imprimindo algo aqui");

            // Input
            // prompt()
            Console.WriteLine("Insira um texto:");
            string textoEscritoPeloUsuario = Console.ReadLine();
            Console.WriteLine($"Você escreveu: {textoEscritoPeloUsuario}");
        }
    }
}