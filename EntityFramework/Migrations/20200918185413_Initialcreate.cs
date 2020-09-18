using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    address = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    postalcode = table.Column<string>(type: "char(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    city = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    location_id = table.Column<int>(type: "int(10)", nullable: false),
                    firstname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    lastname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    dateofbirth = table.Column<DateTime>(type: "date", nullable: false),
                    hiredate = table.Column<DateTime>(type: "date", nullable: false),
                    enddate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.id);
                    table.ForeignKey(
                        name: "FK_Employee_Location",
                        column: x => x.location_id,
                        principalTable: "location",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "location",
                columns: new[] { "id", "address", "city", "name", "postalcode" },
                values: new object[,]
                {
                    { -1, "123 Main Street", "Edmonton", "Super Duper Store", "T6M5W2" },
                    { -2, "567 Side Street", "Vancouver", "Awesome Store", "T8M2X2" },
                    { -3, "246 Boulevard Street", "Edmonton", "Corporate Headquarters", "T2Y8Z2" },
                    { -4, "357 Back Street", "Calgary", "Silly Store", "T9T7L2" },
                    { -5, "852 Sesame Street", "Edmonton", "Elmo Store", "T9M2A9" }
                });

            migrationBuilder.InsertData(
                table: "employee",
                columns: new[] { "id", "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[,]
                {
                    { -2, new DateTime(1966, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michael", new DateTime(2006, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -1 },
                    { -25, new DateTime(1951, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frank", new DateTime(2008, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", -4 },
                    { -16, new DateTime(1950, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mark", new DateTime(2013, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cook", -4 },
                    { -10, new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kyle", new DateTime(2009, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morris", -4 },
                    { -9, new DateTime(1967, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theresa", new DateTime(2010, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diaz", -4 },
                    { -4, new DateTime(1975, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jeffrey", new DateTime(2010, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor", -4 },
                    { -3, new DateTime(1980, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Megan", new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortiz", -4 },
                    { -94, new DateTime(1956, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Grace", new DateTime(2008, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robinson", -3 },
                    { -85, new DateTime(1956, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Daniel", new DateTime(2011, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ward", -3 },
                    { -75, new DateTime(1976, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jacob", new DateTime(2002, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ross", -3 },
                    { -72, new DateTime(1971, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joyce", new DateTime(2004, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", -3 },
                    { -71, new DateTime(1951, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emma", new DateTime(2000, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnson", -3 },
                    { -62, new DateTime(1970, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Susan", new DateTime(2004, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diaz", -3 },
                    { -60, new DateTime(1964, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Danielle", new DateTime(2009, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker", -3 },
                    { -50, new DateTime(1959, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Danielle", new DateTime(2012, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Price", -3 },
                    { -49, new DateTime(1960, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Madison", new DateTime(2000, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edwards", -3 },
                    { -47, new DateTime(1951, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tyler", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moore", -3 },
                    { -46, new DateTime(1950, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ashley", new DateTime(2002, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harris", -3 },
                    { -45, new DateTime(1957, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Isabella", new DateTime(2007, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smith", -3 },
                    { -42, new DateTime(1960, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Madison", new DateTime(2001, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ross", -3 },
                    { -40, new DateTime(1979, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bradley", new DateTime(2005, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -3 },
                    { -36, new DateTime(1960, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", new DateTime(2005, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martinez", -3 },
                    { -27, new DateTime(1975, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Christopher", new DateTime(2002, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gomez", -4 },
                    { -18, new DateTime(1979, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexis", new DateTime(2011, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramirez", -3 },
                    { -38, new DateTime(1975, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benjamin", new DateTime(2013, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Price", -4 },
                    { -52, new DateTime(1963, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Andrew", new DateTime(2010, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rivera", -4 },
                    { -91, new DateTime(1961, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", new DateTime(2000, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reed", -5 },
                    { -90, new DateTime(1974, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nicholas", new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cook", -5 },
                    { -87, new DateTime(1975, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jean", new DateTime(2009, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campbell", -5 },
                    { -83, new DateTime(1973, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sara", new DateTime(2009, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan", -5 },
                    { -80, new DateTime(1971, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Julie", new DateTime(2011, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ross", -5 },
                    { -79, new DateTime(1950, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander", new DateTime(2009, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diaz", -5 },
                    { -78, new DateTime(1974, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", new DateTime(2003, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker", -5 },
                    { -67, new DateTime(1958, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Julia", new DateTime(2009, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richardson", -5 },
                    { -63, new DateTime(1980, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Grace", new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reed", -5 },
                    { -54, new DateTime(1951, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Christina", new DateTime(2010, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker", -5 },
                    { -51, new DateTime(1977, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gregory", new DateTime(2000, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", -5 },
                    { -23, new DateTime(1969, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amanda", new DateTime(2003, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green", -5 },
                    { -21, new DateTime(1974, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gabriel", new DateTime(2006, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramos", -5 },
                    { -11, new DateTime(1952, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan", new DateTime(2005, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramos", -5 },
                    { -8, new DateTime(1950, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jacob", new DateTime(2004, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rivera", -5 },
                    { -88, new DateTime(1961, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russell", new DateTime(2008, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker", -4 },
                    { -81, new DateTime(1972, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Janice", new DateTime(2001, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -4 },
                    { -70, new DateTime(1965, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sharon", new DateTime(2006, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Williams", -4 },
                    { -68, new DateTime(1955, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Janet", new DateTime(2011, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reed", -4 },
                    { -64, new DateTime(1959, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mary", new DateTime(2011, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -4 },
                    { -59, new DateTime(1953, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Zachary", new DateTime(2004, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortiz", -4 },
                    { -39, new DateTime(1966, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jesse", new DateTime(2010, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", -4 },
                    { -17, new DateTime(1964, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Grace", new DateTime(2010, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -3 },
                    { -14, new DateTime(1952, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carol", new DateTime(2002, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harris", -3 },
                    { -6, new DateTime(1957, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Susan", new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -3 },
                    { -89, new DateTime(1972, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Theresa", new DateTime(2003, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brooks", -1 },
                    { -86, new DateTime(1977, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda", new DateTime(2003, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perez", -1 },
                    { -84, new DateTime(1976, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gloria", new DateTime(2007, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", -1 },
                    { -77, new DateTime(1956, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mark", new DateTime(2012, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson", -1 },
                    { -74, new DateTime(1977, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catherine", new DateTime(2002, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Price", -1 },
                    { -73, new DateTime(1972, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alexander", new DateTime(2006, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campbell", -1 },
                    { -69, new DateTime(1968, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bradley", new DateTime(2000, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", -1 },
                    { -58, new DateTime(1977, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Zachary", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson", -1 },
                    { -55, new DateTime(1959, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Doris", new DateTime(2007, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanders", -1 },
                    { -48, new DateTime(1952, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", new DateTime(2011, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diaz", -1 },
                    { -44, new DateTime(1970, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Walter", new DateTime(2010, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jones", -1 },
                    { -35, new DateTime(1980, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ryan", new DateTime(2006, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -1 },
                    { -34, new DateTime(1956, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Melissa", new DateTime(2009, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martinez", -1 },
                    { -30, new DateTime(1972, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denise", new DateTime(2007, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -1 },
                    { -29, new DateTime(1970, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Doris", new DateTime(2000, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gomez", -1 },
                    { -26, new DateTime(1974, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jessica", new DateTime(2004, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reed", -1 },
                    { -24, new DateTime(1973, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bryan", new DateTime(2012, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor", -1 },
                    { -13, new DateTime(1973, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", new DateTime(2003, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peterson", -1 },
                    { -12, new DateTime(1966, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jordan", new DateTime(2010, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watson", -1 },
                    { -7, new DateTime(1964, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Anna", new DateTime(2002, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myers", -1 },
                    { -5, new DateTime(1962, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "George", new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gray", -1 },
                    { -95, new DateTime(1970, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", -1 },
                    { -99, new DateTime(1970, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jeffrey", new DateTime(2000, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", -1 },
                    { -1, new DateTime(1962, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Grace", new DateTime(2007, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thompson", -2 },
                    { -15, new DateTime(1968, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sharon", new DateTime(2006, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanders", -2 },
                    { -100, new DateTime(1966, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", new DateTime(2002, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson", -2 },
                    { -98, new DateTime(1955, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carolyn", new DateTime(2002, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gutierrez", -2 },
                    { -97, new DateTime(1972, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Larry", new DateTime(2002, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chavez", -2 },
                    { -93, new DateTime(1951, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gerald", new DateTime(2001, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", -2 },
                    { -82, new DateTime(1960, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Richard", new DateTime(2006, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foster", -2 },
                    { -76, new DateTime(1979, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Terry", new DateTime(2003, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan", -2 },
                    { -66, new DateTime(1979, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Heather", new DateTime(2004, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -2 },
                    { -65, new DateTime(1960, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Benjamin", new DateTime(2008, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", -2 },
                    { -61, new DateTime(1971, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rose", new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jimenez", -2 },
                    { -57, new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joyce", new DateTime(2011, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baker", -2 },
                    { -92, new DateTime(1968, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Russell", new DateTime(2010, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan", -5 },
                    { -56, new DateTime(1962, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Diana", new DateTime(2002, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortiz", -2 },
                    { -43, new DateTime(1978, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Virginia", new DateTime(2007, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wright", -2 },
                    { -41, new DateTime(1965, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Susan", new DateTime(2013, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gutierrez", -2 },
                    { -37, new DateTime(1966, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alice", new DateTime(2009, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", -2 },
                    { -33, new DateTime(1972, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Andrea", new DateTime(2006, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long", -2 },
                    { -32, new DateTime(1978, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauren", new DateTime(2006, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -2 },
                    { -31, new DateTime(1964, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sandra", new DateTime(2005, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", -2 },
                    { -28, new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly", new DateTime(2013, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cook", -2 },
                    { -22, new DateTime(1974, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly", new DateTime(2001, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carter", -2 },
                    { -20, new DateTime(1972, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Susan", new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan", -2 },
                    { -19, new DateTime(1968, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jennifer", new DateTime(2007, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnson", -2 },
                    { -53, new DateTime(1959, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Judith", new DateTime(2007, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown", -2 },
                    { -96, new DateTime(1978, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maria", new DateTime(2012, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruiz", -5 }
                });

            migrationBuilder.CreateIndex(
                name: "FK_Employee_Location",
                table: "employee",
                column: "location_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "location");
        }
    }
}
