using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class removeapizzatopping2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Pizzas_APizzaEntityId",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_APizzaEntityId",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "APizzaEntityId",
                table: "Toppings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "APizzaEntityId",
                table: "Toppings",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_APizzaEntityId",
                table: "Toppings",
                column: "APizzaEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_Pizzas_APizzaEntityId",
                table: "Toppings",
                column: "APizzaEntityId",
                principalTable: "Pizzas",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
