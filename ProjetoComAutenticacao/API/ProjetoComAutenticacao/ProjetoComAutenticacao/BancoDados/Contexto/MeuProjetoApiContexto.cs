using MeuProjetoApi.BancoDados.Configs;
using MeuProjetoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuProjetoApi.BancoDados.Contexto
{
    public class MeuProjetoApiContexto : DbContext
    {
        public DbSet<Pessoa> TabelaPessoas { get; set; }
        public DbSet<Usuario> TabelaUsuarios { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=HENRIQUEEICHSTA\\SQLEXPRESS;Database=MeuProjetoApiComAutenticacao;User Id=sa;Password=123456789;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfig());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
        }
    }
}
