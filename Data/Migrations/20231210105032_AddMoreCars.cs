using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullCars.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id_car", "Description", "Marque", "N_Stock", "Price" },
                values: new object[,]
                {
                    { 3, "b1.jpg", "BMW", 15, 35000.0 },
                    { 4, "m1.jpg", "Mercedes", 12, 40000.0 },
                    { 5, "v1.jpg", "Volkswagen", 20, 28000.0 },
                    { 6, "b2.jpg", "BMW", 18, 42000.0 },
                    { 7, "m2.jpg", "Mercedes", 14, 38000.0 },
                    { 8, "v2.jpg", "Volkswagen", 16, 32000.0 },
                    { 9, "b3.jpg", "BMW", 10, 38000.0 },
                    { 10, "m3.jpg", "Mercedes", 22, 45000.0 },
                    { 11, "v3.jpg", "Volkswagen", 17, 30000.0 },
                    { 12, "b4.jpg", "BMW", 19, 32000.0 },
                    { 13, "a1.jpg", "Audi", 13, 48000.0 },
                    { 14, "te1.jpg", "Tesla", 11, 34000.0 },
                    { 15, "b5.jpg", "BMW", 15, 37000.0 },
                    { 16, "m4.jpg", "Mercedes", 14, 42000.0 },
                    { 17, "v5.jpg", "Volkswagen", 18, 29000.0 },
                    { 18, "p1.jpg", "Porsche", 12, 40000.0 },
                    { 19, "j1.jpg", "Jaguar", 16, 35000.0 },
                    { 20, "v6.jpg", "Volkswagen", 20, 33000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id_car",
                keyValue: 20);
        }
    }
}
