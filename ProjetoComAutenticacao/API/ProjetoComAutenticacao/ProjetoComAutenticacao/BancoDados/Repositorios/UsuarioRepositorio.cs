using MeuProjetoApi.BancoDados.Contexto;
using MeuProjetoApi.Models;

namespace MeuProjetoApi.BancoDados.Repositorios;

public class UsuarioRepositorio
{
    public Usuario Adicionar(Usuario usuario)
    {
        using (var bancoDeDados = new MeuProjetoApiContexto())
        {
            bancoDeDados.TabelaUsuarios.Add(usuario);
            bancoDeDados.SaveChanges();
            return usuario;
        }
    }

    public Usuario Atualizar(Usuario usuario)
    {
        using (var bancoDeDados = new MeuProjetoApiContexto())
        {
            bancoDeDados.TabelaUsuarios.Update(usuario);
            bancoDeDados.SaveChanges();
            return usuario;
        }
    }

    public void Excluir(int id)
    {
        using (var bancoDeDados = new MeuProjetoApiContexto())
        {
            var usuario = bancoDeDados.TabelaUsuarios.Where(u => u.Id == id).FirstOrDefault();

            if (usuario != null)
            {
                bancoDeDados.Remove(usuario);
                bancoDeDados.SaveChanges();
            }
        }
    }

    public Usuario ObterPorId(int id)
    {
        using (var bancoDeDados = new MeuProjetoApiContexto())
        {
            var usuario = bancoDeDados.TabelaUsuarios.Where(u => u.Id == id).FirstOrDefault();
            return usuario;
        }
    }

    public List<Usuario> ObterTodos()
    {
        using (var bancoDeDados = new MeuProjetoApiContexto())
        {
            var listauUsuarios = bancoDeDados.TabelaUsuarios.ToList();
            return listauUsuarios;
        }
    }

    public bool ExiteUsuario(string email)
    {
        using (var bancoDeDados = new MeuProjetoApiContexto())
        {
            var usuario = bancoDeDados.TabelaUsuarios.Where(u => u.Email.ToLower() == email.ToLower()).FirstOrDefault();
            return usuario != null;
        }
    }
    
    public Usuario ObterPorNomeOuEmail(string nomeUsuarioOuEmail)
    {
        using (var bancoDeDados = new MeuProjetoApiContexto())
        {
            var usuario = bancoDeDados.TabelaUsuarios.Where(u => u.NomeUsuario.ToLower() == nomeUsuarioOuEmail.ToLower() 
                                                                 || u.Email.ToLower() == nomeUsuarioOuEmail.ToLower()).FirstOrDefault();
            return usuario;
        }
    }
}