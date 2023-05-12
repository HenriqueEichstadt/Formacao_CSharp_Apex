using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitulo15_16_17.ExercicioExtra1.Modelos;

namespace Capitulo15_16_17.ExercicioExtra1.Repositorios
{
    public class ProdutoRepositorio
    {
        public const string ConnectionString = "Server=HENRIQUEEICHSTA\\SQLEXPRESS;Database=ExercicioProduto;User Id=sa;Password=123456789;";

        public void Adicionar(Produto produto)
        {
            SqlConnection conexao = new SqlConnection(ConnectionString);

            try
            {
                conexao.Open();

                var comandoInsert = @"INSERT INTO Produtos (Nome, Marca, PrecoCompra, PrecoVenda) 
                                       VALUES(@Nome, @Marca, @PrecoCompra, @PrecoVenda)";

                SqlCommand comando = new SqlCommand(comandoInsert, conexao);
                comando.Parameters.AddWithValue("@Nome", produto.Nome);
                comando.Parameters.AddWithValue("@Marca", produto.Marca);
                comando.Parameters.AddWithValue("@PrecoCompra", produto.PrecoCompra);
                comando.Parameters.AddWithValue("@PrecoVenda", produto.PrecoVenda);

                var linhasAfetadas = comando.ExecuteNonQuery();

                Console.WriteLine("Linhas afetadas: " + linhasAfetadas);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Atualizar(Produto produto)
        {

        }

        public Produto ObterPorId(int idProduto)
        {
            return null;
        }

        public List<Produto> ObterTodos()
        {
            return null;
        }

        public void Deletar(int idProduto)
        {

        }
    }
}
