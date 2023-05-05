namespace Capitulo11.ExercicioExtra1
{
    internal class Program
    {
        /*
         Crie um projeto ConsoleApplication e implemente os seguintes requisitos. Seu projeto deverá:
        
            a. Conter classes de formas geométricas. (Formas sugeridas: Retângulo, Triângulo, Círculo)
            b. Cada forma geométrica deve implementar uma interface chamada 'IFormaGeometrica', que contém os métodos 'CalcularArea' e 'CalcularPerimetro'.
            c. Cada forma geométrica deve implementar os métodos da interface de acordo com as suas próprias características.
            d. O método principal deve cadastrar cada uma das formas geométricas criadas e atribui-las a uma lista da interface 'IFormaGeometrica'.
            e. O método principal deve imprimir na tela a área e o perímetro de cada forma geométrica cadastrada.
         */
        static void Main(string[] args)
        {
            var retangulo2 = new Retangulo();
            retangulo2.Base = 10;
            retangulo2.Altura = 20;
            retangulo2.CalcularArea();
            retangulo2.CalcularPerimetro();

            var circulo = new Circulo();
            circulo.Diametro = 10;
            circulo.CalcularArea();
            circulo.CalcularPerimetro();


            var triangulo = new Triangulo();
            triangulo.Lado = 5;
            triangulo.CalcularArea();
            triangulo.CalcularPerimetro();
        }
    }
}