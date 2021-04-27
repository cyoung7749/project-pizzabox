using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class undoredundantentityID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityId1",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityId2",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityId1",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityId2",
                table: "Pizzas");

            migrationBuilder.DropTable(
                name: "APizzaTopping");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CrustEntityId1",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CrustEntityId2",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_SizeEntityId1",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_SizeEntityId2",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "CrustEntityId1",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "CrustEntityId2",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "SizeEntityId1",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "SizeEntityId2",
                table: "Pizzas");

            migrationBuilder.AddColumn<long>(
                name: "APizzaEntityId",
                table: "Topping",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topping_APizzaEntityId",
                table: "Topping",
                column: "APizzaEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Topping_Pizzas_APizzaEntityId",
                table: "Topping",
                column: "APizzaEntityId",
                principalTable: "Pizzas",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topping_Pizzas_APizzaEntityId",
                table: "Topping");

            migrationBuilder.DropIndex(
                name: "IX_Topping_APizzaEntityId",
                table: "Topping");

            migrationBuilder.DropColumn(
                name: "APizzaEntityId",
                table: "Topping");

            migrationBuilder.AddColumn<long>(
                name: "CrustEntityId1",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CrustEntityId2",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SizeEntityId1",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SizeEntityId2",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

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
                        name: "FK_APizzaTopping_Topping_ToppingsEntityId",
                        column: x => x.ToppingsEntityId,
                        principalTable: "Topping",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityId1",
                table: "Pizzas",
                column: "CrustEntityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityId2",
                table: "Pizzas",
                column: "CrustEntityId2");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeEntityId1",
                table: "Pizzas",
                column: "SizeEntityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeEntityId2",
                table: "Pizzas",
                column: "SizeEntityId2");

            migrationBuilder.CreateIndex(
                name: "IX_APizzaTopping_ToppingsEntityId",
                table: "APizzaTopping",
                column: "ToppingsEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityId1",
                table: "Pizzas",
                column: "CrustEntityId1",
                principalTable: "Crust",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityId2",
                table: "Pizzas",
                column: "CrustEntityId2",
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
                name: "FK_Pizzas_Sizes_SizeEntityId2",
                table: "Pizzas",
                column: "SizeEntityId2",
                principalTable: "Sizes",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
