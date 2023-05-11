
using System.Data.SqlClient;

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
		static void Main(string[] args)
		{
            // conectar sem senha
            //Data Source=HENRIQUEEICHSTA\\SQLEXPRESS;Initial catalog=Aula11052023;Trusted_connection=true;trustservercertificate=true

            // Conectar com senha
            //"Server=HENRIQUEEICHSTA\\SQLEXPRESS;Database=Aula11052023;User Id=sa;Password=123456789;"
            var connectionString = "Server=HENRIQUEEICHSTA\\SQLEXPRESS;Database=Aula11052023;User Id=sa;Password=123456789;";
			SqlConnection conexao = new SqlConnection(connectionString);

        }
	}
}