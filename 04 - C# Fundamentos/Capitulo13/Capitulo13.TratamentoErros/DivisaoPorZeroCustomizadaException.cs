using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo13.TratamentoErros
{
    public class DivisaoPorZeroCustomizadaException : Exception
    {
        public DivisaoPorZeroCustomizadaException() : base()
        {

        }

        public DivisaoPorZeroCustomizadaException(string mensagem) : base(mensagem)
        {

        }
    }
}
