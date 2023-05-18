using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo_22_23_24_25.Formularios_Validacoes.Objetos
{
    public partial class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public void Dormir()
        {
            EscovarDentes();
            Console.WriteLine("Dormiu");
        }
    }
}
