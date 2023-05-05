using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo11.OrientacaoObjetos.Helpers
{
    public static class Helper
    {
        public static string FormatarCpf(string cpf)
        {
            var cpfFormatado = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
            return cpfFormatado;
        }



    }
}
