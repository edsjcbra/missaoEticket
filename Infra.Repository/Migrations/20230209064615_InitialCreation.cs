using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    origin = table.Column<string>(type: "NVARCHAR(250)", maxLength: 250, nullable: false),
                    destination = table.Column<string>(type: "NVARCHAR(250)", maxLength: 250, nullable: false),
                    price = table.Column<double>(type: "FLOAT", nullable: false),
                    date = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ticket");
        }
    }
}
