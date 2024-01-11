using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAPI.Migrations
{
    /// <inheritdoc />
    public partial class ujbookdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "konyv_ibfk_1",
                table: "konyv");

            migrationBuilder.DropForeignKey(
                name: "szerzo_ibfk_1",
                table: "szerzo");

            migrationBuilder.UpdateData(
                table: "szerzo",
                keyColumn: "nev",
                keyValue: null,
                column: "nev",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "nev",
                table: "szerzo",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "nemz_id",
                table: "szerzo",
                type: "char(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.UpdateData(
                table: "szerzo",
                keyColumn: "nem",
                keyValue: null,
                column: "nem",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "nem",
                table: "szerzo",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "szerzo",
                type: "char(50)",
                maxLength: 50,
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(50)",
                oldMaxLength: 50)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.UpdateData(
                table: "nemzetiseg",
                keyColumn: "szerzo_nemz",
                keyValue: null,
                column: "szerzo_nemz",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "szerzo_nemz",
                table: "nemzetiseg",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "nemzetiseg",
                type: "char(50)",
                maxLength: 50,
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(50)",
                oldMaxLength: 50)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "szerzo_id",
                table: "konyv",
                type: "char(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.AlterColumn<int>(
                name: "oldalszam",
                table: "konyv",
                type: "int(11)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int(11)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "kiadev",
                table: "konyv",
                type: "int(11)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int(11)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "konyv",
                keyColumn: "cim",
                keyValue: null,
                column: "cim",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "cim",
                table: "konyv",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "konyv",
                type: "char(50)",
                maxLength: 50,
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(50)",
                oldMaxLength: 50)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.AddForeignKey(
                name: "konyv_ibfk_1",
                table: "konyv",
                column: "szerzo_id",
                principalTable: "szerzo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "szerzo_ibfk_1",
                table: "szerzo",
                column: "nemz_id",
                principalTable: "nemzetiseg",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "konyv_ibfk_1",
                table: "konyv");

            migrationBuilder.DropForeignKey(
                name: "szerzo_ibfk_1",
                table: "szerzo");

            migrationBuilder.AlterColumn<string>(
                name: "nev",
                table: "szerzo",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.AlterColumn<string>(
                name: "nemz_id",
                table: "szerzo",
                type: "char(50)",
                maxLength: 50,
                nullable: true,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(Guid),
                oldType: "char(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "nem",
                table: "szerzo",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "szerzo",
                type: "char(50)",
                maxLength: 50,
                nullable: false,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(Guid),
                oldType: "char(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "szerzo_nemz",
                table: "nemzetiseg",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "nemzetiseg",
                type: "char(50)",
                maxLength: 50,
                nullable: false,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(Guid),
                oldType: "char(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "szerzo_id",
                table: "konyv",
                type: "char(50)",
                maxLength: 50,
                nullable: true,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(Guid),
                oldType: "char(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "oldalszam",
                table: "konyv",
                type: "int(11)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AlterColumn<int>(
                name: "kiadev",
                table: "konyv",
                type: "int(11)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AlterColumn<string>(
                name: "cim",
                table: "konyv",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_hungarian_ci");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "konyv",
                type: "char(50)",
                maxLength: 50,
                nullable: false,
                collation: "utf8mb4_hungarian_ci",
                oldClrType: typeof(Guid),
                oldType: "char(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "konyv_ibfk_1",
                table: "konyv",
                column: "szerzo_id",
                principalTable: "szerzo",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "szerzo_ibfk_1",
                table: "szerzo",
                column: "nemz_id",
                principalTable: "nemzetiseg",
                principalColumn: "id");
        }
    }
}
