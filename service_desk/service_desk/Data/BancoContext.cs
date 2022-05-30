using Microsoft.EntityFrameworkCore;
using service_desk.Models;

namespace service_desk.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<AcompanhamentoModel> Acompanhamentos { get; set; }
        public DbSet<AlertaModel> Alertas { get; set; }
        public DbSet<AnexoModel> Anexos { get; set; }
        public DbSet<AvaliacaoModel> Avaliacaos { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<ChamadoModel> Chamados { get; set; }
        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<DocumentacaoModel> Documentacaos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
