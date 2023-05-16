
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Capitulo15_16_17.BancoDeDados
{
	public class Program
	{

        /*
			CREATE DATABASE Aula11052023;

			CREATE TABLE Usuarios (
				Id INT IDENTITY(1, 1),
				Nome VARCHAR(30),
				Idade INT,
				Email VARCHAR(40),
				PRIMARY KEY(Id)
			);

			INSERT INTO Usuarios (Nome, Idade, Email)
				VALUES
				('João', 18, 'joao@email.com'),
				('Maria', 25, 'maria@email.com');
		*/

        // conectar sem senha
        //Data Source=HENRIQUEEICHSTA\\SQLEXPRESS;Initial catalog=Aula11052023;Trusted_connection=true;trustservercertificate=true

        // Conectar com senha
        //"Server=HENRIQUEEICHSTA\\SQLEXPRESS;Database=Aula11052023;User Id=sa;Password=123456789;"

        static void Main(string[] args)
		{
            // buscar
            var usuariosBuscados = SelectNoBanco();

            foreach (var usuario in usuariosBuscados)
            {
                Console.WriteLine($"Id: {usuario.Id}");
            }


            // inserir
            /*var usuario = new Usuario();
            usuario.Nome = "Teste";
            usuario.Email = "teste@teste.com";
            usuario.Idade = 12;

            InserirNoBanco(usuario);*/


            // atualizar
            /*var usuario = new Usuario();
            usuario.Id = 1;
            usuario.Nome = "Francisco";
            usuario.Email = "francisco@teste.com";
            usuario.Idade = 112;

            
            AtualizarNoBanco(usuario);*/


            // deletar
            DeletarNoBanco(3);
        }

        public static void DeletarNoBanco(int idUsuario)
        {
            var connectionString = "Server=HENRIQUEEICHSTA\\SQLEXPRESS;Database=Aula11052023;User Id=sa;Password=123456789;";
            SqlConnection conexao = new SqlConnection(connectionString);

            try
            {
                conexao.Open();

                var comandoDelete = @"DELETE FROM Usuarios
                                    WHERE Id = @Id";

                SqlCommand comando = new SqlCommand(comandoDelete, conexao);
                comando.Parameters.AddWithValue("@Id", idUsuario);

                var linhasAfetadas = comando.ExecuteNonQuery();

                Console.WriteLine("Linhas afetadas: " + linhasAfetadas);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void AtualizarNoBanco(Usuario usuario)
        {
            var connectionString = "Server=HENRIQUEEICHSTA\\SQLEXPRESS;Database=Aula11052023;User Id=sa;Password=123456789;";
            SqlConnection conexao = new SqlConnection(connectionString);

            try
            {
                conexao.Open();

                var comandoUpdate = @"UPDATE Usuarios
                                    SET Nome = @Nome,
                                        Idade = @Idade,
                                        Email = @Email
                                    WHERE Id = @Id";

                SqlCommand comando = new SqlCommand(comandoUpdate, conexao);
                comando.Parameters.AddWithValue("@Id", usuario.Id);
                comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                comando.Parameters.AddWithValue("@Idade", usuario.Idade);
                comando.Parameters.AddWithValue("@Email", usuario.Email);

                var linhasAfetadas = comando.ExecuteNonQuery();

                Console.WriteLine("Linhas afetadas: " + linhasAfetadas);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


        public static void InserirNoBanco(Usuario usuario)
		{
            var connectionString = "Server=HENRIQUEEICHSTA\\SQLEXPRESS;Database=Aula11052023;User Id=sa;Password=123456789;";
            SqlConnection conexao = new SqlConnection(connectionString);

            try
            {
                conexao.Open();

                var comandoInsert = @"INSERT INTO Usuarios (Nome, Idade, Email) 
                                       VALUES(@Nome, @Idade, @Email)";

                SqlCommand comando = new SqlCommand(comandoInsert, conexao);
                comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                comando.Parameters.AddWithValue("@Idade", usuario.Idade);
                comando.Parameters.AddWithValue("@Email", usuario.Email);

                var linhasAfetadas = comando.ExecuteNonQuery();

                Console.WriteLine("Linhas afetadas: " + linhasAfetadas);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


		public static List<Usuario> SelectNoBanco()
		{
            var connectionString = "Server=HENRIQUEEICHSTA\\SQLEXPRESS;Database=Aula11052023;User Id=sa;Password=123456789;";
            SqlConnection conexao = new SqlConnection(connectionString);

            var listaUsuariosParaRetornar = new List<Usuario>();

            try
            {
                conexao.Open();

                var comando = "SELECT Id, Nome, Idade, Email FROM Usuarios";

                SqlCommand comandoBusca = new SqlCommand(comando, conexao);

                SqlDataReader reader = comandoBusca.ExecuteReader();

                while (reader.Read())
                {
                    var novoUsuario = new Usuario();
                    novoUsuario.Id = Convert.ToInt32(reader["Id"]);
                    novoUsuario.Nome = Convert.ToString(reader["Nome"]);
                    novoUsuario.Idade = Convert.ToInt32(reader["Idade"]);
                    novoUsuario.Email = Convert.ToString(reader["Email"]);

                    listaUsuariosParaRetornar.Add(novoUsuario);

                }

                return listaUsuariosParaRetornar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return listaUsuariosParaRetornar;
        }
	}
}