using Microsoft.EntityFrameworkCore.Migrations;

namespace WypozyczalniaFilmow.Migrations
{
    public partial class trecia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DlFilmu",
                table: "Filmy",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1,
                column: "DlFilmu",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                column: "DlFilmu",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 3,
                column: "DlFilmu",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 4,
                column: "DlFilmu",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 5,
                column: "DlFilmu",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 6,
                column: "DlFilmu",
                value: 125);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 7,
                column: "DlFilmu",
                value: 124);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 8,
                column: "DlFilmu",
                value: 123);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 9,
                column: "DlFilmu",
                value: 122);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 10,
                column: "DlFilmu",
                value: 121);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DlFilmu",
                table: "Filmy");
        }
    }
}
