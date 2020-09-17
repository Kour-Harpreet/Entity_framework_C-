using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class Manufacturer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "manufacturer",
                table: "code_first_car");

            migrationBuilder.AddColumn<int>(
                name: "manufacturer_id",
                table: "code_first_car",
                type: "int(10)",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 291115, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 262549, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 267443 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 223263, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 44779, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 23513, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 119727, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 91670, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 188062, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 136247 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 120518 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 67562, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 46465, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 290556, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 62913, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 54111 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Fusion", 289690 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 129904 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 279769, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Fusion", 136970 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 137641 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 56084, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 175835 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Fusion", 233940 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 112951, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 83355 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 8230 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 4344, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 107986, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 77053, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 151371, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 100011 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 222072, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 9770 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 142387 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 101385, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 144623, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 193067 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 115228 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 158672, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 8286 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 41667, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 277842, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 182976, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 262714, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Fusion", 280430 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 242136 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 70956, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 50131, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 100157, "High Country" });

            migrationBuilder.CreateIndex(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car",
                column: "manufacturer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car",
                column: "manufacturer_id",
                principalTable: "manufacturer",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car");

            migrationBuilder.DropTable(
                name: "manufacturer");

            migrationBuilder.DropIndex(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car");

            migrationBuilder.DropColumn(
                name: "manufacturer_id",
                table: "code_first_car");

            migrationBuilder.AddColumn<string>(
                name: "manufacturer",
                table: "code_first_car",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_general_ci");

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 154513, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 252667, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 299940 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 193182, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 280545, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 28324, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 108337, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 171256, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 263907, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Fusion", 227925 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Fusion", 58910 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Durango", 137403, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 5845, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 245285, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 23040, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Corvette", 290064 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 269678 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Fusion", 80845 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 218759, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Corvette", 84764 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 234106 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 105159, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 262710 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 149261 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 298653, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 189482 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 294830 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Corvette", 160129, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 241541, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Durango", 20064, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 276777, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 143005 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Fusion", 253651, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Fusion", 282827 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 246857 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 11533, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Durango", 258496, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Corvette", 263363 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 16962 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Corvette", 100190, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 286132 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Durango", 127481, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Fusion", 203166, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 297563, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 19528, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 182704 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 112555 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 285718, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 33337, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Durango", 269632, "Awesome" });
        }
    }
}
