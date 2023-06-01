using ExercicioExtra1.BancoDados.Contexto;
using ExercicioExtra1.Entidades;

namespace ExercicioExtra1.BancoDados.Repositorio
{
    public class ProdutoRepositorio
    {
        public Produto Adicionar(Produto produto)
        {
            using (var bancoDados = new BancoDadosContext())
            {
                bancoDados.Produtos.Add(produto);
                bancoDados.SaveChanges();
            }

            return produto;
        }

        public Produto Atualizar(Produto produto)
        {
            using (var bancoDados = new BancoDadosContext())
            {
                bancoDados.Produtos.Update(produto);
                bancoDados.SaveChanges();
            }

            return produto;
        }

        public void Excluir(int id)
        {
            using (var bancoDados = new BancoDadosContext())
            {
                var produto = bancoDados.Produtos
                    .Where(produto => produto.Id == id)
                    .FirstOrDefault();

                if (produto != null)
                {
                    bancoDados.Remove(produto);
                    bancoDados.SaveChanges();
                }
            }
        }

        public Produto ObterPorId(int id)
        {
            using (var bancoDados = new BancoDadosContext())
            {
                var produto = bancoDados.Produtos
                    .Where(produto => produto.Id == id)
                    .FirstOrDefault();

                return produto;
            }
        }

        public List<Produto> ObterTodos()
        {
            using (var bancoDados = new BancoDadosContext())
            {
                var produtos = bancoDados.Produtos.ToList();
                return produtos;
            }
        }
    }
}
