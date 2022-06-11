using Microsoft.EntityFrameworkCore;
using service_desk.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace service_desk.Data.Configuration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<CategoriaModel>
    {
        public void Configure(EntityTypeBuilder<CategoriaModel> builder)
        {
            builder.HasOne(p => p.Usuario).WithMany(p => p.Categorias).HasForeignKey(b => b.IdUsuario);
        }
    }
}
