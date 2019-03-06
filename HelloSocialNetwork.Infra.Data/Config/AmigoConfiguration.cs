using HelloSocialNetwork.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelloSocialNetwork.Infra.Data.Config
{
    public class AmigoConfiguration : IEntityTypeConfiguration<Amigo>
    {
        public void Configure(EntityTypeBuilder<Amigo> builder)
        {
            builder.HasKey(u => new {u.UsuarioId, u.UsuarioAmigoId});
        }
    }
}