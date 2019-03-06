using HelloSocialNetwork.Domain.Entities;
using HelloSocialNetwork.Infra.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace HelloSocialNetwork.Infra.Data.Context
{
    public class HelloSocialNetworkContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }

        public HelloSocialNetworkContext (DbContextOptions options) : base (options)
        {

        }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioGrupoConfiguration());
            
            base.OnModelCreating (modelBuilder);
        }
    }
}