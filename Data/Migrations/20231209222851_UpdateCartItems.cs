using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullCars.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCartItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
        name: "CartItems",
        columns: table => new
        {
            Id = table.Column<long>(nullable: false),
            Id_clt = table.Column<int>(nullable: false),
            CarId = table.Column<int>(nullable: false),
            CarName = table.Column<string>(nullable: true),
            CarPrice = table.Column<double>(nullable: false),
            nbr_cars_in_card = table.Column<int>(nullable: false),
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_CartItems", x => x.Id);
            table.ForeignKey(
                name: "FK_CartItems_Clients_Id_clt",
                column: x => x.Id_clt,
                principalTable: "Clients",
                principalColumn: "Id_clt",
                onDelete: ReferentialAction.Cascade);
        });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
             name: "CartItems");
        }
    }
}
