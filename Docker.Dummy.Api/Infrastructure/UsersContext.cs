using Microsoft.EntityFrameworkCore;

namespace Docker.Dummy.Api.Infrastructure;

public class UsersContext : DbContext
{
    public DbSet<Users> Users { get; set; }

    public UsersContext(DbContextOptions<UsersContext> options)
       : base(options)
    { }

   
}
