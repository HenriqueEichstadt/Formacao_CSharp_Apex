using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo11.Exercicio2.Objetos
{
    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O cachorro emitiu som");
        }

        public override void CadastrarAnimal(string corPelo)
        {
            CorPelo = corPelo;
            Console.WriteLine($"Cadastrou cachorro com pelo {corPelo}");
        }
    }
}
