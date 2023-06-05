using ExercicioExtra1.BancoDados.Contexto;
using ExercicioExtra1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExtra1.BancoDados.Repositorio
{
    public class PessoaRepositorio
    {
        public Pessoa Adicionar(Pessoa pessoa)
        {
            using (var bancoDados = new BancoDadosContext())
            {
                bancoDados.Pessoas.Add(pessoa);
                bancoDados.SaveChanges();
            }

            return pessoa;
        }
    }
}
