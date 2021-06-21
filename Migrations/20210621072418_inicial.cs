using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepasoFinal.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TCategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCategoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreComprador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CelularComprador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LugarCompra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TProductos_TCategoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "TCategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TProductos_CategoriaId",
                table: "TProductos",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TProductos");

            migrationBuilder.DropTable(
                name: "TCategoria");
        }
    }
}
