using Capitulo11.Exercicio2.Objetos;

namespace Capitulo11.Exercicio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gato = new Gato();
            gato.CadastrarAnimal("branco");
            //gato.EmitirSom();



            var cachorro = new Cachorro();
            cachorro.CadastrarAnimal("preto");
            //cachorro.EmitirSom();

            var lista = new List<Animal>();
            lista.Add(gato);
            lista.Add(cachorro);

            foreach (var animal in lista)
            {
                animal.EmitirSom();
            }

        }
    }
}