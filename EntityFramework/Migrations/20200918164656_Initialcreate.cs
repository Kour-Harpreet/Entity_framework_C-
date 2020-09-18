using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "manufacturer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    year_founded = table.Column<int>(type: "int(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "code_first_car",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    manufacturer_id = table.Column<int>(type: "int(10)", nullable: false),
                    model = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    trim_level = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    colour = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    odometer = table.Column<int>(type: "int(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_code_first_car", x => x.id);
                    table.ForeignKey(
                        name: "FK_CodeFirstCar_Manufacturer",
                        column: x => x.manufacturer_id,
                        principalTable: "manufacturer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "manufacturer",
                columns: new[] { "id", "name", "year_founded" },
                values: new object[,]
                {
                    { 1, "Chevrolet", 1911 },
                    { 2, "Ford", 1903 },
                    { 3, "Tesla", null },
                    { 4, "Dodge", null },
                    { 5, "Toyota", 1937 },
                    { 6, "Honda", 1946 },
                    { 7, "Mitsubishi", null },
                    { 8, "Nissan", null }
                });

            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[,]
                {
                    { 1, "Black", 1, "Durango", 80346, "R/T" },
                    { 28, "Black", 1, "Durango", 279482, "R/T" },
                    { 29, "Black", 1, "Fusion", 144096, "High Country" },
                    { 30, "Black", 1, "Corvette", 27553, "Awesome" },
                    { 31, "Black", 1, "Corvette", 76060, "Awesome" },
                    { 32, "Black", 1, "Durango", 211930, "High Country" },
                    { 33, "Black", 1, "Corvette", 298334, "Awesome" },
                    { 34, "Black", 1, "Corvette", 204611, "High Country" },
                    { 35, "Black", 1, "Durango", 278476, "R/T" },
                    { 36, "Black", 1, "Corvette", 200808, "R/T" },
                    { 37, "Black", 1, "Corvette", 61362, "R/T" },
                    { 38, "Black", 1, "Fusion", 103074, "Awesome" },
                    { 39, "Black", 1, "Durango", 250223, "High Country" },
                    { 40, "Black", 1, "Durango", 85491, "R/T" },
                    { 41, "Black", 1, "Fusion", 25751, "High Country" },
                    { 42, "Black", 1, "Corvette", 242054, "Awesome" },
                    { 43, "Black", 1, "Corvette", 2613, "R/T" },
                    { 44, "Black", 1, "Durango", 152370, "Awesome" },
                    { 45, "Black", 1, "Durango", 164581, "Awesome" },
                    { 46, "Black", 1, "Fusion", 225127, "High Country" },
                    { 47, "Black", 1, "Corvette", 249004, "Awesome" },
                    { 48, "Black", 1, "Fusion", 81269, "Awesome" },
                    { 27, "Black", 1, "Corvette", 162799, "Awesome" },
                    { 26, "Black", 1, "Corvette", 166774, "R/T" },
                    { 25, "Black", 1, "Fusion", 95623, "High Country" },
                    { 24, "Black", 1, "Corvette", 116901, "R/T" },
                    { 2, "Black", 1, "Durango", 243707, "Awesome" },
                    { 3, "Black", 1, "Corvette", 271071, "Awesome" },
                    { 4, "Black", 1, "Corvette", 23537, "R/T" },
                    { 5, "Black", 1, "Corvette", 161778, "Awesome" },
                    { 6, "Black", 1, "Corvette", 97011, "Awesome" },
                    { 7, "Black", 1, "Corvette", 212876, "High Country" },
                    { 8, "Black", 1, "Fusion", 125273, "High Country" },
                    { 9, "Black", 1, "Durango", 39658, "High Country" },
                    { 10, "Black", 1, "Corvette", 157065, "R/T" },
                    { 11, "Black", 1, "Durango", 216419, "R/T" },
                    { 49, "Black", 1, "Fusion", 294220, "High Country" },
                    { 12, "Black", 1, "Durango", 157768, "Awesome" },
                    { 14, "Black", 1, "Fusion", 165855, "Awesome" },
                    { 15, "Black", 1, "Durango", 107105, "R/T" },
                    { 16, "Black", 1, "Durango", 171304, "R/T" },
                    { 17, "Black", 1, "Durango", 181526, "R/T" },
                    { 18, "Black", 1, "Corvette", 177639, "Awesome" },
                    { 19, "Black", 1, "Durango", 144175, "Awesome" },
                    { 20, "Black", 1, "Fusion", 273209, "High Country" },
                    { 21, "Black", 1, "Fusion", 100031, "High Country" },
                    { 22, "Black", 1, "Durango", 67671, "R/T" },
                    { 23, "Black", 1, "Durango", 68218, "Awesome" },
                    { 13, "Black", 1, "Durango", 133570, "R/T" },
                    { 50, "Black", 1, "Fusion", 28635, "High Country" }
                });

            migrationBuilder.CreateIndex(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car",
                column: "manufacturer_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "code_first_car");

            migrationBuilder.DropTable(
                name: "manufacturer");
        }
    }
}
