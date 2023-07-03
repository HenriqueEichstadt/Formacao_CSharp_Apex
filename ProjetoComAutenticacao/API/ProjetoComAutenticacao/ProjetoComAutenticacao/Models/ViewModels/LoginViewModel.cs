namespace MeuProjetoApi.ViewModels;

public class LoginViewModel
{
    public string Token { get; set; }
    public DateTime DataExpiracao { get; set; }
    public string NomeUsuario { get; set; }
    public string Email { get; set; }
    public string TipoPerfil { get; set; }
    public int IdUsuario { get; set; }
}