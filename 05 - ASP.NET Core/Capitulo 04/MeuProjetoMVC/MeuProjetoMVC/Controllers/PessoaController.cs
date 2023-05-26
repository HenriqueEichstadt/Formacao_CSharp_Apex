using MeuProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuProjetoMVC.Controllers
{
    public class PessoaController : Controller
    {
        public static List<Pessoa> Pessoas = new List<Pessoa>()
        {
            new Pessoa() { Id = 1, Nome = "Zé", Cpf = "111.111.111-11", Email = "ze@gmail.com"},
            new Pessoa() { Id = 2, Nome = "João", Cpf = "222.222.222-22", Email = "joao@gmail.com"},
            new Pessoa() { Id = 3, Nome = "Maria", Cpf = "333.333.333-33", Email = "maria@gmail.com"},
        };

        // Método chamado ao carregar a página "Pessoa/Listagem"
        public IActionResult Listagem()
        {
            return View(Pessoas);
        }

        // Método chamado ao carregar a página "Pessoa/Cadastro"
        public IActionResult Cadastro()
        {
            return View();
        }

        // Método chamado ao carregar a página "Pessoa/Edicao/id"
        public IActionResult Edicao(int id)
        {
            var pessoa = Pessoas.Where(p => p.Id == id).FirstOrDefault();
            return View(pessoa);
        }

        public IActionResult Adicionar(Pessoa pessoa)
        {
            if (pessoa.EstaValidoParaSalvar(ModelState))
            {
                // adicionar a pessoa na lista
                Pessoas.Add(pessoa);
                return RedirectToAction("Listagem");
            } 
            else 
            {
                // quando há algum erro de validação
                return View("Cadastro", pessoa);
            }
        }

        public ActionResult Editar(Pessoa pessoa)
        {
            if (pessoa.EstaValidoParaSalvar(ModelState))
            {
                Pessoas.RemoveAll(p => p.Id == pessoa.Id);
                Pessoas.Add(pessoa);

                return RedirectToAction("Listagem");
            }

            return View("Edicao", pessoa);
        }
    }
}
