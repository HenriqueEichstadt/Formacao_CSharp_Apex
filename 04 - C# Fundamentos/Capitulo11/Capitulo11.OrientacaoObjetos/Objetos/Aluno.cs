using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo11.OrientacaoObjetos.Objetos
{
    // O aluno é uma pessoa, só que mais específica
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public string Escola { get; set; }

        public void AssistirAula()
        {
            this.MatarAula();
            Console.WriteLine("Assistiu aula de Orientação a objetos");
        }

        public void MatarAula()
        {
            Console.WriteLine($"O aluno {this.Nome} matou aula");
        }

        public void MatarAula(int quantidadeAulas)
        {
            Console.WriteLine($"O aluno {this.Nome} matou {quantidadeAulas} aula");
        }

        public override void Pensar()
        {
            Console.WriteLine("Aluno pensou!");
        }
    }
   
}
