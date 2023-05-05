namespace Capitulo11.ExercicioExtra1
{
    public class Triangulo : IFiguraGeometrica
    {
        public int Lado { get; set; }

        public void CalcularArea()
        {
            // multiplicamos o quadrado da medida do lado pela raiz de 3 dividido por 4
            var area = (Lado * Lado * Math.Sqrt(3)) / 4;
            Console.WriteLine($"A área do triangulo equilátero é: {area}");
        }
        public void CalcularPerimetro()
        {
            var perimetro = Lado * 3;
            Console.WriteLine($"O perímetro do triangulo equilátero é: {perimetro}");
        }
    }
}