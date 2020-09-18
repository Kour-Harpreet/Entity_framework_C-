using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class Controllers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -100,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marilyn", new DateTime(2001, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -99,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michelle", new DateTime(2005, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wood", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -98,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carol", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -97,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Willie", new DateTime(2010, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "King", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -96,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1962, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Judy", new DateTime(2001, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peterson" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -95,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randy", new DateTime(2007, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myers", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -94,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", new DateTime(2005, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campbell", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -93,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean", new DateTime(2001, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -92,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1957, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeffrey", new DateTime(2010, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carter" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -91,
                columns: new[] { "dateofbirth", "enddate", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2011, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hernandez", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -90,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diana", new DateTime(2012, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kim", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -89,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradley", new DateTime(2009, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thompson", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -88,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1976, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Madison", new DateTime(2012, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morales", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -87,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Doris", new DateTime(2010, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -86,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lawrence", new DateTime(2011, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smith", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -85,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gary", new DateTime(2008, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patel", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -84,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenneth", new DateTime(2011, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -83,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kathleen", new DateTime(2009, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -82,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1963, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louis", new DateTime(2001, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myers" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -81,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", new DateTime(2000, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitchell", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -80,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", new DateTime(2012, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lopez", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -79,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Raymond", new DateTime(2002, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adams", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -78,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1957, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", new DateTime(2005, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -77,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rachel", new DateTime(2004, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -76,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", new DateTime(2006, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitchell", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -75,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shirley", new DateTime(2008, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -74,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1970, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Susan", new DateTime(2003, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morris" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -73,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", new DateTime(2011, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stewart", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -72,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeremy", new DateTime(2014, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robinson", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -71,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1972, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", new DateTime(2003, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reyes" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -70,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jason", new DateTime(2006, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diaz", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -69,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evelyn", new DateTime(2013, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moore", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -68,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1973, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua", new DateTime(2006, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reyes" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -67,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", new DateTime(2004, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reyes", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -66,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerald", new DateTime(2013, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "White", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -65,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1962, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", new DateTime(2011, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garcia" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -64,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", new DateTime(2011, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -63,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vincent", new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Young", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -62,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louis", new DateTime(2010, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mendoza", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -61,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1973, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brandon", new DateTime(2009, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kim" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -60,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angela", new DateTime(2014, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Collins", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -59,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nancy", new DateTime(2005, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wright", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -58,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benjamin", new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -57,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michael", new DateTime(2013, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phillips", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -56,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1970, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christina", new DateTime(2007, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -55,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1954, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russell", new DateTime(2012, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gonzales" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -54,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michelle", new DateTime(2008, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davis", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -53,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ralph", new DateTime(2013, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -52,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theresa", new DateTime(2012, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Collins", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -51,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1958, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cynthia", new DateTime(2003, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hernandez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -50,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1969, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roy", new DateTime(2004, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gray" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -49,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amy", new DateTime(2008, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -48,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1971, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joan", new DateTime(2011, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bennet", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -47,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1963, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diane", new DateTime(2004, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Williams", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -46,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1960, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", new DateTime(2005, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brooks", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -45,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walter", new DateTime(2004, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Murphy", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -44,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan", new DateTime(2009, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thompson", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -43,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1977, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel", new DateTime(2005, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -42,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terry", new DateTime(2013, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miller", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -41,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1961, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logan", new DateTime(2000, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harris" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -40,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", new DateTime(2012, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flores", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -39,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1976, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean", new DateTime(2005, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bailey", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -38,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kyle", new DateTime(2004, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Collins", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -37,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", new DateTime(2003, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perez", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -36,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1961, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria", new DateTime(2005, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gomez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -35,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1957, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimberly", new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lopez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -34,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1963, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terry", new DateTime(2013, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -33,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debra", new DateTime(2000, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -32,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan", new DateTime(2008, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lopez", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -31,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1950, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank", new DateTime(2001, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brooks", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -30,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sean", new DateTime(2007, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bailey", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -29,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dennis", new DateTime(2003, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rogers", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -28,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joyce", new DateTime(2013, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gonzales", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -27,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sharon", new DateTime(2000, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carter", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -26,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1967, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timothy", new DateTime(2009, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodriguez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -25,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Betty", new DateTime(2000, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruiz", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -24,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1963, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margaret", new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnson", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -23,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria", new DateTime(2012, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gutierrez", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -22,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1950, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charles", new DateTime(2013, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodriguez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -21,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roger", new DateTime(2003, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allen", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -20,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1974, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ronald", new DateTime(2007, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jones" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -19,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logan", new DateTime(2004, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -18,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kathryn", new DateTime(2006, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -17,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", new DateTime(2006, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gonzales", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -16,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1954, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimberly", new DateTime(2014, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ross" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -15,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicole", new DateTime(2012, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -14,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Diana", new DateTime(2012, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edwards", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -13,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1979, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Barbara", new DateTime(2012, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -12,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roger", new DateTime(2010, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hernandez", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -11,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1979, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sara", new DateTime(2005, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -10,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diana", new DateTime(2012, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gutierrez", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -9,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paul", new DateTime(2011, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Murphy", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -8,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1969, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randy", new DateTime(2010, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruiz", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -7,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keith", new DateTime(2014, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -6,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabella", new DateTime(2013, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campbell", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -5,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1960, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimberly", new DateTime(2000, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gomez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -4,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlotte", new DateTime(2010, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lopez", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -3,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Timothy", new DateTime(2003, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodriguez", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -2,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrea", new DateTime(2002, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalie", new DateTime(2007, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gomez", -3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -100,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", new DateTime(2002, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -99,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeffrey", new DateTime(2000, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -98,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carolyn", new DateTime(2002, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gutierrez", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -97,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Larry", new DateTime(2002, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chavez", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -96,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1978, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maria", new DateTime(2012, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruiz" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -95,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -94,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", new DateTime(2008, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robinson", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -93,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerald", new DateTime(2001, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -92,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1968, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russell", new DateTime(2010, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -91,
                columns: new[] { "dateofbirth", "enddate", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reed", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -90,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cook", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -89,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theresa", new DateTime(2003, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brooks", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -88,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russell", new DateTime(2008, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -87,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jean", new DateTime(2009, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campbell", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -86,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda", new DateTime(2003, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perez", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -85,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", new DateTime(2011, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ward", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -84,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1976, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gloria", new DateTime(2007, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -83,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", new DateTime(2009, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -82,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1960, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richard", new DateTime(2006, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foster" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -81,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janice", new DateTime(2001, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -80,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1971, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julie", new DateTime(2011, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ross", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -79,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1950, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander", new DateTime(2009, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diaz", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -78,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1974, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", new DateTime(2003, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -77,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", new DateTime(2012, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -76,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terry", new DateTime(2003, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -75,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1976, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacob", new DateTime(2002, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ross", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -74,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1977, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catherine", new DateTime(2002, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Price" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -73,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander", new DateTime(2006, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campbell", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -72,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1971, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joyce", new DateTime(2004, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -71,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1951, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma", new DateTime(2000, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnson" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -70,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sharon", new DateTime(2006, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Williams", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -69,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bradley", new DateTime(2000, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -68,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1955, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janet", new DateTime(2011, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reed" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -67,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julia", new DateTime(2009, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richardson", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -66,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heather", new DateTime(2004, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -65,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1960, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benjamin", new DateTime(2008, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -64,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mary", new DateTime(2011, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -63,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reed", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -62,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Susan", new DateTime(2004, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diaz", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -61,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1971, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rose", new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jimenez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -60,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danielle", new DateTime(2009, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -59,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachary", new DateTime(2004, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortiz", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -58,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachary", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -57,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joyce", new DateTime(2011, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baker", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -56,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1962, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diana", new DateTime(2002, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortiz" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -55,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1959, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doris", new DateTime(2007, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanders" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -54,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christina", new DateTime(2010, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -53,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Judith", new DateTime(2007, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -52,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1963, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", new DateTime(2010, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rivera", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -51,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1977, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gregory", new DateTime(2000, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -50,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1959, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danielle", new DateTime(2012, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Price" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -49,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1960, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", new DateTime(2000, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edwards", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -48,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert", new DateTime(2011, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diaz", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -47,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moore", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -46,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1950, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashley", new DateTime(2002, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harris", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -45,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabella", new DateTime(2007, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smith", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -44,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walter", new DateTime(2010, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jones", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -43,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1978, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virginia", new DateTime(2007, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wright" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -42,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1960, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Madison", new DateTime(2001, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ross", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -41,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1965, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Susan", new DateTime(2013, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gutierrez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -40,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradley", new DateTime(2005, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -39,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jesse", new DateTime(2010, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -38,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benjamin", new DateTime(2013, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Price", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -37,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alice", new DateTime(2009, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -36,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1960, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert", new DateTime(2005, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martinez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -35,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1980, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryan", new DateTime(2006, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -34,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melissa", new DateTime(2009, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martinez", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -33,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrea", new DateTime(2006, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -32,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauren", new DateTime(2006, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -31,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandra", new DateTime(2005, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -30,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denise", new DateTime(2007, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -29,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doris", new DateTime(2000, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gomez", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -28,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly", new DateTime(2013, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cook", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -27,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", new DateTime(2002, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gomez", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -26,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1974, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica", new DateTime(2004, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reed" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -25,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank", new DateTime(2008, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -24,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bryan", new DateTime(2012, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -23,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1969, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amanda", new DateTime(2003, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -22,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1974, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly", new DateTime(2001, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carter" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -21,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel", new DateTime(2006, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramos", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -20,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1972, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Susan", new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -19,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jennifer", new DateTime(2007, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnson", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -18,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexis", new DateTime(2011, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramirez", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -17,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", new DateTime(2010, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -16,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1950, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", new DateTime(2013, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cook" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -15,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sharon", new DateTime(2006, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanders", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -14,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carol", new DateTime(2002, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harris", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -13,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1973, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", new DateTime(2003, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peterson" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -12,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan", new DateTime(2010, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watson", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -11,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1952, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan", new DateTime(2005, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramos" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -10,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyle", new DateTime(2009, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morris", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -9,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theresa", new DateTime(2010, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diaz", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -8,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1950, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacob", new DateTime(2004, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rivera", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -7,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", new DateTime(2002, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myers", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -6,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Susan", new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -5,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1962, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gray" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -4,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeffrey", new DateTime(2010, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -3,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Megan", new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortiz", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -2,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", new DateTime(2006, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", new DateTime(2007, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thompson", -2 });
        }
    }
}
