using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GasDelivery.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InfoClientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoExterior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoInterior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CruceCalles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_InfoCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoClientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Repartidor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    UbicacionActual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoRepartidor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComentarioEstadoRepartidor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repartidor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suscripciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Periodicidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo_servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_InfoCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suscripciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suscripciones_InfoClientes_Id_InfoCliente",
                        column: x => x.Id_InfoCliente,
                        principalTable: "InfoClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<int>(type: "int", nullable: false),
                    Contrasena = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Id_InfoCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_InfoClientes_Id_InfoCliente",
                        column: x => x.Id_InfoCliente,
                        principalTable: "InfoClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraLlegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TiempoEstimado = table.Column<int>(type: "int", nullable: false),
                    EstadoPedido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetodoPago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Repartidor = table.Column<int>(type: "int", nullable: false),
                    Id_InfoCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_InfoClientes_Id_InfoCliente",
                        column: x => x.Id_InfoCliente,
                        principalTable: "InfoClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Repartidor_Id_Repartidor",
                        column: x => x.Id_Repartidor,
                        principalTable: "Repartidor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarjetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroTarjeta = table.Column<int>(type: "int", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nip = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjetas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarjetas_Usuarios_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Id_InfoCliente",
                table: "Pedidos",
                column: "Id_InfoCliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Id_Repartidor",
                table: "Pedidos",
                column: "Id_Repartidor");

            migrationBuilder.CreateIndex(
                name: "IX_Suscripciones_Id_InfoCliente",
                table: "Suscripciones",
                column: "Id_InfoCliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_Id_Usuario",
                table: "Tarjetas",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Id_InfoCliente",
                table: "Usuarios",
                column: "Id_InfoCliente",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Suscripciones");

            migrationBuilder.DropTable(
                name: "Tarjetas");

            migrationBuilder.DropTable(
                name: "Repartidor");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "InfoClientes");
        }
    }
}
