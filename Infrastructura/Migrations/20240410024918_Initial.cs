using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaHorarios.Infrastructura.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "grupos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Grado = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Horas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Inicio = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Fin = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    EsReceso = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "maestros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maestros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mayas_curriculares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Grado = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mayas_curriculares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "horarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MayaCurricularId = table.Column<int>(type: "INTEGER", nullable: false),
                    GrupoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_horarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_horarios_grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_horarios_mayas_curriculares_MayaCurricularId",
                        column: x => x.MayaCurricularId,
                        principalTable: "mayas_curriculares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "materias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MayaCurricularId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Codigo = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    HorasSemanales = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_materias_mayas_curriculares_MayaCurricularId",
                        column: x => x.MayaCurricularId,
                        principalTable: "mayas_curriculares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HorarioItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HorarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    HoraId = table.Column<int>(type: "INTEGER", nullable: false),
                    MateriaId = table.Column<int>(type: "INTEGER", nullable: false),
                    MaestroId = table.Column<int>(type: "INTEGER", nullable: false),
                    Dia = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HorarioItems_horarios_HorarioId",
                        column: x => x.HorarioId,
                        principalTable: "horarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorarioItems_Horas_HoraId",
                        column: x => x.HoraId,
                        principalTable: "Horas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorarioItems_maestros_MaestroId",
                        column: x => x.MaestroId,
                        principalTable: "maestros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorarioItems_materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Horas",
                columns: new[] { "Id", "EsReceso", "Fin", "Inicio" },
                values: new object[] { 1, false, new TimeOnly(8, 0, 0), new TimeOnly(7, 0, 0) });

            migrationBuilder.InsertData(
                table: "Horas",
                columns: new[] { "Id", "EsReceso", "Fin", "Inicio" },
                values: new object[] { 2, false, new TimeOnly(9, 0, 0), new TimeOnly(8, 0, 0) });

            migrationBuilder.InsertData(
                table: "Horas",
                columns: new[] { "Id", "EsReceso", "Fin", "Inicio" },
                values: new object[] { 3, false, new TimeOnly(10, 0, 0), new TimeOnly(9, 0, 0) });

            migrationBuilder.InsertData(
                table: "Horas",
                columns: new[] { "Id", "EsReceso", "Fin", "Inicio" },
                values: new object[] { 4, true, new TimeOnly(10, 20, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.InsertData(
                table: "Horas",
                columns: new[] { "Id", "EsReceso", "Fin", "Inicio" },
                values: new object[] { 5, false, new TimeOnly(11, 10, 0), new TimeOnly(10, 20, 0) });

            migrationBuilder.InsertData(
                table: "Horas",
                columns: new[] { "Id", "EsReceso", "Fin", "Inicio" },
                values: new object[] { 6, false, new TimeOnly(12, 0, 0), new TimeOnly(11, 10, 0) });

            migrationBuilder.InsertData(
                table: "Horas",
                columns: new[] { "Id", "EsReceso", "Fin", "Inicio" },
                values: new object[] { 7, true, new TimeOnly(12, 20, 0), new TimeOnly(12, 0, 0) });

            migrationBuilder.InsertData(
                table: "Horas",
                columns: new[] { "Id", "EsReceso", "Fin", "Inicio" },
                values: new object[] { 8, false, new TimeOnly(1, 10, 0), new TimeOnly(12, 20, 0) });

            migrationBuilder.InsertData(
                table: "Horas",
                columns: new[] { "Id", "EsReceso", "Fin", "Inicio" },
                values: new object[] { 9, false, new TimeOnly(2, 10, 0), new TimeOnly(1, 10, 0) });

            migrationBuilder.CreateIndex(
                name: "IX_HorarioItems_HoraId",
                table: "HorarioItems",
                column: "HoraId");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioItems_HorarioId",
                table: "HorarioItems",
                column: "HorarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioItems_MaestroId",
                table: "HorarioItems",
                column: "MaestroId");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioItems_MateriaId",
                table: "HorarioItems",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_horarios_GrupoId",
                table: "horarios",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_horarios_MayaCurricularId",
                table: "horarios",
                column: "MayaCurricularId");

            migrationBuilder.CreateIndex(
                name: "IX_materias_Codigo",
                table: "materias",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_materias_MayaCurricularId",
                table: "materias",
                column: "MayaCurricularId");

            migrationBuilder.CreateIndex(
                name: "IX_materias_Nombre",
                table: "materias",
                column: "Nombre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorarioItems");

            migrationBuilder.DropTable(
                name: "horarios");

            migrationBuilder.DropTable(
                name: "Horas");

            migrationBuilder.DropTable(
                name: "maestros");

            migrationBuilder.DropTable(
                name: "materias");

            migrationBuilder.DropTable(
                name: "grupos");

            migrationBuilder.DropTable(
                name: "mayas_curriculares");
        }
    }
}
