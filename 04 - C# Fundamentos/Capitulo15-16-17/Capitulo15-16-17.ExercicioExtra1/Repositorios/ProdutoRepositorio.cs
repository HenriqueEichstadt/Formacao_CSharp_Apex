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
            SqlConnection conexao = new SqlConnection(ConnectionString);

            try
            {
                conexao.Open();

                var comandoUpdate = @"UPDATE Produtos
                                    SET Nome = @Nome,
                                        Marca = @Marca,
                                        PrecoCompra = @PrecoCompra,
                                        PrecoVenda = @PrecoVenda
                                    WHERE Id = @Id";

                SqlCommand comando = new SqlCommand(comandoUpdate, conexao);
                comando.Parameters.AddWithValue("@Id", produto.Id);
                comando.Parameters.AddWithValue("@Nome", produto.Nome);
                comando.Parameters.AddWithValue("@Marca", produto.Marca);
                comando.Parameters.AddWithValue("@PrecoCompra", produto.PrecoCompra);
                comando.Parameters.AddWithValue("@PrecoVenda", produto.PrecoVenda);

                var linhasAfetadas = comando.ExecuteNonQuery();

                Console.WriteLine("Linhas afetadas: " + linhasAfetadas);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public Produto ObterPorId(int idProduto)
        {
            SqlConnection conexao = new SqlConnection(ConnectionString);

            try
            {
                conexao.Open();

                var comando = "SELECT Id, Nome, Marca, PrecoCompra, PrecoVenda FROM Produtos WHERE Id = @Id";

                SqlCommand comandoBusca = new SqlCommand(comando, conexao);
                comandoBusca.Parameters.AddWithValue("@Id", idProduto);

                SqlDataReader reader = comandoBusca.ExecuteReader();

                while (reader.Read())
                {
                    var produto = new Produto();
                    produto.Id = Convert.ToInt32(reader["Id"]);
                    produto.Nome = Convert.ToString(reader["Nome"]);
                    produto.Marca = Convert.ToString(reader["Marca"]);
                    produto.PrecoCompra = Convert.ToDouble(reader["PrecoCompra"]);
                    produto.PrecoVenda = Convert.ToDouble(reader["PrecoVenda"]);


                    return produto;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter por id: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return null;
        }

        public List<Produto> ObterTodos()
        {
            List<Produto> listaProdutosObtidos = new List<Produto>();
            SqlConnection conexao = new SqlConnection(ConnectionString);

            try
            {
                conexao.Open();

                var comando = "SELECT Id, Nome, Marca, PrecoCompra, PrecoVenda FROM Produtos";

                SqlCommand comandoBusca = new SqlCommand(comando, conexao);

                SqlDataReader reader = comandoBusca.ExecuteReader();

                while (reader.Read())
                {
                    var produtoParaAddNaLista = new Produto();
                    produtoParaAddNaLista.Id = Convert.ToInt32(reader["Id"]);
                    produtoParaAddNaLista.Nome = Convert.ToString(reader["Nome"]);
                    produtoParaAddNaLista.Marca = Convert.ToString(reader["Marca"]);
                    produtoParaAddNaLista.PrecoCompra = Convert.ToDouble(reader["PrecoCompra"]);
                    produtoParaAddNaLista.PrecoVenda = Convert.ToDouble(reader["PrecoVenda"]);


                    listaProdutosObtidos.Add(produtoParaAddNaLista);
                }

                return listaProdutosObtidos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter todos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return listaProdutosObtidos;
        }

        public void Deletar(int idProduto)
        {
            SqlConnection conexao = new SqlConnection(ConnectionString);

            try
            {
                conexao.Open();

                var comandoDelete = @"DELETE FROM Produtos
                                    WHERE Id = @Id";

                SqlCommand comando = new SqlCommand(comandoDelete, conexao);
                comando.Parameters.AddWithValue("@Id", idProduto);

                var linhasAfetadas = comando.ExecuteNonQuery();

                Console.WriteLine("Linhas afetadas: " + linhasAfetadas);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao deletar pelo id" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
