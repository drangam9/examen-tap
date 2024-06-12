using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Strada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numar = table.Column<int>(type: "int", nullable: false),
                    Apartament = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DobandaGenerala = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banks_Addresses_AdresaId",
                        column: x => x.AdresaId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNasterii = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipCredit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BancaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Addresses_AdresaId",
                        column: x => x.AdresaId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Banks_BancaId",
                        column: x => x.BancaId,
                        principalTable: "Banks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banks_AdresaId",
                table: "Banks",
                column: "AdresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AdresaId",
                table: "Clients",
                column: "AdresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BancaId",
                table: "Clients",
                column: "BancaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
