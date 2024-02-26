using Microsoft.AspNetCore.Identity;

namespace ironbody.academias.Domain.Entities.Account;
public class Users : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
}
