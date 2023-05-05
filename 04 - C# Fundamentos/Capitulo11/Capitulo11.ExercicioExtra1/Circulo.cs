using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo11.ExercicioExtra1
{
    public class Circulo : IFiguraGeometrica
    {
        public int Diametro { get; set; }

        public void CalcularArea()
        {
            var raio = ObterRaio();
            var area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"A área do circulo é: {area}");
        }
        public void CalcularPerimetro()
        {
            var raio = ObterRaio();
            //C = 2 * π * r
            var perimetro = 2 * Math.PI * raio;
            Console.WriteLine($"O perímetro do circulo é: {perimetro}");
        }

        private int ObterRaio()
        {
            return Diametro / 2;
        }
    }
}
