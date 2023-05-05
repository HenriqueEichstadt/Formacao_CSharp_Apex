using Capitulo11.OrientacaoObjetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo11.OrientacaoObjetos.Objetos
{
    public class ContaCorrente : IContaBancaria
    {
        public void Depositarr(double valor)
        {
            Console.WriteLine($"Depositou {valor}");
        }

        public double Sacar(double valorAAsacar)
        {
            Console.WriteLine($"Sacou {valorAAsacar}");
            return valorAAsacar;
        }

        public void Transferir(double valor, string numeroContaDestino)
        {
            Console.WriteLine($"Transferiu {valor} para {numeroContaDestino}");
        }
    }
}
