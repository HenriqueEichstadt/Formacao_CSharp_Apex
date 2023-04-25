using System.Net;

namespace Capitulo7.Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if
            string linguagem = "aaaa";

            if(linguagem == "python")
            {
                Console.WriteLine("Estou programando em python");
            }
            else if (linguagem == "java")
            {
                Console.WriteLine("Estou programando em java");
            }
            else if (linguagem == "c#")
            {
                Console.WriteLine("Estou programando em c#");
            }
            else
            {
                Console.WriteLine("OPS!");
            }

            // Comando Switch

            switch(linguagem)
            {
                case "python":
                    Console.WriteLine("Estou programando em python");
                    break;
                case "java":
                    Console.WriteLine("Estou programando em java");
                    break;
                case "c#":
                    Console.WriteLine("Estou programando em c#");
                    break;
                default:
                    Console.WriteLine("OPS!");
                    break;

            }
        }
    }
}