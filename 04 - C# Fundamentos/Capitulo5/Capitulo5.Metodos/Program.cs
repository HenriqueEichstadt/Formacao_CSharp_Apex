namespace Capitulo5.Metodos
{
    internal class Program
    {
        // paramos na página 29 da apostila em 19/04
        static void Main(string[] args)
        {
            Imprimir();

            ImprimirPassandoValor("Chamou o ImprimirPassandoValor");


            int resultadoSoma = SomarValores(5, 10);
            Console.WriteLine(resultadoSoma);
        }

        static void Imprimir()
        {
            Console.WriteLine("Chamou o método Imprimir");
        }

        static void ImprimirPassandoValor(string texto)
        {
            Console.WriteLine(texto);
        }

        static int SomarValores(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            return resultado;
        }
    }
}