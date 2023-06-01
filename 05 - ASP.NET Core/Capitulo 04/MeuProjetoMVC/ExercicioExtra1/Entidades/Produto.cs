using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExtra1.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataValidade { get; set; }
        public decimal? PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal QuantidadeEstoque { get; set; }
    }
}
