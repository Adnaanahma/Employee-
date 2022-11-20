using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations.Migrations
{
    public partial class UserDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PrimaryEmail = table.Column<string>(nullable: true),
                    PrimaryPhoneNumber = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    StateOfOrigin = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
