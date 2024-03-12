using System.ComponentModel.DataAnnotations;

namespace ironbody.academias.Application.Models.Account;

public class UserViewModel
{
    [Required, Display(Name = "Primeiro nome")]
    public string? FirstName { get; set; }

    [Required, Display(Name = "Ultimo nome")]
    public string? LastName { get; set; }

    [Required, Display(Name = "E-mail")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    public string? Email { get; set; }

    [Required, Display(Name = "Nome de usuário")]
    public string? UserName { get; set; }

    [Required, Display(Name = "Senha")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Required, Display(Name = "Confirm a senha")]
    [DataType(DataType.Password), Compare("Password")]
    public string? ConfirmPassword { get; set; }
}
