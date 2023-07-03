using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using MeuProjetoApi.BancoDados.Repositorios;
using MeuProjetoApi.Models;
using MeuProjetoApi.Models.Commands;
using MeuProjetoApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace MeuProjetoApi.Controllers;

[ApiController]
public class AutenticacaoController : ControllerBase
{
    private UsuarioRepositorio Repositorio = new UsuarioRepositorio();

    private static TimeSpan TempoValidarToken = TimeSpan.FromHours(2);
    
    [HttpPost]
    [Route("autenticacao/login")]
    [ProducesResponseType(typeof(LoginViewModel), (int)HttpStatusCode.Created)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
    public IActionResult Login([FromBody] LoginCommand loginCommand)
    {
        try
        {
            var usuario = Repositorio.ObterPorNomeOuEmail(loginCommand.NomeUsuarioOuEmail);

            if (usuario == null || usuario.Senha != loginCommand.Senha)
            {
                return BadRequest("Usuário ou senha inválidos");
            }

            if (usuario.Ativo == false)
            {
                return BadRequest("Usuário inativo");
            }
            
            var authClaims = new List<Claim>
            {
                new Claim("id", usuario.Id.ToString()),
                new Claim("nomeUsuario", usuario.NomeUsuario.ToString()),
                new Claim("email", usuario.Email.ToString()),
                new Claim("jti", Guid.NewGuid().ToString()),
            };
            
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("StrONGKAutHENTICATIONKEy"));

            var token = new JwtSecurityToken(
                issuer: "Any",
                audience: "Any",
                expires: DateTime.Now.Add(TempoValidarToken),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );
            
            var loginViewModel = new LoginViewModel()
            {
                Token = "Bearer " + new JwtSecurityTokenHandler().WriteToken(token),
                DataExpiracao = token.ValidTo,
                NomeUsuario = usuario.NomeUsuario,
                Email = usuario.Email,
                TipoPerfil = usuario.Tipo,
                IdUsuario = usuario.Id
            };

            return Ok(loginViewModel);
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
        }
    }
    
    [HttpGet("autenticacao/usuarioExiste/{email}")]
    [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
    public IActionResult UsuarioExiste(string email)
    {
        try
        {
            var existe = Repositorio.ExiteUsuario(email);
            if (existe)
            {
                return Ok("Usuário cadastrado");
            }
            else
            {
                return NotFound("Usuario não encontrado");
            }
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
        }
    }

}