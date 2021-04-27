using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class removeseeddataastorebroken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizza_Crust_CrustEntityId",
                table: "APizza");

            migrationBuilder.DropForeignKey(
                name: "FK_APizza_Size_SizeEntityId",
                table: "APizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_APizza_PizzaEntityId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_AStore_StoreEntityId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Topping_APizza_APizzaEntityId",
                table: "Topping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Size",
                table: "Size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AStore",
                table: "AStore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_APizza",
                table: "APizza");

            migrationBuilder.RenameTable(
                name: "Size",
                newName: "Sizes");

            migrationBuilder.RenameTable(
                name: "AStore",
                newName: "Stores");

            migrationBuilder.RenameTable(
                name: "APizza",
                newName: "Pizzas");

            migrationBuilder.RenameIndex(
                name: "IX_APizza_SizeEntityId",
                table: "Pizzas",
                newName: "IX_Pizzas_SizeEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_APizza_CrustEntityId",
                table: "Pizzas",
                newName: "IX_Pizzas_CrustEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas",
                column: "EntityId");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 1L, "Mario Pardi 2" });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "Mario Galaxy");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Name",
                value: "Luigi's Haunted Mansion");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Pizzas_PizzaEntityId",
                table: "Order",
                column: "PizzaEntityId",
                principalTable: "Pizzas",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Stores_StoreEntityId",
                table: "Order",
                column: "StoreEntityId",
                principalTable: "Stores",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityId",
                table: "Pizzas",
                column: "CrustEntityId",
                principalTable: "Crust",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityId",
                table: "Pizzas",
                column: "SizeEntityId",
                principalTable: "Sizes",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Order_Pizzas_PizzaEntityId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stores_StoreEntityId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Topping_Pizzas_APizzaEntityId",
                table: "Topping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityId",
                keyValue: 1L);

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "AStore");

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "Size");

            migrationBuilder.RenameTable(
                name: "Pizzas",
                newName: "APizza");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_SizeEntityId",
                table: "APizza",
                newName: "IX_APizza_SizeEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_CrustEntityId",
                table: "APizza",
                newName: "IX_APizza_CrustEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AStore",
                table: "AStore",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Size",
                table: "Size",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_APizza",
                table: "APizza",
                column: "EntityId");

            migrationBuilder.UpdateData(
                table: "AStore",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "Mario's Pizzeria");

            migrationBuilder.UpdateData(
                table: "AStore",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Name",
                value: "Bowser's Castle");

            migrationBuilder.AddForeignKey(
                name: "FK_APizza_Crust_CrustEntityId",
                table: "APizza",
                column: "CrustEntityId",
                principalTable: "Crust",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_APizza_Size_SizeEntityId",
                table: "APizza",
                column: "SizeEntityId",
                principalTable: "Size",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_APizza_PizzaEntityId",
                table: "Order",
                column: "PizzaEntityId",
                principalTable: "APizza",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AStore_StoreEntityId",
                table: "Order",
                column: "StoreEntityId",
                principalTable: "AStore",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topping_APizza_APizzaEntityId",
                table: "Topping",
                column: "APizzaEntityId",
                principalTable: "APizza",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
