using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace poiesis_mvc.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    dni = table.Column<string>(nullable: true),
                    celular = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    experienciaDeEscritura = table.Column<string>(nullable: true),
                    contrasenia = table.Column<string>(nullable: true),
                    generoDeEscritura = table.Column<int>(nullable: false),
                    frecuenciaDeLectura = table.Column<int>(nullable: false),
                    eleccionDiaYHorario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Textos",
                columns: table => new
                {
                    idTexto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<int>(nullable: false),
                    fechaPublicacion = table.Column<DateTime>(nullable: false),
                    titulo = table.Column<string>(nullable: true),
                    contenido = table.Column<string>(nullable: true),
                    genero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Textos", x => x.idTexto);
                    table.ForeignKey(
                        name: "FK_Texto_Usuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Textos_idUsuario",
                table: "Textos",
                column: "idUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Textos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
