using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class toppinggonefix6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Toppings_ToppingEntityId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Pizzas_PizzaEntityId",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_PizzaEntityId",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_ToppingEntityId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "PizzaEntityId",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "ToppingEntityId",
                table: "Pizzas");

            migrationBuilder.CreateTable(
                name: "APizzaTopping",
                columns: table => new
                {
                    PizzasEntityId = table.Column<long>(type: "bigint", nullable: false),
                    ToppingsEntityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APizzaTopping", x => new { x.PizzasEntityId, x.ToppingsEntityId });
                    table.ForeignKey(
                        name: "FK_APizzaTopping_Pizzas_PizzasEntityId",
                        column: x => x.PizzasEntityId,
                        principalTable: "Pizzas",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_APizzaTopping_Toppings_ToppingsEntityId",
                        column: x => x.ToppingsEntityId,
                        principalTable: "Toppings",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_APizzaTopping_ToppingsEntityId",
                table: "APizzaTopping",
                column: "ToppingsEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APizzaTopping");

            migrationBuilder.AddColumn<long>(
                name: "PizzaEntityId",
                table: "Toppings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ToppingEntityId",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_PizzaEntityId",
                table: "Toppings",
                column: "PizzaEntityId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_Pizzas_PizzaEntityId",
                table: "Toppings",
                column: "PizzaEntityId",
                principalTable: "Pizzas",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
