namespace Capitulo9.VariaveisIndexadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 'arrays' ou 'vetores
            int[] arrayDeInteiros = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            
            string[] arrayDeTextos = new string[] { "Segunda", "Terça", "Quarta" };


            // criar um array vazio e incluir valores dinamicamente
            int[] arrayDeInts = new int[5];
            arrayDeInteiros[0] = 1;
            arrayDeInteiros[1] = 2;
            arrayDeInteiros[2] = 3;
            arrayDeInteiros[3] = 4;
            arrayDeInteiros[4] = 5;

           


            // Listas - Collections
            var minhaLista = new List<string>();
            // adicionar itens na lista
            minhaLista.Add("Henrique");
            minhaLista.Add("João");
            minhaLista.Add("Zé");
            minhaLista.Add("Miguel");
            minhaLista.Add("Maria");

            // remover item
            minhaLista.Remove("Zé");

            // remover item pelo índice (primero item)
            minhaLista.RemoveAt(0);

            // ver se a lista contém um item
            bool possuiMaria = minhaLista.Contains("Maria");

            foreach (var nome in minhaLista)
            {
                Console.WriteLine(nome);
            }


            int[,] arrayBidimensional = new int[,] 
            { 
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 }, 
                { 7, 8 }
            };

            /*for(var i = 0; i < arrayBidimensional.Length; i++)
            {
                for (var j = 0; j < arrayBidimensional[i, 0]; j++)
                {
                    Console.WriteLine(arrayBidimensional[i, j]);
                }
            }*/

        }
    }
}