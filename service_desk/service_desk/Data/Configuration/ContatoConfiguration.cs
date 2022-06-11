using Microsoft.EntityFrameworkCore;
using service_desk.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace service_desk.Data.Configuration
{
    public class ContatoConfiguration : IEntityTypeConfiguration<ContatoModel>
    {
        public void Configure(EntityTypeBuilder<ContatoModel> builder)
        {
            builder.HasOne(p => p.Usuario).WithMany(p => p.Contatos).HasForeignKey(b => b.IdUsuario);
            builder.HasOne(p => p.TipoContato).WithMany(p => p.Contatos).HasForeignKey(b => b.IdTipoContato);
        }
    }
}
