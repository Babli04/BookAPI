using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAPI.Migrations
{
    /// <inheritdoc />
    public partial class bookdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "nemzetiseg",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(50)", maxLength: 50, nullable: false, collation: "ascii_general_ci"),
                    szerzo_nemz = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_hungarian_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.CreateTable(
                name: "szerzo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(50)", maxLength: 50, nullable: false, collation: "ascii_general_ci"),
                    nev = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_hungarian_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nem = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_hungarian_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nemz_id = table.Column<Guid>(type: "char(50)", maxLength: 50, nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "szerzo_ibfk_1",
                        column: x => x.nemz_id,
                        principalTable: "nemzetiseg",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.CreateTable(
                name: "konyv",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(50)", maxLength: 50, nullable: false, collation: "ascii_general_ci"),
                    cim = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_hungarian_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    oldalszam = table.Column<int>(type: "int(11)", nullable: true),
                    kiadev = table.Column<int>(type: "int(11)", nullable: true),
                    szerzo_id = table.Column<Guid>(type: "char(50)", maxLength: 50, nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "konyv_ibfk_1",
                        column: x => x.szerzo_id,
                        principalTable: "szerzo",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.CreateIndex(
                name: "szerzo_id",
                table: "konyv",
                column: "szerzo_id");

            migrationBuilder.CreateIndex(
                name: "nemz_id",
                table: "szerzo",
                column: "nemz_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "konyv");

            migrationBuilder.DropTable(
                name: "szerzo");

            migrationBuilder.DropTable(
                name: "nemzetiseg");
        }
    }
}
