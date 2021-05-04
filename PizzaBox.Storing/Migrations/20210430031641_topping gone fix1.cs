using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class toppinggonefix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APizzaTopping");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
