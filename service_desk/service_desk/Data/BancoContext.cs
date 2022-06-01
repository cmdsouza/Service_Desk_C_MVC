using Microsoft.EntityFrameworkCore;
using service_desk.Models;

namespace service_desk.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

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
