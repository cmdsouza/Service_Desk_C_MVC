using Microsoft.EntityFrameworkCore.Migrations;

namespace service_desk.Migrations
{
    public partial class AcertoTabelaContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contato",
                table: "Contatos",
                newName: "Descricao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Contatos",
                newName: "Contato");
        }
    }
}
