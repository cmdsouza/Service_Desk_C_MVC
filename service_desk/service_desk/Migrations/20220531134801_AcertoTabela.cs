using Microsoft.EntityFrameworkCore.Migrations;

namespace service_desk.Migrations
{
    public partial class AcertoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdTipoContati",
                table: "Contatos",
                newName: "IdTipoContato");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdTipoContato",
                table: "Contatos",
                newName: "IdTipoContati");
        }
    }
}
