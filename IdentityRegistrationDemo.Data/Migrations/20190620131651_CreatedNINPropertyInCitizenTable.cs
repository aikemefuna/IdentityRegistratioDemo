using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityRegistrationDemo.Data.Migrations
{
    public partial class CreatedNINPropertyInCitizenTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NIN",
                table: "Citizens",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NIN",
                table: "Citizens");
        }
    }
}
