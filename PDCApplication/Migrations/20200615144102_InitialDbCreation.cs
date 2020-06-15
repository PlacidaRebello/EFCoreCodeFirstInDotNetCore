using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PDCApplication.Migrations
{
    public partial class InitialDbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    PropertyId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    BldgSize = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.PropertyId);
                });

            migrationBuilder.CreateTable(
                name: "Deal",
                columns: table => new
                {
                    DealId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CloseDate = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    PropertyId = table.Column<string>(nullable: true),
                    ContactId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deal", x => x.DealId);
                    table.ForeignKey(
                        name: "FK_Deal_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deal_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deal_ContactId",
                table: "Deal",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_PropertyId",
                table: "Deal",
                column: "PropertyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deal");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
