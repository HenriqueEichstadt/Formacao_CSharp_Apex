using Capitulo15_16_17.ExercicioExtra1.Modelos;
using Capitulo15_16_17.ExercicioExtra1.Repositorios;

namespace Capitulo15_16_17.ExercicioExtra1
{
	public class Program
	{
        /*
		Implemente o seguinte projeto com os requisitos a seguir.
		
		a) Crie o banco de dados chamado 'ProjetoExercicioExtra1' utilizando o comando abaixo:
			
			CREATE DATABASE ExercicioProduto;

		
		b) Crie a tabela 'Produtos' utilizando o comando abaixo:

			CREATE TABLE Produtos (
				Id INT IDENTITY(1, 1),
				Nome VARCHAR(100),
				Marca VARCHAR(75),
				PrecoCompra DECIMAL(18, 2),
				PrecoVenda DECIMAL(18, 2),	
				PRIMARY KEY(Id)
			);


		c) Crie uma classe 'Produto' contendo as propriedades conforme as colunas da tabela 'Produtos'

		D) Crie uma classe 'ProdutoRepositorio' contendo métodos para um CRUD completo de um produto.
			
			O que é CRUD? Um Acrônimo para as seguintes operações de banco de dados:

				C - Create (Adicionar produto)
				R - Read (Obter um produto)
				U - Update (Atualizar um produto
				D - Delete (Deletar um produto)

			Portanto, dentro de 'ProdutoRepositorio' é necessário criar os seguintes métodos e implementálos:
				
				- public void Adicionar(Produto produto) {}
				- public Produto ObterPorId(int idProduto) {}
				- public List<Produto> ObterTodos() {}
				- public void Atualizar(Produto produto) {}
				- public void Deletar(int idProduto) {}

		E) No método 'Main', instancie o ProdutoRepositorio e chame os métodos implementados para testar sua implementação.
		 */
        public static void Main(string[] args)
		{
			ProdutoRepositorio repositorio = new ProdutoRepositorio();


			// Adicionando
			Produto produto1 = new Produto();
			produto1.Nome = "Coca-Cola";
			produto1.Marca = "Coca";
			produto1.PrecoCompra = 6.50;
			produto1.PrecoVenda = 9.90;
            repositorio.Adicionar(produto1);


            // Atualizando (lembre-se que é necessário passar o id ao atualizar)
            Produto produto2 = new Produto();
            produto2.Id = 1;
            produto2.Nome = "Coca-Cola";
            produto2.Marca = "Coca";
            produto2.PrecoCompra = 6.20;
            produto2.PrecoVenda = 9.90;
            repositorio.Atualizar(produto2);


			// obtendo todos
			var listaProdutos = repositorio.ObterTodos();
            foreach (var produto in listaProdutos)
			{
				Console.WriteLine($"Id: {produto.Id}, Nome: {produto.Nome}, Marca: {produto.Marca}, PrecoCompra: {produto.PrecoCompra}, PrecoVenda: {produto.PrecoVenda}");
			}

			// obtendo pelo id
            var produtoId1 = repositorio.ObterPorId(1);
            Console.WriteLine($"Id: {produtoId1.Id}, Nome: {produtoId1.Nome}, Marca: {produtoId1.Marca}, PrecoCompra: {produtoId1.PrecoCompra}, PrecoVenda: {produtoId1.PrecoVenda}");

			// deletando
            repositorio.Deletar(1);
        }


    }
}