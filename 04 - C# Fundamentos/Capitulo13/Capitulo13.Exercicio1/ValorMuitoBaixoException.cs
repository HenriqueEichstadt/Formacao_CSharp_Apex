using System.Runtime.Serialization;

namespace Capitulo13.Exercicio1
{
    [Serializable]
    internal class ValorMuitoBaixoException : Exception
    {
        public ValorMuitoBaixoException()
        {
        }

        public ValorMuitoBaixoException(string? message) : base(message)
        {
        }
    }
}