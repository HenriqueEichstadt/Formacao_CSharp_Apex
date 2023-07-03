using System.Net;
using MeuProjetoApi.BancoDados.Repositorios;
using MeuProjetoApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MeuProjetoApi.Controllers;

    [ApiController]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        public UsuarioRepositorio Repositorio = new UsuarioRepositorio();

        [HttpGet]
        [Route("usuario/obterTodos")]
        [ProducesResponseType(typeof(List<Usuario>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult ObterTodos()
        {
            try
            {
                var todosUsuarios = Repositorio.ObterTodos();
                return Ok(todosUsuarios);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

        [HttpGet]
        [Route("usuario/obterPorId/{id}")]
        [ProducesResponseType(typeof(Usuario), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var usuario = Repositorio.ObterPorId(id);

                if (usuario == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(usuario);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

        [HttpPost]
        [Route("usuario/adicionar")]
        [ProducesResponseType(typeof(Usuario), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult Adicionar([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario == null)
                {
                    return BadRequest("Não foi possível obter o usuário");
                }
                
                if (Repositorio.ObterPorNomeOuEmail(usuario.NomeUsuario) != null)
                {
                    return BadRequest("Já existe um usuário com o mesmo nome");
                }

                if (Repositorio.ObterPorNomeOuEmail(usuario.Email) != null)
                {
                    return BadRequest("Já existe um usuário com o mesmo e-mail");
                }
                
                Repositorio.Adicionar(usuario);

                return Created($"", usuario);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

        [HttpPut]
        [Route("usuario/atualizar")]
        [ProducesResponseType(typeof(Usuario), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult Atualizar([FromBody] Usuario usuario)
        {
            try
            {
                Usuario usuarioAtualizar = Repositorio.ObterPorId(usuario.Id);

                if (usuarioAtualizar == null)
                {
                    return NotFound("Não foi possível encontrar o usuário");
                }
                else
                {
                    usuarioAtualizar.NomeUsuario = usuario.NomeUsuario;
                    usuarioAtualizar.Email = usuario.Email;
                    usuarioAtualizar.Senha = usuario.Senha;
                    usuarioAtualizar.Ativo = usuario.Ativo;
                    usuarioAtualizar.Tipo = usuario.Tipo;
                    
                    Repositorio.Atualizar(usuarioAtualizar);
                    return Ok(usuarioAtualizar);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }
        
        [HttpPut]
        [Route("usuario/alterarStatus/{id}")]
        [ProducesResponseType(typeof(Usuario), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult AlterarStatus(int id)
        {
            try
            {
                Usuario usuarioAtualizar = Repositorio.ObterPorId(id);

                if (usuarioAtualizar == null)
                {
                    return NotFound("Não foi possível encontrar o usuário");
                }

                usuarioAtualizar.Ativo = !usuarioAtualizar.Ativo;
                Repositorio.Atualizar(usuarioAtualizar);
                return Ok(usuarioAtualizar);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

    }