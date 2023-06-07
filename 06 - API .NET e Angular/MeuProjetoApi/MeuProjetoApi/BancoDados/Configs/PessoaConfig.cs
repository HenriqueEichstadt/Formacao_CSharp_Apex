using MeuProjetoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuProjetoApi.BancoDados.Configs
{
    public class PessoaConfig : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();

            // mapeando as propriedades
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasMaxLength(14);

            builder.Property(x => x.Telefone)
                .HasMaxLength(30);

        }
    }
}
