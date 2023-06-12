using MeuProjetoApi.BancoDados.Contexto;
using MeuProjetoApi.Models;

namespace MeuProjetoApi.BancoDados.Repositorios
{
    public class PessoaRepositorio
    {
        public Pessoa Adicionar(Pessoa pessoa)
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                bancoDeDados.TabelaPessoas.Add(pessoa);
                bancoDeDados.SaveChanges();
            }

            return pessoa;
        }

        public Pessoa Atualizar(Pessoa pessoa)
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                bancoDeDados.TabelaPessoas.Update(pessoa);
                bancoDeDados.SaveChanges();
            }

            return pessoa;
        }

        public void Excluir(int id)
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                var pessoa = bancoDeDados.TabelaPessoas
                    .Where(pessoa => pessoa.Id == id)
                    .FirstOrDefault();

                if (pessoa != null)
                {
                    bancoDeDados.Remove(pessoa);
                    bancoDeDados.SaveChanges();
                }
            }
        }

        public Pessoa ObterPorId(int id)
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                var pessoa = bancoDeDados.TabelaPessoas
                    .Where(pessoa => pessoa.Id == id)
                    .FirstOrDefault();

                return pessoa;
            }
        }

        public List<Pessoa> ObterTodos()
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                var listaPessoas = bancoDeDados.TabelaPessoas.ToList();
                return listaPessoas;
            }
        }
    }
}
