using ExercicioExtra1.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExtra1.BancoDados.Configs
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            // definindo o nome da tabela
            builder.ToTable("Enderecos");

            // definindo a coluna principal (primary key)
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Rua).HasMaxLength(100);
            builder.Property(x => x.Cep).HasMaxLength(100);
            builder.Property(x => x.Complemento).HasMaxLength(100);
            builder.Property(x => x.Numero).HasMaxLength(100);


        }
    }
}
