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
        [Route("pessoa/obter")]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult Obter()
        {
            try
            {
                var pessoa = new Pessoa();
                pessoa.Id = 1;
                pessoa.Nome = "Zé";
                pessoa.Cpf = "000.000.000-00";
                pessoa.Email = "ze@gmail.com";
                pessoa.Telefone = "(47) 99874-5632";

                return Ok(pessoa);

            } catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

        [HttpPost]
        [Route("pessoa/adicionar")]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult Adicionar()
        {
            return Created(null);
        }



    }
}
