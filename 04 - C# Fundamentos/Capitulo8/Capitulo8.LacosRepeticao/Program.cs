namespace Capitulo8.LacosRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Comando While / Do While

            // quando a gente não sabe quantas vezes uma
            // lógica vai se repetir

            int contador = 0;

            while(contador < 10)
            {
                Console.WriteLine(contador);
                
                contador++; // incrementar
            }



            int novoContador = 11;
            do {
                Console.WriteLine("do/while: " + novoContador);

                novoContador++;
            } while (novoContador < 10);


            // for
            // quando sabemos quantas vezes um bloco de código
            // deve se repetir

            int[] array = new int[] { 0, 1, 3, 4, 5, 5, 8, 13 };
            for (int count = 0; count < array.Length; count++)
            {
                Console.WriteLine("for: " + array[count]);
            }


            // foreach
            //let array = [0, 1, 1, 2, 3, 5, 8, 13]
            int[] arrayDeInteiros = new int[] { 0, 1, 3, 4, 5, 5, 8, 13 };

            foreach(int numero in arrayDeInteiros)
            {
                Console.WriteLine("for: " + numero);
            }


        }
    }
}