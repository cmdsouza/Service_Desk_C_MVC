using Microsoft.EntityFrameworkCore;
using service_desk.Data.Configuration;
using service_desk.Models;

namespace service_desk.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlertaConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoriaConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContatoConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DocumentacaoConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContatoConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LocalizacaoConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AlertaModel> Alertas { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<DocumentacaoModel> Documentacaos { get; set; }
        public DbSet<LocalizacaoModel> Localizacaos { get; set; }
        public DbSet<TipoContatoModel> TipoContatos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
