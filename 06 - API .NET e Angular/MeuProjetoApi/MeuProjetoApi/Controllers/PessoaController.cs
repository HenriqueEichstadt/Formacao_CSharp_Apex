using MeuProjetoApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MeuProjetoApi.Controllers
{
    [ApiController]
    public class PessoaController : ControllerBase
    {
        public static List<Pessoa> ListaPessoas = new List<Pessoa>()
        {
            new Pessoa() { Id = 1, Nome = "Zé", Cpf = "000.000.000-00", Email = "ze@gmail.com", Telefone = "(47) 99874-5632" },
        };


        [HttpGet]
        [Route("pessoa/obterTodos")]
        [ProducesResponseType(typeof(List<Pessoa>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult ObterTodos()
        {
            try
            {
                return Ok(ListaPessoas);

            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

        [HttpGet]
        [Route("pessoa/obterPorId/{id}")]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var pessoa = ListaPessoas
                    .Where(pessoa => pessoa.Id == id)
                    .FirstOrDefault();

                if(pessoa == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(pessoa);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

        [HttpPost]
        [Route("pessoa/adicionar")]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult Adicionar([FromBody] Pessoa pessoa)
        {
            try
            {
                if (pessoa == null)
                {
                    return BadRequest("Não foi possível obter a pessoa");
                }

                ListaPessoas.Add(pessoa);

                return Created("", pessoa);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

        [HttpPut]
        [Route("pessoa/atualizar")]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult Atualizar([FromBody] Pessoa pessoa)
        {
            try
            {
                Pessoa pessoaAtualizar = ListaPessoas
                    .Where(p => p.Id == pessoa.Id)
                    .FirstOrDefault();

                if (pessoaAtualizar == null)
                {
                    return NotFound("Não foi possível encontrar a pessoa");
                }
                else
                {
                    //pessoaAtualizar.Id = 1;
                    pessoaAtualizar.Nome = pessoa.Nome;
                    pessoaAtualizar.Cpf = pessoa.Cpf;
                    pessoaAtualizar.Email = pessoa.Email;
                    pessoaAtualizar.Telefone = pessoa.Telefone;

                    return Ok(pessoaAtualizar);

                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }



        }
    }
}
