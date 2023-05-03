using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo11.Exercicio2.Objetos
{
    public abstract class Animal
    {
        public string CorPelo { get; protected set; }

        public abstract void EmitirSom();
        public abstract void CadastrarAnimal(string corPelo);
    }
}
