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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Users>(new UsersConfiguration().Configure);
        base.OnModelCreating(modelBuilder);
    }
}
