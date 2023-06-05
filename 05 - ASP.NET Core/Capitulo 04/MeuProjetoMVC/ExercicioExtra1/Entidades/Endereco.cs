using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExtra1.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
