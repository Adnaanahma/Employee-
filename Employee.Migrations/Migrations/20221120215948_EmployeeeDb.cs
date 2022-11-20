using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations.Migrations
{
    public partial class EmployeeeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employeees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    EmployeeIdentity = table.Column<string>(nullable: true),
                    OfficialMail = table.Column<string>(nullable: true),
                    OfficialPhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employeees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employeees_UserId",
                table: "Employeees",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employeees");
        }
    }
}
