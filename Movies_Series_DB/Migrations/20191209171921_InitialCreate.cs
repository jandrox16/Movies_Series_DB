using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies_Series_DB.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Casting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreDir = table.Column<string>(nullable: true),
                    ApellidosDir = table.Column<string>(nullable: true),
                    PaisDir = table.Column<string>(nullable: true),
                    FechaNacDir = table.Column<DateTime>(nullable: false),
                    NombreActPpal = table.Column<string>(nullable: true),
                    ApellidosActPpal = table.Column<string>(nullable: true),
                    PaisActPpal = table.Column<string>(nullable: true),
                    FechaNacActPpal = table.Column<DateTime>(nullable: false),
                    PersonajeActPpal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casting");
        }
    }
}
