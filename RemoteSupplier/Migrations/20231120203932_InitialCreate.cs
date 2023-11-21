using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RemoteSupplier.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Supplier = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Vendor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => new { x.Id, x.Supplier });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Supplier", "Amount", "Category", "Image", "Name", "Price", "Vendor" },
                values: new object[,]
                {
                    { 20, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 250, "Grocery", "https://picsum.photos/640/480/?image=756", "Table", 1329.3870578110068, "Deckow, Herman and Kautzer" },
                    { 21, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 108, "Kids", "https://picsum.photos/640/480/?image=667", "Keyboard", 4474.0698915317707, "Emard - Bashirian" },
                    { 22, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 247, "Toys", "https://picsum.photos/640/480/?image=241", "Ball", 6202.3518814186727, "Schamberger - Wilkinson" },
                    { 23, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 35, "Jewelery", "https://picsum.photos/640/480/?image=1021", "Table", 8292.7559199861607, "Breitenberg Inc" },
                    { 24, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 220, "Games", "https://picsum.photos/640/480/?image=567", "Pizza", 7710.4242504487638, "Pollich - Nitzsche" },
                    { 25, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 43, "Jewelery", "https://picsum.photos/640/480/?image=690", "Car", 2241.4726759366067, "Senger, Okuneva and Kovacek" },
                    { 26, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 102, "Clothing", "https://picsum.photos/640/480/?image=114", "Computer", 9701.5925517412852, "Heathcote, Rolfson and O'Kon" },
                    { 27, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 71, "Clothing", "https://picsum.photos/640/480/?image=462", "Pizza", 9374.2715246433563, "Gulgowski and Sons" },
                    { 28, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 78, "Baby", "https://picsum.photos/640/480/?image=599", "Ball", 7459.1307043835141, "Bauch, Champlin and Gutkowski" },
                    { 29, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 39, "Health", "https://picsum.photos/640/480/?image=830", "Chicken", 1722.4907978375336, "Quigley, McGlynn and Daniel" },
                    { 30, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 182, "Grocery", "https://picsum.photos/640/480/?image=771", "Fish", 7026.8845280303731, "VonRueden, Kris and Wilkinson" },
                    { 31, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 64, "Clothing", "https://picsum.photos/640/480/?image=482", "Pizza", 9150.4127529857124, "Hahn LLC" },
                    { 32, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 156, "Shoes", "https://picsum.photos/640/480/?image=479", "Table", 2389.0524178144656, "Lesch LLC" },
                    { 33, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 238, "Garden", "https://picsum.photos/640/480/?image=906", "Sausages", 2320.2686098002578, "Hermann LLC" },
                    { 34, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 214, "Music", "https://picsum.photos/640/480/?image=510", "Chips", 2873.1303091936443, "Waters, MacGyver and Walker" },
                    { 35, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 77, "Movies", "https://picsum.photos/640/480/?image=1040", "Bacon", 4228.4168828362399, "Deckow - VonRueden" },
                    { 36, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 124, "Automotive", "https://picsum.photos/640/480/?image=881", "Tuna", 2906.3969344653251, "Schuster LLC" },
                    { 37, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 123, "Computers", "https://picsum.photos/640/480/?image=267", "Ball", 8373.4185596160787, "Kling - Glover" },
                    { 38, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 104, "Toys", "https://picsum.photos/640/480/?image=196", "Bike", 2482.012165525176, "Hayes and Sons" },
                    { 39, "f9503a4d-d6ba-4a6e-b95c-068c71e5a6ea", 122, "Toys", "https://picsum.photos/640/480/?image=78", "Chicken", 3949.2603427208605, "Hilpert and Sons" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
