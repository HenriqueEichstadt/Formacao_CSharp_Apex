using System.Drawing;

namespace Capitulo13.Exercicio1
{
    public class Program
    {
        /*
         Implemente o seguinte:
            a. Em seu método principal faça um loop que vai de zero até um número digitado pelo usuário.
            b. Se o número passado for menor que 10, exiba uma exception criada por você chamada
                “ValorMuitoBaixoException” com a mensagem “Ops, assim não é divertido”.
            c. Se o valor for maior que 10.000 exiba “ValorMuitoAltoException”, com a mensagem “Ops,
                muita coisa - vai com calma”.
            d. Caso não esteja nessa validação, exiba uma contagem de zero até o valor passado.
            e. Caso valor passado não seja um inteiro exiba uma exceção genérica.
         */
        public static void Main(string[] args)
        {
            try
            {
                //a
                Console.WriteLine("Digite a quantidade de repetições");
                var input = Console.ReadLine(); //João

                long quantidadeRepeticoes = 0;
                if (!long.TryParse(input, out quantidadeRepeticoes))
                {
                    throw new Exception("Uma exceção genérica");
                }

                //b
                if (quantidadeRepeticoes < 10)
                {
                    throw new ValorMuitoBaixoException("Ops, assim não é divertido");
                }

                //c
                if (quantidadeRepeticoes > 10000)
                {
                    throw new ValorMuitoAltoException("Ops, muita coisa - vai com calma");
                }

                //d
                for (int i = 0; i < quantidadeRepeticoes; i++)
                {
                    Console.WriteLine($"Contador: {i}");
                }


            }
            catch (ValorMuitoBaixoException ex)
            {
                Console.WriteLine("Lançou a exception ValorMuitoBaixoException: " + ex.Message);
            }
            catch (ValorMuitoAltoException ex)
            {
                Console.WriteLine("Lançou a exception ValorMuitoAltoException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lançou a exception Exception: " + ex.Message);
            }
            

        }
    }
}