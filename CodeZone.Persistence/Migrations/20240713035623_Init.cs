using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeZone.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoresItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoresItems", x => new { x.ItemId, x.StoreId });
                    table.ForeignKey(
                        name: "FK_StoresItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoresItems_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "images/items/item_1.png", "Apple" },
                    { 2, "images/items/item_2.png", "Banana" },
                    { 3, "images/items/item_3.png", "Cherry" },
                    { 4, "images/items/item_4.png", "Date" },
                    { 5, "images/items/item_5.png", "Elderberry" },
                    { 6, "images/items/item_6.png", "Fig" },
                    { 7, "images/items/item_7.png", "Grape" },
                    { 8, "images/items/item_8.png", "Honeydew" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cairo" },
                    { 2, "Alexandria" },
                    { 3, "Giza" },
                    { 4, "Suez" },
                    { 5, "Mansoura" }
                });

            migrationBuilder.InsertData(
                table: "StoresItems",
                columns: new[] { "ItemId", "StoreId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 10 },
                    { 1, 3, 9 },
                    { 2, 2, 43 },
                    { 3, 1, 16 },
                    { 3, 2, 30 },
                    { 3, 5, 7 },
                    { 4, 3, 40 },
                    { 4, 5, 81 },
                    { 5, 2, 66 },
                    { 5, 5, 32 },
                    { 6, 2, 60 },
                    { 6, 3, 4 },
                    { 7, 1, 45 },
                    { 8, 1, 54 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoresItems_StoreId",
                table: "StoresItems",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoresItems");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
