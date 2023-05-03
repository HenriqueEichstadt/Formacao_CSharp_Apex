using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo11.OrientacaoObjetos.Objetos
{
    public class Professor : Pessoa
    {
        public override void Pensar()
        {
            Console.WriteLine("Professor pensou");
        }
    }
}
