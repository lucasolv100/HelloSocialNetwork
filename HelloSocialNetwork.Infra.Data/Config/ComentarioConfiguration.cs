using HelloSocialNetwork.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelloSocialNetwork.Infra.Data.Config
{
    public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Texto)
                    .IsRequired()
                    .HasMaxLength(500);

            builder.Property(u => u.DataPublicacao)
                    .IsRequired();
                    
            builder.HasOne(c => c.Usuario).WithMany(u => u.Comentarios);
        }
    }
}