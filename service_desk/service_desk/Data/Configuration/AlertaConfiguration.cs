using Microsoft.EntityFrameworkCore;
using service_desk.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace service_desk.Data.Configuration
{
    public class AlertaConfiguration : IEntityTypeConfiguration<AlertaModel>
    {
        public void Configure(EntityTypeBuilder<AlertaModel> builder)
        {
            builder.HasOne(p => p.Usuario).WithMany(p => p.Alertas).HasForeignKey(b => b.IdUsuario);
        }
    }
}
