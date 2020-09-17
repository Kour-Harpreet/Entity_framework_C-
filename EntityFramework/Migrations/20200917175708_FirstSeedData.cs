using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class FirstSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Black", "Mitsubishi", "Lancer", 40000, "Evolution" });

            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { 2, "Red", "Honda", "Civic", 110000, "LX" });

            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { 3, "Blue", "Dodge", "Stealth", 98500, "R/T TT" });
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
        }
    }
}

/*
dotnet ef migrations add InitialCreate
No project was found. Change the current working directory or use the --project option.
PM> cd EntityFrameWork
PM> dotnet ef migrations add InitialCreate
Build started...
Build succeeded.
Done. To undo this action, use 'ef migrations remove'
PM> dotnet ef database update
Build started...
Build succeeded.
Applying migration '20200917163144_InitialCreate'.
Done.
PM> dotnet ef migrations add FirstSeedData
Build started...
Build succeeded.
Done. To undo this action, use 'ef migrations remove'
PM> dotnet ef migrations add InitialCreate
Build started...
Build succeeded.
The name 'InitialCreate' is used by an existing migration.
PM> dotnet ef database update
Build started...
Build succeeded.
Applying migration '20200917171017_FirstSeedData'.
Done.



corrected

PM> dotnet ef database update InitialCreate
Build started...
Build succeeded.
Reverting migration '20200917171017_FirstSeedData'.
Done.
PM> dotnet ef migrations remove
Build started...
Build succeeded.
Removing migration '20200917171017_FirstSeedData'.
Reverting model snapshot.
Done.
PM> dotnet ef migrations add FirstSeedData
Build started...
Build succeeded.
Done. To undo this action, use 'ef migrations remove'
PM> */