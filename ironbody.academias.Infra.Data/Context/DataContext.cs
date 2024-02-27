using ironbody.academias.Domain.Entities.Account;
using ironbody.academias.Infra.Data.DataConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ironbody.academias.Infra.Data.Context;
public class DataContext : IdentityDbContext<Users>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Users>(new UsersConfiguration().Configure);
        // Esta linha está configurando o modelo para a entidade Users usando a classe UsersConfiguration.
        // A classe UsersConfiguration deve ter um método Configure que define as configurações para a entidade Users, como as propriedades da entidade e suas restrições.
        base.OnModelCreating(builder);
    }
}
