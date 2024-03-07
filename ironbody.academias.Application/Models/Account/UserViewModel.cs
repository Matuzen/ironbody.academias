using System.ComponentModel.DataAnnotations;

namespace ironbody.academias.Application.Models.Account;

public class UserViewModel
{
    [Display(Name = "Primeiro nome")]
    public string? FirstName { get; set; }

    [Display(Name = "Ultimo nome")]
    public string? LastName { get; set; }

    public string? Email { get; set; }

    [Display(Name = "Nome de usuário")]
    public string? UserName { get; set; }

    [Display(Name = "Senha")]
    public string? Password { get; set; }

    [Display(Name = "Confirm a senha")]
    public string? ConfirmPassword { get; set; }
}
