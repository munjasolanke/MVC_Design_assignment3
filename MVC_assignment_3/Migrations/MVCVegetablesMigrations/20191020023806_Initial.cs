using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_assignment_3.Migrations.MVCVegetablesMigrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vegetables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VegetableName = table.Column<string>(nullable: true),
                    VegetableForm = table.Column<string>(nullable: true),
                    AvgRetailPrice = table.Column<int>(nullable: false),
                    PreparationYieldFactor = table.Column<int>(nullable: false),
                    Sizeofcupequivalent = table.Column<int>(nullable: false),
                    AvgPricepercupequivalent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vegetables", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vegetables");
        }
    }
}
