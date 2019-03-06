using HelloSocialNetwork.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelloSocialNetwork.Infra.Data.Config
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                    .IsRequired()
                    .HasMaxLength(150);

            builder.Property(u => u.Descricao)
                    .IsRequired()
                    .HasMaxLength(500);

            builder.Property(u => u.UrlFoto)
                    .IsRequired(false)
                    .HasMaxLength(150);

            builder.HasMany(u => u.Postagens).WithOne(p => p.Grupo);
        }
    }
}