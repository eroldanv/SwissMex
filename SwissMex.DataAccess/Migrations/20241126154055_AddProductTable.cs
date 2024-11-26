using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SwissMex.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price25 = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Siembra");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Cosecha");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Aspersión");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "ListPrice", "PartNumber", "Price", "Price25", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "POWERAC", "Diámetro de conexión: Entrada 3 \"y Salida 3\".\r\nRoca de conexión: Externa tubular.\r\nAltura total de descarga: 28 m.\r\nAltura de succión: 6 m.\r\nCaudal: 750 L./min.\r\nPotencia: 7 CV / 208 cc.\r\nArranque: Cordón retráctil.\r\nPresión: Normal / Basura.\r\nSensor de aceite: No.\r\nDimensiones: 530/430/440 mm.\r\nPeso aproximado: 36 Kg.", 12500.0, "709260", 10000.0, 9500.0, 8750.0, "Equipo de Riego PRWP30T - Entrada 3 y Salida 3" },
                    { 2, "KUHN", "Sistema de corte autolimpiable.\r\nSistema de alimentación a base de 2 tambores de corte que aseguran una mejor recolección y 2 de pre alimentación al volante de picado.\r\nSistema de protección por medio de tornillo fusible en caso de obstrucción de los tambores de alimentación (sobrecarga).\r\nAfilador de cuchilla de picado.\r\nRecubierta con pintura epóxica (horneada).\r\nTubo de descarga abatible para el transporte.\r\nDeflector para varias posiciones.\r\nEnganche a 3 puntos, Cat. II.\r\nRueda soporte.\r\nPotencia mínima requerida de 30 Hp.\r\n2 palas lanzaderas en el volante.\r\n10 navajas en el volante.\r\nPicado estándar de 4.5 mm.\r\nAltura de descarga 3.3 m.\r\nCapacidad máxima: 49 ton/h.\r\nPeso aproximado: 480.0 Kg.", 125000.0, "633001", 100000.0, 95000.0, 87500.0, "Ensiladora 1 Surco MC90S" },
                    { 3, "SWISSMEX", "Puedes sembrar maíz, garbanzo,frijol, jicama, girasol, etc.\r\nEstructura metálica recubierta con pintura epóxica para protegerla de la corrosión.\r\nMango de agarre con empuñadura plástica antiderrapante, ambidiestra.\r\nDeposito para semillas fabricado en polipropileno.\r\nGatillo de siembra de fácil accionamiento.\r\nMuelle del disparador de alta resistencia.\r\nPlaca que abre la tierra para depositar la semilla.\r\nBase de empuje para enterrar la placa.\r\nDeflector métalico que garantiza que la semilla caiga dentro de la perforación de la tierra.\r\nTanque con capacidad de 900 gramos. (maíz).\r\nColoca de 1 a 3 semillas por disparo.\r\n1.10 m. de largo.\r\nPeso aproximado: 4.0 Kg.", 8500.0, "755002", 7000.0, 6500.0, 6000.0, "Sembradora Portátil Manual Coa" },
                    { 4, "SUPREMA", "Sistema de siembra inflador.\r\nPerilla de precisión que regula la profundidad de siembra.\r\nSe puede calibrar para diversos tipos de semillas y densidad de siembra.\r\nAsegura la colocación grano a grano.\r\nDesmbrague individual de los elementos.\r\nSeparación mínima entre líneas de 25 cm.\r\nTanque de fertilizador con mirada para viusalizar el nivel del fertilizante.\r\nLas salidas del fertilizador se pueden cancelar con facilidad.\r\nTimbre de alarma en cada unidad al atorar la semilla.\r\nLos elementos de siembra son activados por flechas.\r\nCon discos para sembrar maíz y sorgo.\r\n4 Líneas.\r\nSin fertilizador, con marcadores mecánicos.\r\nPeso aproximado 900.0 Kg.\r\nPuede comprar unidades de siembra por separado con el No. 456285.", 28000.0, "756001", 25000.0, 23500.0, 21500.0, "Sembradora Neumática de Precisión de 4 Surcos con Marcadores" },
                    { 5, "IRIS 2000", "Tanque extremadamente resistente con inhibidor de rayos UV, con aforo en litros y galones. \r\nAguilón de acero estructural con equilibrador. \r\nTapa abatible con válvula y coladera en la boca de llenado.\r\nTanque para lavado de manos del operador y tanque para lavado de circuito. \r\nIncluye mezclador. \r\nAgitador hidráulico tipo venturi.\r\nFiltro principal y filtros de línea.\r\nPorta boquillas con anti goteo integrado, filtro de 50 mallas y tuerca de acople rápido tipo bayoneta.\r\nNeumáticos de alto despeje tipo tractor.\r\nAltura mínima y máxima del aguilón: 1,1 m. -2,2m.\r\nEnganche tipo tirón\r\nCapacidad: 2200 litros.\r\nBoquillas: 48 x 3 = 11 (1102.02, 1102.04, 1030.015).\r\nBomba: RO 250.\r\nRegulador: computarizado.\r\nAncho de aspersión: 24 m.\r\nCV. Requeridos: 70-120\r\nPeso aproximado: 1.802,0 Kg.", 245000.0, "815200", 225000.0, 195000.0, 185000.0, "Aspersora Agrícola Para Tractor IRIS 2000 Computarizado" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Sci-Fi");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Dorama");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Action");
        }
    }
}
