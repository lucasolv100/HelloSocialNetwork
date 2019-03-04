using HelloSocialNetwork.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HelloSocialNetwork.Infra.Data.Context
{
    public class HelloSocialNetworkContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public HelloSocialNetworkContext(DbContextOptions options) : base(options)
        {

        }
    }
}