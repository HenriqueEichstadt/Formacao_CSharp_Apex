using Capitulo11.OrientacaoObjetos.Objetos;
using System.Text.RegularExpressions;
using System;
using Capitulo11.OrientacaoObjetos.Interfaces;
using Capitulo11.OrientacaoObjetos.Helpers;

namespace Capitulo11.OrientacaoObjetos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Aluno meuAluno = new Aluno();
            meuAluno.Nome = "João";
            meuAluno.Cpf = "000.000.000-00";
            meuAluno.Rg = 7982346;
            meuAluno.DataNascimento = new DateTime(1985, 12, 31);
            meuAluno.Peso = 85.2;

            Aluno aluno2 = new Aluno()
            {
                Nome = "Maria",
                Cpf = "000.000.000-00",
                Rg = 7982346,
                DataNascimento = new DateTime(1985, 12, 31),
                Peso = 85.2,
            };

            Pessoa pessoa3 = new Pessoa("Maria", "000.000.000-00", 7982346);


            meuAluno.Comer("churrasco");
            Console.WriteLine(meuAluno);

            // ------
            // Herança

            Pessoa aluno = new Aluno();
            aluno.Nome = "Zé";
            aluno.Comer("Fini");
            aluno.Pensar();

            Pessoa pessoa = new Professor();
            pessoa.Pensar();


            var alunoNovo = new Aluno();


            IContaBancaria conta = new ContaCorrente();
            conta.Sacar(100);


            var aluno10 = new Aluno();
            aluno10.Cpf = "kjashdjk";
            aluno10.Dormir();

            //aluno10.FormatarCpf();


            var cpfFormatado = Helper.FormatarCpf("12345678900");

            Console.WriteLine("CPF Formatado: " + cpfFormatado);


        }
    }
}