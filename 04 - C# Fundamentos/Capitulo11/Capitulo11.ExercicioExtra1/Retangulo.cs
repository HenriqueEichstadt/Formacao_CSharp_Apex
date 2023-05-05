using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo11.ExercicioExtra1
{
    public class Retangulo : IFiguraGeometrica
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public void CalcularArea()
        {
            var area = Base * Altura;
            Console.WriteLine($"A área do retangulo é: {area}");
        }
        public void CalcularPerimetro()
        {
            var perimetro = (Base * 2) + (Altura * 2);
            Console.WriteLine($"O perímetro do retangulo é: {perimetro}");
        }
    }
}
