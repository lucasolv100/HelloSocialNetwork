using HelloSocialNetwork.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelloSocialNetwork.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                    .IsRequired()
                    .HasMaxLength(150);

            builder.Property(u => u.Senha)
                    .IsRequired()
                    .HasMaxLength(20);

            builder.Property(u => u.SobreNome)
                    .IsRequired()
                    .HasMaxLength(150);

            builder.Property(u => u.UrlFoto)
                    .IsRequired(false)
                    .HasMaxLength(150);

            builder.Property(u => u.Sexo)
                    .IsRequired();
            
            builder.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(150);

            builder.HasOne(u => u.Identificacao)
                   .WithOne(i => i.Usuario)
                   .HasForeignKey<Identificacao>(u => u.UsuarioId);

            builder.HasMany(u => u.Amigos).WithOne(a => a.Usuario);
            builder.HasMany(u => u.Postagens).WithOne(p => p.Usuario);
            builder.HasMany(u => u.UsuarioGrupos).WithOne(p => p.Usuario);
            builder.HasOne(u => u.StatusRelacionamento);
            builder.HasOne(u => u.ProcurandoPor);
        }
    }
}