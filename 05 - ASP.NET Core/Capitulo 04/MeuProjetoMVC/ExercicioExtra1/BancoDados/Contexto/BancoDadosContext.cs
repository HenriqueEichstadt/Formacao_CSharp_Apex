using ExercicioExtra1.BancoDados.Configs;
using ExercicioExtra1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ExercicioExtra1.BancoDados.Contexto
{
    internal class BancoDadosContext : DbContext
    {
        public DbSet<Produto> Produtos { get;set; }
        public DbSet<Pessoa> Pessoas { get;set; }
        public DbSet<Endereco> Enderecos { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=HENRIQUEEICHSTA\\SQLEXPRESS;Database=ExercicioExtra1;User Id=sa;Password=123456789;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // importart as configs
            modelBuilder.ApplyConfiguration(new ProdutoConfig());
            modelBuilder.ApplyConfiguration(new PessoaConfig());
            modelBuilder.ApplyConfiguration(new EnderecoConfig());
        }
    }
}
