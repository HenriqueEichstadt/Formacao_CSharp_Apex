using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo11.OrientacaoObjetos.Interfaces
{
    public interface IContaBancaria
    {
        double Sacar(double valorAAsacar);
        void Depositar(double valor);
        void Transferir(double valor, string numeroContaDestino);
    }
}
