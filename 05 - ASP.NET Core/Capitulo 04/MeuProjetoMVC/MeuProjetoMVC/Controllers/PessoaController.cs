using MeuProjetoMVC.BancoDeDados.Repositorio;
using MeuProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuProjetoMVC.Controllers
{
    public class PessoaController : Controller
    {
        public PessoaRepositorio Repositorio = new PessoaRepositorio();

        // Método chamado ao carregar a página "Pessoa/Listagem"
        public IActionResult Listagem()
        {
            var pessoas = Repositorio.ObterTodos();
            return View(pessoas);
        }

        // Método chamado ao carregar a página "Pessoa/Cadastro"
        public IActionResult Cadastro()
        {
            return View();
        }

        // Método chamado ao carregar a página "Pessoa/Edicao/1"
        public IActionResult Edicao(int id)
        {
            var pessoa = Repositorio.ObterPorId(id);
            return View(pessoa);
        }

        public IActionResult Adicionar(Pessoa pessoa)
        {
            if (pessoa.EstaValidoParaSalvar(ModelState))
            {
                // adicionar a pessoa na lista
                Repositorio.Adicionar(pessoa);
                return RedirectToAction("Listagem");
            } 
            else 
            {
                // quando há algum erro de validação
                return View("Cadastro", pessoa);
            }
        }

        public IActionResult Editar(Pessoa pessoa)
        {
            if (pessoa.EstaValidoParaSalvar(ModelState))
            {
                Repositorio.Atualizar(pessoa);
                return RedirectToAction("Listagem");
            }

            return View("Edicao", pessoa);
        }

        public IActionResult Excluir(int id)
        {
            Repositorio.Excluir(id);
            return RedirectToAction("Listagem");
        }
    }
}