using Microsoft.EntityFrameworkCore;
using service_desk.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace service_desk.Data.Configuration
{
    public class LocalizacaoConfiguration : IEntityTypeConfiguration<LocalizacaoModel>
    {
        public void Configure(EntityTypeBuilder<LocalizacaoModel> builder)
        {
            builder.HasOne(p => p.Usuario).WithMany(p => p.Localizacaos).HasForeignKey(b => b.IdUsuario);
        }
    }
}
