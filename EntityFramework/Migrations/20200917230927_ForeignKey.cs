using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Fusion", 40653 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 107721, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 155723, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 86307, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Durango", 197547 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 267839, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 46158, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 258983, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 75522, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Fusion", 169481 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 56870, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 146296, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Fusion", 192395 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 242895, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 185635, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 60169, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Durango", 246418 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 279487, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 226404, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 81373, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 281339, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 296012, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 62456, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 277479, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 185311, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 134490, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 285030, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 285247, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Fusion", 129002 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 6344, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 175966, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 20100, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 51696, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 3814, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 121808, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Fusion", 56722 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 232073, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 267810, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 121064, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 26378, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 35499, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                column: "odometer",
                value: 198196);

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 187149, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 284333, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 76033, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 70201, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 236269, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                column: "odometer",
                value: 235639);

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Corvette", 144275 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                column: "odometer",
                value: 267471);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Corvette", 291115 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 262549, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 267443, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 223263, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Corvette", 44779 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 23513, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 119727, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 91670, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 188062, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Durango", 136247 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 120518, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 67562, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Durango", 46465 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 290556, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 62913, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 54111, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Fusion", 289690 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 129904, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 279769, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 136970, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 137641, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 56084, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 175835, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 233940, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 112951, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 83355, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 8230, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 4344, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Durango", 107986 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 77053, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 151371, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 100011, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 222072, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 9770, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 142387, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Corvette", 101385 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 144623, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 193067, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 115228, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 158672, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 8286, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                column: "odometer",
                value: 41667);

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 277842, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 182976, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 262714, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 280430, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 242136, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                column: "odometer",
                value: 70956);

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Fusion", 50131 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                column: "odometer",
                value: 100157);
        }
    }
}
