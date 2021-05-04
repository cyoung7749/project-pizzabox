using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class toppingr1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ToppingEntityId",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_ToppingEntityId",
                table: "Pizzas",
                column: "ToppingEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Toppings_ToppingEntityId",
                table: "Pizzas",
                column: "ToppingEntityId",
                principalTable: "Toppings",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Toppings_ToppingEntityId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_ToppingEntityId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "ToppingEntityId",
                table: "Pizzas");
        }
    }
}
