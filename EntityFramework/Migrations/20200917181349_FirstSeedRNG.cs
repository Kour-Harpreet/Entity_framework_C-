using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class FirstSeedRNG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[,]
                {
                    { 1, "Black", "Chevrolet", "Corvette", 154513, "High Country" },
                    { 28, "Black", "Ford", "Corvette", 160129, "High Country" },
                    { 29, "Black", "Chevrolet", "Corvette", 241541, "Awesome" },
                    { 30, "Black", "Chevrolet", "Durango", 20064, "Awesome" },
                    { 31, "Black", "Chevrolet", "Corvette", 276777, "R/T" },
                    { 32, "Black", "Dodge", "Fusion", 143005, "High Country" },
                    { 33, "Black", "Dodge", "Fusion", 253651, "High Country" },
                    { 34, "Black", "Chevrolet", "Fusion", 282827, "High Country" },
                    { 35, "Black", "Chevrolet", "Durango", 246857, "Awesome" },
                    { 36, "Black", "Ford", "Corvette", 11533, "R/T" },
                    { 37, "Black", "Chevrolet", "Durango", 258496, "R/T" },
                    { 38, "Black", "Dodge", "Corvette", 263363, "R/T" },
                    { 39, "Black", "Ford", "Fusion", 16962, "Awesome" },
                    { 40, "Black", "Ford", "Corvette", 100190, "High Country" },
                    { 41, "Black", "Chevrolet", "Fusion", 286132, "R/T" },
                    { 42, "Black", "Chevrolet", "Durango", 127481, "High Country" },
                    { 43, "Black", "Chevrolet", "Fusion", 203166, "Awesome" },
                    { 44, "Black", "Ford", "Corvette", 297563, "High Country" },
                    { 45, "Black", "Dodge", "Durango", 19528, "R/T" },
                    { 46, "Black", "Chevrolet", "Corvette", 182704, "Awesome" },
                    { 47, "Black", "Dodge", "Durango", 112555, "High Country" },
                    { 48, "Black", "Ford", "Corvette", 285718, "High Country" },
                    { 27, "Black", "Chevrolet", "Corvette", 294830, "High Country" },
                    { 26, "Black", "Chevrolet", "Durango", 189482, "High Country" },
                    { 25, "Black", "Dodge", "Fusion", 298653, "Awesome" },
                    { 24, "Black", "Chevrolet", "Corvette", 149261, "Awesome" },
                    { 2, "Black", "Dodge", "Durango", 252667, "R/T" },
                    { 3, "Black", "Dodge", "Durango", 299940, "Awesome" },
                    { 4, "Black", "Chevrolet", "Fusion", 193182, "R/T" },
                    { 5, "Black", "Chevrolet", "Corvette", 280545, "High Country" },
                    { 6, "Black", "Dodge", "Corvette", 28324, "R/T" },
                    { 7, "Black", "Ford", "Durango", 108337, "R/T" },
                    { 8, "Black", "Dodge", "Durango", 171256, "High Country" },
                    { 9, "Black", "Dodge", "Durango", 263907, "High Country" },
                    { 10, "Black", "Chevrolet", "Fusion", 227925, "R/T" },
                    { 11, "Black", "Dodge", "Fusion", 58910, "Awesome" },
                    { 49, "Black", "Dodge", "Durango", 33337, "Awesome" },
                    { 12, "Black", "Chevrolet", "Durango", 137403, "High Country" },
                    { 14, "Black", "Dodge", "Corvette", 245285, "High Country" },
                    { 15, "Black", "Ford", "Corvette", 23040, "R/T" },
                    { 16, "Black", "Ford", "Corvette", 290064, "R/T" },
                    { 17, "Black", "Chevrolet", "Corvette", 269678, "R/T" },
                    { 18, "Black", "Dodge", "Fusion", 80845, "R/T" },
                    { 19, "Black", "Ford", "Durango", 218759, "R/T" },
                    { 20, "Black", "Dodge", "Corvette", 84764, "Awesome" },
                    { 21, "Black", "Chevrolet", "Corvette", 234106, "High Country" },
                    { 22, "Black", "Chevrolet", "Corvette", 105159, "High Country" },
                    { 23, "Black", "Dodge", "Durango", 262710, "High Country" },
                    { 13, "Black", "Dodge", "Durango", 5845, "R/T" },
                    { 50, "Black", "Ford", "Durango", 269632, "Awesome" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50);
        }
    }
}



/*dotnet ef database update InitialCreate
 * 
Build started...
Build succeeded.
No migrations were applied. The database is already up to date.
Done.
PM> dotnet ef migrations remove

Build started...
Build succeeded.
Removing migration '20200917175708_FirstSeedData'.
Reverting model snapshot.
Done.
PM> dotnet ef migrations add FirstSeedRNG

Build started...
Build succeeded.
Done. To undo this action, use 'ef migrations remove'
PM> dotnet ef database update

Build started...
Build succeeded.
Applying migration '20200917181349_FirstSeedRNG'.
Done.*/