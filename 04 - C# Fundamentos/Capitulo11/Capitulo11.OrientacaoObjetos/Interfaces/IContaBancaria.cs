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
        void Depositarr(double valor);
        void Transferir(double valor, string numeroContaDestino);
    }


    // se fosse em classe abstrata
    /*
     public abstract class ContaBancaria
    {
        public abstract double Sacar(double valorAAsacar);
        public abstract void Depositarr(double valor);
        public abstract void Transferir(double valor, string numeroContaDestino);
    }
    */
}
