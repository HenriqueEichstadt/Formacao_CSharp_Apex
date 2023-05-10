namespace Capitulo13.TratamentoErros
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            // o C#/.NET deve tentar executar:

            try
            {
                Console.WriteLine("Insira um número (divisor)");
                var divisor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira um número (dividendo)");
                var dividendo = Convert.ToInt32(Console.ReadLine());

                if (dividendo == 0)
                {
                    throw new DivisaoPorZeroCustomizadaException("Não é possível dividir por zero");
                }

                var resultado = divisor / dividendo;
                Console.WriteLine("O resultado da divisão é: " + resultado);


                //Carro carro = null; //new Carro();
                //carro.Marca = "VW";


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ocorreu o erro de divisão por zero. " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Ocorreu o erro de null reference. " + ex.StackTrace);
            }
            catch (DivisaoPorZeroCustomizadaException ex)
            {
                Console.WriteLine("exception criada. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("(Exception) Ocorreu o erro de divisão por zero. " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Fechando conexão com banco de dados");
            }

            Console.WriteLine("Fechando conexão com banco de dados");


            Console.ReadKey();
        }
    }
}