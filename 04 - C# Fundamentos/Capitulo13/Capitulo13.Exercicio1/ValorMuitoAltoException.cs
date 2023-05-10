using System.Runtime.Serialization;

namespace Capitulo13.Exercicio1
{
    [Serializable]
    internal class ValorMuitoAltoException : Exception
    {
        public ValorMuitoAltoException()
        {
        }

        public ValorMuitoAltoException(string? message) : base(message)
        {
        }
    }
}