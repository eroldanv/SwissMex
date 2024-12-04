using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SwissMex.Models.Models;

namespace SwissMex.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Siembra", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Cosecha", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Aspersión", DisplayOrder = 3 }

            );

            modelBuilder.Entity<Product>().HasData(
                new Product 
                { Id = 1,
                  Title = "Equipo de Riego PRWP30T - Entrada 3\" y Salida 3\"",
                  Description = "Diámetro de conexión: Entrada 3\" y Salida 3\".\r\nRoca de conexión: Externa tubular.\r\nAltura total de descarga: 28 m.\r\nAltura de succión: 6 m.\r\nCaudal: 750 L./min.\r\nPotencia: 7 CV / 208 cc.\r\nArranque: Cordón retráctil.\r\nPresión: Normal / Basura.\r\nSensor de aceite: No.\r\nDimensiones: 530/430/440 mm.\r\nPeso aproximado: 36 Kg.",
                  PartNumber = "709260",
                  Brand = "POWERAC",
                  Price = 10000,
                  ListPrice = 12500,
                  Price25 = 9500,
                  Price50 = 8750,
                  CategoryId = 1,
                  ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Ensiladora 1 Surco MC90S",
                    Description = "Sistema de corte autolimpiable.\r\nSistema de alimentación a base de 2 tambores de corte que aseguran una mejor recolección y 2 de pre alimentación al volante de picado.\r\nSistema de protección por medio de tornillo fusible en caso de obstrucción de los tambores de alimentación (sobrecarga).\r\nAfilador de cuchilla de picado.\r\nRecubierta con pintura epóxica (horneada).\r\nTubo de descarga abatible para el transporte.\r\nDeflector para varias posiciones.\r\nEnganche a 3 puntos, Cat. II.\r\nRueda soporte.\r\nPotencia mínima requerida de 30 Hp.\r\n2 palas lanzaderas en el volante.\r\n10 navajas en el volante.\r\nPicado estándar de 4.5 mm.\r\nAltura de descarga 3.3 m.\r\nCapacidad máxima: 49 ton/h.\r\nPeso aproximado: 480.0 Kg.",
                    PartNumber = "633001",
                    Brand = "KUHN",
                    Price = 100000,
                    ListPrice = 125000,
                    Price25 = 95000,
                    Price50 = 87500,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                 new Product
                 {
                     Id = 3,
                     Title = "Sembradora Portátil Manual Coa",
                     Description = "Puedes sembrar maíz, garbanzo,frijol, jicama, girasol, etc.\r\nEstructura metálica recubierta con pintura epóxica para protegerla de la corrosión.\r\nMango de agarre con empuñadura plástica antiderrapante, ambidiestra.\r\nDeposito para semillas fabricado en polipropileno.\r\nGatillo de siembra de fácil accionamiento.\r\nMuelle del disparador de alta resistencia.\r\nPlaca que abre la tierra para depositar la semilla.\r\nBase de empuje para enterrar la placa.\r\nDeflector métalico que garantiza que la semilla caiga dentro de la perforación de la tierra.\r\nTanque con capacidad de 900 gramos. (maíz).\r\nColoca de 1 a 3 semillas por disparo.\r\n1.10 m. de largo.\r\nPeso aproximado: 4.0 Kg.",
                     PartNumber = "755002",
                     Brand = "SWISSMEX",
                     Price = 7000,
                     ListPrice = 8500,
                     Price25 = 6500,
                     Price50 = 6000,
                     CategoryId = 3,
                     ImageUrl = ""
                 },
                 new Product
                 {
                     Id = 4,
                     Title = "Sembradora Neumática de Precisión de 4 Surcos con Marcadores",
                     Description = "Sistema de siembra inflador.\r\nPerilla de precisión que regula la profundidad de siembra.\r\nSe puede calibrar para diversos tipos de semillas y densidad de siembra.\r\nAsegura la colocación grano a grano.\r\nDesmbrague individual de los elementos.\r\nSeparación mínima entre líneas de 25 cm.\r\nTanque de fertilizador con mirada para viusalizar el nivel del fertilizante.\r\nLas salidas del fertilizador se pueden cancelar con facilidad.\r\nTimbre de alarma en cada unidad al atorar la semilla.\r\nLos elementos de siembra son activados por flechas.\r\nCon discos para sembrar maíz y sorgo.\r\n4 Líneas.\r\nSin fertilizador, con marcadores mecánicos.\r\nPeso aproximado 900.0 Kg.\r\nPuede comprar unidades de siembra por separado con el No. 456285.",
                     PartNumber = "756001",
                     Brand = "SUPREMA",
                     Price = 25000,
                     ListPrice = 28000,
                     Price25 = 23500,
                     Price50 = 21500,
                     CategoryId = 3,
                     ImageUrl = ""
                 },
                 new Product
                 {
                     Id = 5,
                     Title = "Aspersora Agrícola Para Tractor IRIS 2000 Computarizado",
                     Description = "Tanque extremadamente resistente con inhibidor de rayos UV, con aforo en litros y galones. \r\nAguilón de acero estructural con equilibrador. \r\nTapa abatible con válvula y coladera en la boca de llenado.\r\nTanque para lavado de manos del operador y tanque para lavado de circuito. \r\nIncluye mezclador. \r\nAgitador hidráulico tipo venturi.\r\nFiltro principal y filtros de línea.\r\nPorta boquillas con anti goteo integrado, filtro de 50 mallas y tuerca de acople rápido tipo bayoneta.\r\nNeumáticos de alto despeje tipo tractor.\r\nAltura mínima y máxima del aguilón: 1,1 m. -2,2m.\r\nEnganche tipo tirón\r\nCapacidad: 2200 litros.\r\nBoquillas: 48 x 3 = 11 (1102.02, 1102.04, 1030.015).\r\nBomba: RO 250.\r\nRegulador: computarizado.\r\nAncho de aspersión: 24 m.\r\nCV. Requeridos: 70-120\r\nPeso aproximado: 1.802,0 Kg.",
                     PartNumber = "815200",
                     Brand = "IRIS 2000",
                     Price = 225000,
                     ListPrice = 245000,
                     Price25 = 195000,
                     Price50 = 185000,
                     CategoryId = 3,
                     ImageUrl = ""
                 }

            );
        }
    }
}
