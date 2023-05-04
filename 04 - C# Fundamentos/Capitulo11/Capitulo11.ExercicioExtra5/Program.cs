namespace Capitulo11.ExercicioExtra5
{
    internal class Program
    {
        /*
         a) Crie uma classe chamada "Livro" que possua os seguintes atributos: 
            - título (string) (get e set públicos) 
            - autor (string)  (get e set públicos)  
            - número de páginas (inteiro)  (get e set públicos) 
            - preço (double)  (get e set públicos)
        
        b) Em seguida, crie um método chamado "CalcularDesconto()" que receba um valor percentual de desconto e retorne o novo preço 
            do livro com esse desconto aplicado.

        c) Crie uma classe chamada "CarrinhoDeCompras" que possua o seguinte atributo:
            - livros (List<Livro>) (get público e set privado)
        
        d) Adicione os seguintes métodos na classe "CarrinhoDeCompras":
            - void AdicionarLivro(): recebe um objeto da classe "Livro" e adiciona à lista de livros do carrinho.
            - void RemoverLivro(): recebe um objeto da classe "Livro" e remove da lista de livros do carrinho, caso o livro esteja presente na lista.
            - void CalcularTotal(): retorna o valor total dos livros presentes na lista do carrinho.
            - Sobrescreva o método "ToString()" na classe "Livro" para que ele retorne uma string formatada contendo o título, autor, número de páginas 
                e preço do livro. Sobrescreva também o método "ToString()" na classe "CarrinhoDeCompras" para que ele retorne uma string formatada contendo a lista de livros presentes no carrinho e o valor total da compra.

        e) Utilize o Método 'Main' da classe 'Program' e instancie alguns objetos da classe "Livro", um objeto da 
            classe "CarrinhoDeCompras" e realize algumas operações de adicionar e remover livros do carrinho. 
            Em seguida, chame o método "CalcularTotal()" do carrinho e o método "CalcularDesconto()" de alguns livros, 
            e imprima na tela os dados do carrinho de compras e dos livros.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Resolva...");
        }
    }
}