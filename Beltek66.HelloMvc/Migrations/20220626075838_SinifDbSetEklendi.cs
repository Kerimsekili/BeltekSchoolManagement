using Microsoft.EntityFrameworkCore.Migrations;

namespace Beltek66.HelloMvc.Migrations
{
    public partial class SinifDbSetEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciler_Sinif_Sinifid",
                table: "tblOgrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sinif",
                table: "Sinif");

            migrationBuilder.RenameTable(
                name: "Sinif",
                newName: "Siniflar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Siniflar",
                table: "Siniflar",
                column: "Sinifid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciler_Siniflar_Sinifid",
                table: "tblOgrenciler",
                column: "Sinifid",
                principalTable: "Siniflar",
                principalColumn: "Sinifid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciler_Siniflar_Sinifid",
                table: "tblOgrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Siniflar",
                table: "Siniflar");

            migrationBuilder.RenameTable(
                name: "Siniflar",
                newName: "Sinif");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sinif",
                table: "Sinif",
                column: "Sinifid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciler_Sinif_Sinifid",
                table: "tblOgrenciler",
                column: "Sinifid",
                principalTable: "Sinif",
                principalColumn: "Sinifid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
