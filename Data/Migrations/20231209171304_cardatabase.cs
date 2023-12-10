using System;
using FullCars.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullCars.Data.Migrations
{
    /// <inheritdoc />
    public partial class cardatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id_car = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    N_Stock = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id_car);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id_clt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id_clt);
                });

            migrationBuilder.CreateTable(
                name: "Commandes",
                columns: table => new
                {
                    Id_commande = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_com = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_clt = table.Column<int>(type: "int", nullable: false),
                    Id_car = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commandes", x => x.Id_commande);
                    table.ForeignKey(
                        name: "FK_Commandes_Cars_Id_car",
                        column: x => x.Id_car,
                        principalTable: "Cars",
                        principalColumn: "Id_car",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commandes_Clients_Id_clt",
                        column: x => x.Id_clt,
                        principalTable: "Clients",
                        principalColumn: "Id_clt",
                        onDelete: ReferentialAction.Cascade);
                });

             migrationBuilder.CreateIndex(
                name: "IX_Commandes_Id_car",
                table: "Commandes",
                column: "Id_car");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_Id_clt",
                table: "Commandes",
                column: "Id_clt");


            migrationBuilder.CreateTable(
            name: "CartItems",
            columns: table => new
            {
                Id = table.Column<long>(nullable: false),
                Id_clt = table.Column<int>(nullable: false), // Foreign key
                CarId = table.Column<int>(nullable: false),
                CarName = table.Column<string>(nullable: true),
                CarPrice = table.Column<double>(nullable: false),
                nbr_cars_in_card = table.Column<int>(nullable: false),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_CartItems", x => x.Id);
                table.ForeignKey(
                   name: "FK_CartItems_Clients_Id_clt", // Foreign key reference
                   column: x => x.Id_clt,
                   principalTable: "Clients",
                   principalColumn: "Id_clt",
                   onDelete: ReferentialAction.Cascade);
            });
            migrationBuilder.CreateIndex(
               name: "IX_Carts_Id_clt",
               table: "CartItems",
               column: "Id_clt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commandes");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Clients");
            migrationBuilder.DropTable(
                name: "CartItems");
        }
    }
}
