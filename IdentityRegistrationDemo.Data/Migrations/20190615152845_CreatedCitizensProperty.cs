using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityRegistrationDemo.Data.Migrations
{
    public partial class CreatedCitizensProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    StateOfOrigin = table.Column<string>(nullable: false),
                    LGA = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    ContactAddress = table.Column<string>(maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    ReferenceName = table.Column<string>(maxLength: 40, nullable: false),
                    ReferenceAddress = table.Column<string>(maxLength: 200, nullable: false),
                    ReferencePhoneNumber = table.Column<string>(nullable: false),
                    Occupation = table.Column<string>(nullable: false),
                    MotherMaidenName = table.Column<string>(maxLength: 40, nullable: false),
                    BVN = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citizens");
        }
    }
}
