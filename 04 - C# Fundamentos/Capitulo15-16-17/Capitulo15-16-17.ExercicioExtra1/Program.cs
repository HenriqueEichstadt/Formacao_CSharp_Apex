namespace Capitulo15_16_17.ExercicioExtra1
{
	public class Program
	{
		/*
		Implemente o seguinte projeto com os requisitos a seguir.
		
		a) Crie o banco de dados chamado 'ProjetoExercicioExtra1' utilizando o comando abaixo:
			
			CREATE DATABASE Aula11052023;

		
		b) Crie a tabela 'Produtos' utilizando o comando abaixo:

			CREATE TABLE Produtos (
				Id INT IDENTITY(1, 1),
				Nome VARCHAR(100),
				Marca VARCHAR(75),
				PrecoCompra DECIMAL(18, 2)
				PrecoVenda DECIMAL(18, 2)		
				PRIMARY KEY(Id)
			);


		c) Crie uma classe 'Usuario' contendo as propriedades conforme as colunas da tabela 'Produtos'

		D) Crie uma classe 'ProdutoRepositorio' contendo métodos para um CRUD completo de um produto.
			
			O que é CRUD? Um Acrônimo para as seguintes operações de banco de dados:

				C - Create (Adicionar produto)
				R - Read (Obter um produto)
				U - Update (Atualizar um produto
				D - Delete (Deletar um produto)

			Portanto, dentro de 'ProdutoRepositorio' é necessário criar os seguintes métodos e implementálos:
				
				- public void Adicionar(Produto produto) {}
				- public Produto Obter(int idProduto) {}
				- public List<Produto> ObterTodos() {}
				- public void Atualizar(Produto produto) {}
				- public void Deletar(Produto produto) {}

		E) No método 'Main', instancie o ProdutoRepositorio e chame os métodos implementados para testar sua implementação.
		 */
		public static void Main(string[] args)
		{
			Console.WriteLine("Resolva...");
		}
	}
}