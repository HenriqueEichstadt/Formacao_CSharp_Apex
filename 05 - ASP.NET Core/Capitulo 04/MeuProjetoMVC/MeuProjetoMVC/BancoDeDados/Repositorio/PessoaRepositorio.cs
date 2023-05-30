using MeuProjetoMVC.BancoDeDados.Contexto;
using MeuProjetoMVC.Models;

namespace MeuProjetoMVC.BancoDeDados.Repositorio
{
    public class PessoaRepositorio
    {

        public Pessoa Adicionar(Pessoa pessoa)
        {
            using(var bancoDados = new BancoDeDadosContext())
            {
                bancoDados.Pessoas.Add(pessoa);
                bancoDados.SaveChanges();
            }

            return pessoa;
        }

        public Pessoa Atualizar(Pessoa pessoa)
        {
            using (var bancoDados = new BancoDeDadosContext())
            {
                bancoDados.Pessoas.Update(pessoa);
                bancoDados.SaveChanges();
            }

            return pessoa;
        }

        public void Excluir(int id)
        {
            using (var bancoDados = new BancoDeDadosContext())
            {
                var pessoa = bancoDados.Pessoas
                    .Where(pessoa => pessoa.Id == id)
                    .FirstOrDefault();

                if(pessoa != null)
                {
                    bancoDados.Remove(pessoa);
                    bancoDados.SaveChanges();
                }
            }
        }

        public Pessoa ObterPorId(int id)
        {
            using (var bancoDados = new BancoDeDadosContext())
            {
                var pessoa = bancoDados.Pessoas
                    .Where(pessoa => pessoa.Id == id)
                    .FirstOrDefault();

                return pessoa;
            }
        }

        public List<Pessoa> ObterTodos()
        {
            using (var bancoDados = new BancoDeDadosContext())
            {
                var pessoas = bancoDados.Pessoas.ToList();
                return pessoas;
            }
        }

    }
}
