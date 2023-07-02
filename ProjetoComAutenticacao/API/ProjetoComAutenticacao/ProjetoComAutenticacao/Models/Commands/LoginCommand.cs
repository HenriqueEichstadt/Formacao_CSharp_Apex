namespace MeuProjetoApi.Models.Commands;

public class LoginCommand
{
    public string NomeUsuarioOuEmail { get; set; }
    public string Senha { get; set; }
}