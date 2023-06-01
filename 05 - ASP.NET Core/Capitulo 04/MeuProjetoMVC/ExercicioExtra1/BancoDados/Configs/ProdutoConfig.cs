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
    internal class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            // definindo o nome da tabela
            builder.ToTable("Produtos");

            // definindo a coluna principal (primary key)
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            // mapeando as propriedades
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.DataValidade); // nem precisaria dessa linha
            
            builder.Property(x => x.PrecoCompra); // nem precisaria dessa linha

            builder.Property(x => x.PrecoVenda)
                .IsRequired();

            builder.Property(x => x.QuantidadeEstoque)
                .IsRequired();
        }
    }
}
