using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonelProjesiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class firstmigdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsZimmet = table.Column<bool>(type: "bit", nullable: false),
                    Mezuniyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departman = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Maas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Personels",
                columns: new[] { "Id", "Adi", "Cinsiyet", "Departman", "DogumTarihi", "IsZimmet", "Maas", "Mezuniyet", "Sehir", "Soyadi" },
                values: new object[,]
                {
                    { 1, "Ahmet", "Erkek", "Yazılım", new DateTime(1990, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 50000, "İstanbul Üniversitesi", "İstanbul", "Yılmaz" },
                    { 2, "Ayşe", "Kadın", "Pazarlama", new DateTime(1999, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 45000, "Ankara Üniversitesi", "Ankara", "Demir" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personels");
        }
    }
}
