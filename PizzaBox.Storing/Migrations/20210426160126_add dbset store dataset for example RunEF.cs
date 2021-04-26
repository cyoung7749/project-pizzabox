using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class adddbsetstoredatasetforexampleRunEF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AStore_StoreEntityId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AStore",
                table: "AStore");

            migrationBuilder.DeleteData(
                table: "AStore",
                keyColumn: "EntityId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "AStore",
                keyColumn: "EntityId",
                keyValue: 2L);

            migrationBuilder.RenameTable(
                name: "AStore",
                newName: "Stores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "EntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Stores_StoreEntityId",
                table: "Order",
                column: "StoreEntityId",
                principalTable: "Stores",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stores_StoreEntityId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "AStore");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AStore",
                table: "AStore",
                column: "EntityId");

            migrationBuilder.InsertData(
                table: "AStore",
                columns: new[] { "EntityId", "Discriminator", "Name" },
                values: new object[] { 1L, "EastCoast", "Mario's Pizzeria" });

            migrationBuilder.InsertData(
                table: "AStore",
                columns: new[] { "EntityId", "Discriminator", "Name" },
                values: new object[] { 2L, "WestCoast", "Bowser's Castle" });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AStore_StoreEntityId",
                table: "Order",
                column: "StoreEntityId",
                principalTable: "AStore",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
