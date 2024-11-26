using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwissMex.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "Title" },
                values: new object[] { 1, "Diámetro de conexión: Entrada 3\" y Salida 3\".\r\nRoca de conexión: Externa tubular.\r\nAltura total de descarga: 28 m.\r\nAltura de succión: 6 m.\r\nCaudal: 750 L./min.\r\nPotencia: 7 CV / 208 cc.\r\nArranque: Cordón retráctil.\r\nPresión: Normal / Basura.\r\nSensor de aceite: No.\r\nDimensiones: 530/430/440 mm.\r\nPeso aproximado: 36 Kg.", "Equipo de Riego PRWP30T - Entrada 3\" y Salida 3\"" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoryId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Diámetro de conexión: Entrada 3 \"y Salida 3\".\r\nRoca de conexión: Externa tubular.\r\nAltura total de descarga: 28 m.\r\nAltura de succión: 6 m.\r\nCaudal: 750 L./min.\r\nPotencia: 7 CV / 208 cc.\r\nArranque: Cordón retráctil.\r\nPresión: Normal / Basura.\r\nSensor de aceite: No.\r\nDimensiones: 530/430/440 mm.\r\nPeso aproximado: 36 Kg.", "Equipo de Riego PRWP30T - Entrada 3 y Salida 3" });
        }
    }
}
