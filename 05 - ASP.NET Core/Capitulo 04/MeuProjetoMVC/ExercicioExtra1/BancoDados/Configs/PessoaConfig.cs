using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioExtra1.Entidades;

namespace ExercicioExtra1.BancoDados.Configs
{
    public class PessoaConfig : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            // definindo o nome da tabela
            builder.ToTable("Pessoas");

            // definindo a coluna principal (primary key)
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            // mapeando as propriedades
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasMaxLength(14);

            builder.Property(x => x.Telefone)
                .HasMaxLength(30);


            builder.HasOne(pessoa => pessoa.Endereco)
                .WithOne(endereco => endereco.Pessoa)
                .HasForeignKey<Pessoa>(pessoa => pessoa.IdEndereco);


        }
    }
}
