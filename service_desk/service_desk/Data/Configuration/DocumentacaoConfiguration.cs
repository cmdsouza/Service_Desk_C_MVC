using Microsoft.EntityFrameworkCore;
using service_desk.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace service_desk.Data.Configuration
{
    public class DocumentacaoConfiguration : IEntityTypeConfiguration<DocumentacaoModel>
    {
        public void Configure(EntityTypeBuilder<DocumentacaoModel> builder)
        {
            builder.HasOne(p => p.Usuario).WithMany(p => p.Documentacaos).HasForeignKey(b => b.IdUsuario);
        }
    }
}
