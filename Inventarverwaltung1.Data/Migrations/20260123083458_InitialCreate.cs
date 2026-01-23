using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventarverwaltung1.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Abteilung",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abteilung", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Benutzer",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benutzer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fach",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Beschreibung = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fach", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gruppe",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gruppe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ort",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegalNr = table.Column<int>(type: "int", nullable: true),
                    RegalOrt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ort", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rolle",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rolle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zustand",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Beschreibung = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zustand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Benutzer_x_Fach",
                schema: "dbo",
                columns: table => new
                {
                    Benutzer_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fach_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benutzer_x_Fach", x => new { x.Benutzer_Id, x.Fach_Id });
                    table.ForeignKey(
                        name: "FK_Benutzer_x_Fach_Benutzer_Benutzer_Id",
                        column: x => x.Benutzer_Id,
                        principalSchema: "dbo",
                        principalTable: "Benutzer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Benutzer_x_Fach_Fach_Fach_Id",
                        column: x => x.Fach_Id,
                        principalSchema: "dbo",
                        principalTable: "Fach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Benutzer_x_Rolle",
                schema: "dbo",
                columns: table => new
                {
                    Benutzer_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rolle_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benutzer_x_Rolle", x => new { x.Benutzer_Id, x.Rolle_Id });
                    table.ForeignKey(
                        name: "FK_Benutzer_x_Rolle_Benutzer_Benutzer_Id",
                        column: x => x.Benutzer_Id,
                        principalSchema: "dbo",
                        principalTable: "Benutzer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Benutzer_x_Rolle_Rolle_Rolle_Id",
                        column: x => x.Rolle_Id,
                        principalSchema: "dbo",
                        principalTable: "Rolle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Benutzer_x_Zustand",
                schema: "dbo",
                columns: table => new
                {
                    Benutzer_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Zustand_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benutzer_x_Zustand", x => new { x.Benutzer_Id, x.Zustand_Id });
                    table.ForeignKey(
                        name: "FK_Benutzer_x_Zustand_Benutzer_Benutzer_Id",
                        column: x => x.Benutzer_Id,
                        principalSchema: "dbo",
                        principalTable: "Benutzer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Benutzer_x_Zustand_Zustand_Zustand_Id",
                        column: x => x.Zustand_Id,
                        principalSchema: "dbo",
                        principalTable: "Zustand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventargegenstand",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Anschaffungsdatum = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beschreibung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seriennummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbteilungId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GruppeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ZustandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventargegenstand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventargegenstand_Abteilung_AbteilungId",
                        column: x => x.AbteilungId,
                        principalSchema: "dbo",
                        principalTable: "Abteilung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventargegenstand_Gruppe_GruppeId",
                        column: x => x.GruppeId,
                        principalSchema: "dbo",
                        principalTable: "Gruppe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventargegenstand_Ort_OrtId",
                        column: x => x.OrtId,
                        principalSchema: "dbo",
                        principalTable: "Ort",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inventargegenstand_Zustand_ZustandId",
                        column: x => x.ZustandId,
                        principalSchema: "dbo",
                        principalTable: "Zustand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ausleihe",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BisDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VonDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BenutzerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventargegenstaendeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ausleihe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ausleihe_Benutzer_BenutzerId",
                        column: x => x.BenutzerId,
                        principalSchema: "dbo",
                        principalTable: "Benutzer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ausleihe_Inventargegenstand_InventargegenstaendeId",
                        column: x => x.InventargegenstaendeId,
                        principalSchema: "dbo",
                        principalTable: "Inventargegenstand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ausleihe_BenutzerId",
                schema: "dbo",
                table: "Ausleihe",
                column: "BenutzerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ausleihe_InventargegenstaendeId",
                schema: "dbo",
                table: "Ausleihe",
                column: "InventargegenstaendeId");

            migrationBuilder.CreateIndex(
                name: "IX_Benutzer_x_Fach_Fach_Id",
                schema: "dbo",
                table: "Benutzer_x_Fach",
                column: "Fach_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Benutzer_x_Rolle_Rolle_Id",
                schema: "dbo",
                table: "Benutzer_x_Rolle",
                column: "Rolle_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Benutzer_x_Zustand_Zustand_Id",
                schema: "dbo",
                table: "Benutzer_x_Zustand",
                column: "Zustand_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Inventargegenstand_AbteilungId",
                schema: "dbo",
                table: "Inventargegenstand",
                column: "AbteilungId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventargegenstand_GruppeId",
                schema: "dbo",
                table: "Inventargegenstand",
                column: "GruppeId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventargegenstand_OrtId",
                schema: "dbo",
                table: "Inventargegenstand",
                column: "OrtId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventargegenstand_ZustandId",
                schema: "dbo",
                table: "Inventargegenstand",
                column: "ZustandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ausleihe",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Benutzer_x_Fach",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Benutzer_x_Rolle",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Benutzer_x_Zustand",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Inventargegenstand",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Fach",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Rolle",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Benutzer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Abteilung",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Gruppe",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Ort",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Zustand",
                schema: "dbo");
        }
    }
}
