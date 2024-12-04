﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SwissMex.DataAccess.Data;

#nullable disable

namespace SwissMex.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241202165453_AddIdentityToDb")]
    partial class AddIdentityToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SwissMex.Models.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DisplayOrder")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Siembra"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Cosecha"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Aspersión"
                        });
                });

            modelBuilder.Entity("SwissMex.Models.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price25")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "POWERAC",
                            CategoryId = 1,
                            Description = "Diámetro de conexión: Entrada 3\" y Salida 3\".\r\nRoca de conexión: Externa tubular.\r\nAltura total de descarga: 28 m.\r\nAltura de succión: 6 m.\r\nCaudal: 750 L./min.\r\nPotencia: 7 CV / 208 cc.\r\nArranque: Cordón retráctil.\r\nPresión: Normal / Basura.\r\nSensor de aceite: No.\r\nDimensiones: 530/430/440 mm.\r\nPeso aproximado: 36 Kg.",
                            ImageUrl = "",
                            ListPrice = 12500.0,
                            PartNumber = "709260",
                            Price = 10000.0,
                            Price25 = 9500.0,
                            Price50 = 8750.0,
                            Title = "Equipo de Riego PRWP30T - Entrada 3\" y Salida 3\""
                        },
                        new
                        {
                            Id = 2,
                            Brand = "KUHN",
                            CategoryId = 2,
                            Description = "Sistema de corte autolimpiable.\r\nSistema de alimentación a base de 2 tambores de corte que aseguran una mejor recolección y 2 de pre alimentación al volante de picado.\r\nSistema de protección por medio de tornillo fusible en caso de obstrucción de los tambores de alimentación (sobrecarga).\r\nAfilador de cuchilla de picado.\r\nRecubierta con pintura epóxica (horneada).\r\nTubo de descarga abatible para el transporte.\r\nDeflector para varias posiciones.\r\nEnganche a 3 puntos, Cat. II.\r\nRueda soporte.\r\nPotencia mínima requerida de 30 Hp.\r\n2 palas lanzaderas en el volante.\r\n10 navajas en el volante.\r\nPicado estándar de 4.5 mm.\r\nAltura de descarga 3.3 m.\r\nCapacidad máxima: 49 ton/h.\r\nPeso aproximado: 480.0 Kg.",
                            ImageUrl = "",
                            ListPrice = 125000.0,
                            PartNumber = "633001",
                            Price = 100000.0,
                            Price25 = 95000.0,
                            Price50 = 87500.0,
                            Title = "Ensiladora 1 Surco MC90S"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "SWISSMEX",
                            CategoryId = 3,
                            Description = "Puedes sembrar maíz, garbanzo,frijol, jicama, girasol, etc.\r\nEstructura metálica recubierta con pintura epóxica para protegerla de la corrosión.\r\nMango de agarre con empuñadura plástica antiderrapante, ambidiestra.\r\nDeposito para semillas fabricado en polipropileno.\r\nGatillo de siembra de fácil accionamiento.\r\nMuelle del disparador de alta resistencia.\r\nPlaca que abre la tierra para depositar la semilla.\r\nBase de empuje para enterrar la placa.\r\nDeflector métalico que garantiza que la semilla caiga dentro de la perforación de la tierra.\r\nTanque con capacidad de 900 gramos. (maíz).\r\nColoca de 1 a 3 semillas por disparo.\r\n1.10 m. de largo.\r\nPeso aproximado: 4.0 Kg.",
                            ImageUrl = "",
                            ListPrice = 8500.0,
                            PartNumber = "755002",
                            Price = 7000.0,
                            Price25 = 6500.0,
                            Price50 = 6000.0,
                            Title = "Sembradora Portátil Manual Coa"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "SUPREMA",
                            CategoryId = 3,
                            Description = "Sistema de siembra inflador.\r\nPerilla de precisión que regula la profundidad de siembra.\r\nSe puede calibrar para diversos tipos de semillas y densidad de siembra.\r\nAsegura la colocación grano a grano.\r\nDesmbrague individual de los elementos.\r\nSeparación mínima entre líneas de 25 cm.\r\nTanque de fertilizador con mirada para viusalizar el nivel del fertilizante.\r\nLas salidas del fertilizador se pueden cancelar con facilidad.\r\nTimbre de alarma en cada unidad al atorar la semilla.\r\nLos elementos de siembra son activados por flechas.\r\nCon discos para sembrar maíz y sorgo.\r\n4 Líneas.\r\nSin fertilizador, con marcadores mecánicos.\r\nPeso aproximado 900.0 Kg.\r\nPuede comprar unidades de siembra por separado con el No. 456285.",
                            ImageUrl = "",
                            ListPrice = 28000.0,
                            PartNumber = "756001",
                            Price = 25000.0,
                            Price25 = 23500.0,
                            Price50 = 21500.0,
                            Title = "Sembradora Neumática de Precisión de 4 Surcos con Marcadores"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "IRIS 2000",
                            CategoryId = 3,
                            Description = "Tanque extremadamente resistente con inhibidor de rayos UV, con aforo en litros y galones. \r\nAguilón de acero estructural con equilibrador. \r\nTapa abatible con válvula y coladera en la boca de llenado.\r\nTanque para lavado de manos del operador y tanque para lavado de circuito. \r\nIncluye mezclador. \r\nAgitador hidráulico tipo venturi.\r\nFiltro principal y filtros de línea.\r\nPorta boquillas con anti goteo integrado, filtro de 50 mallas y tuerca de acople rápido tipo bayoneta.\r\nNeumáticos de alto despeje tipo tractor.\r\nAltura mínima y máxima del aguilón: 1,1 m. -2,2m.\r\nEnganche tipo tirón\r\nCapacidad: 2200 litros.\r\nBoquillas: 48 x 3 = 11 (1102.02, 1102.04, 1030.015).\r\nBomba: RO 250.\r\nRegulador: computarizado.\r\nAncho de aspersión: 24 m.\r\nCV. Requeridos: 70-120\r\nPeso aproximado: 1.802,0 Kg.",
                            ImageUrl = "",
                            ListPrice = 245000.0,
                            PartNumber = "815200",
                            Price = 225000.0,
                            Price25 = 195000.0,
                            Price50 = 185000.0,
                            Title = "Aspersora Agrícola Para Tractor IRIS 2000 Computarizado"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SwissMex.Models.Models.Product", b =>
                {
                    b.HasOne("SwissMex.Models.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
