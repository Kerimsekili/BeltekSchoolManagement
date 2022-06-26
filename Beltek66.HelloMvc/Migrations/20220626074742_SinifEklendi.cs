using Microsoft.EntityFrameworkCore.Migrations;

namespace Beltek66.HelloMvc.Migrations
{
    public partial class SinifEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sinifid",
                table: "tblOgrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sinif",
                columns: table => new
                {
                    Sinifid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sinifad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinif", x => x.Sinifid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblOgrenciler_Sinifid",
                table: "tblOgrenciler",
                column: "Sinifid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciler_Sinif_Sinifid",
                table: "tblOgrenciler",
                column: "Sinifid",
                principalTable: "Sinif",
                principalColumn: "Sinifid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciler_Sinif_Sinifid",
                table: "tblOgrenciler");

            migrationBuilder.DropTable(
                name: "Sinif");

            migrationBuilder.DropIndex(
                name: "IX_tblOgrenciler_Sinifid",
                table: "tblOgrenciler");

            migrationBuilder.DropColumn(
                name: "Sinifid",
                table: "tblOgrenciler");
        }
    }
}
