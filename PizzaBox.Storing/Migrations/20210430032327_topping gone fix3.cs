using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class toppinggonefix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "APizzaEntityId",
                table: "Toppings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CrustEntityId1",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SizeEntityId1",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_APizzaEntityId",
                table: "Toppings",
                column: "APizzaEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityId1",
                table: "Pizzas",
                column: "CrustEntityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeEntityId1",
                table: "Pizzas",
                column: "SizeEntityId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityId1",
                table: "Pizzas",
                column: "CrustEntityId1",
                principalTable: "Crust",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityId1",
                table: "Pizzas",
                column: "SizeEntityId1",
                principalTable: "Sizes",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Pizzas_Crust_CrustEntityId1",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityId1",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Pizzas_APizzaEntityId",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_APizzaEntityId",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CrustEntityId1",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_SizeEntityId1",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "APizzaEntityId",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "CrustEntityId1",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "SizeEntityId1",
                table: "Pizzas");
        }
    }
}
