using MeuProjetoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuProjetoApi.BancoDados.Configs;

public class UsuarioConfig: IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuarios");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).UseIdentityColumn();

        // mapeando as propriedades
        builder.Property(x => x.NomeUsuario)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Senha)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Ativo)
            .HasDefaultValue(true)
            .IsRequired();
        
        builder.Property(x => x.Tipo)
            .HasDefaultValue("usuario")
            .HasMaxLength(30)
            .IsRequired();

        builder.HasData(new List<Usuario>()
        {
            //migrationBuilder.Sql("INSERT INTO Usuarios (NomeUsuario, Email, Senha) VALUES ('admin', 'admin@email.com', 'admin');");
            new Usuario() { Id = 1, NomeUsuario = "admin", Email = "admin@email.com", Senha = "admin", Tipo = "administrador" },
            new Usuario() { Id = 2, NomeUsuario = "Jose", Email = "jose@email.com", Senha = "123", Tipo = "usuario" }
        });
    }
}