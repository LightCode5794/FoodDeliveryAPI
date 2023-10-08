using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FoodDelivery.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitWebDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar(256)", nullable: false),
                    Email = table.Column<string>(type: "varchar(256)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(128)", nullable: false),
                    Avatar = table.Column<string>(type: "varchar(256)", nullable: false),
                    Address = table.Column<string>(type: "varchar(256)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
