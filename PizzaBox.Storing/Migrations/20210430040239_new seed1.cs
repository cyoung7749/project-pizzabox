using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class newseed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Thin", 2.00m },
                    { 2L, "Original", 3.00m },
                    { 3L, "Thick", 4.00m }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Small", 4.00m },
                    { 2L, "Medium", 6.00m },
                    { 3L, "Large", 8.00m }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Marinara", 2.00m },
                    { 2L, "Mozzarella", 2.00m },
                    { 3L, "Basil", 2.00m },
                    { 4L, "Pepperoni", 3.00m },
                    { 5L, "Sausage", 3.00m },
                    { 6L, "Parmesan", 1.00m },
                    { 7L, "Fresh Mozzarella", 2.00m },
                    { 8L, "Mushrooms", 2.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 8L);
        }
    }
}
