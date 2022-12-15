using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProducts",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProducts", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_UserProducts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e46a2abc-d6e9-4333-a560-989dc89f5797", "3c11d546-b3de-4339-90ec-a6d4e3685b82", "customer", "CUSTOMER" },
                    { "NU89ca4e53-4fbf-46de-93e3-ee20568d4833LL", "8a08ec17-5c95-4a13-9372-4b65eb05f596", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04ba4719-a5ce-478d-b36d-169ffe19e118", 0, "c4b424df-10ea-40dc-ad2d-f9f888c65092", "teo88@abv.bg", false, false, null, "TEO88@ABV.BG", "TEODOR88", "AQAAAAEAACcQAAAAEDegVuqTC9FB3kvnarza1/1CIbOvnYI8Q5oGdJXVezY9QxhlQhbmCIhyHsPgtxvHtQ==", null, false, "c3e56b6c-d10e-4e58-949d-87b283ec0a66", false, "teodor88" },
                    { "1163da51-2369-4b12-aef5-86c360e358de", 0, "b95449a3-c60a-4bba-af6c-5513535663ad", "admin@abv.bg", false, false, null, "ADMIN@ABV.BG", "ADMIN", "AQAAAAEAACcQAAAAEJx9mr31/9BCIjEdx+uyEQFWbDnLIGSLxPX9sNMCQZ+5D67hZYmskZNjzt8KQbZhag==", null, false, "2827a33a-2d95-47a3-9fac-1d3555163633", false, "admin" },
                    { "c225f1de-8898-473c-8b8d-484a5034beea", 0, "52db6c07-2eb9-4df7-b6b9-3a0687f35f98", "tina93@abv.bg", false, false, null, "TINA93@ABV.BG", "TINA93", "AQAAAAEAACcQAAAAEM3t2ZZUi84CUY0nZbBZ44XSLuPzYHTjnDzLZPtjpuaVEJ6L2MRuhRRkqcQYRMoSEA==", null, false, "d08be54c-9653-4542-ad0c-b4acbf7969f8", false, "tina93" },
                    { "cd0f2b40-9353-405c-ae22-c1097419f287", 0, "8cb0fbb6-e8cc-4630-814c-abe6c189300c", "hristo80@abv.bg", false, false, null, "HRISTO80@ABV.BG", "HRISTO80", "AQAAAAEAACcQAAAAEAvR+8OIBfcu5ZKfykRiS16T0xackwet2naGDoNtSgd6xWgRMvy4TrOEkn8rLG3dFw==", null, false, "536f38d6-9af4-4f54-b600-d15168dda991", false, "hristo80" },
                    { "d381c77f-aabf-46bd-80e3-cf9ee84a668b", 0, "869cba6e-df31-4857-b4d3-9931b6ea67be", "ivan89@abv.bg", false, false, null, "IVAN89@ABV.BG", "IVAN89", "AQAAAAEAACcQAAAAEHh2EvVuWKt1Xupn+kkoUIzCZF1Cu93gOI4StJdlzITCl+toyQKP0ZiUSllL/UW5GQ==", null, false, "eca5b4b6-76f6-4cb5-a74b-6deb488ce6f1", false, "ivan89" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Books" },
                    { 2, "Car seats" },
                    { 3, "Bath toys" },
                    { 4, "Bottle sterilizer" },
                    { 5, "Baby cameras" },
                    { 6, "Sleep bag" },
                    { 7, "Bottle feeding" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e46a2abc-d6e9-4333-a560-989dc89f5797", "04ba4719-a5ce-478d-b36d-169ffe19e118" },
                    { "NU89ca4e53-4fbf-46de-93e3-ee20568d4833LL", "1163da51-2369-4b12-aef5-86c360e358de" },
                    { "e46a2abc-d6e9-4333-a560-989dc89f5797", "c225f1de-8898-473c-8b8d-484a5034beea" },
                    { "e46a2abc-d6e9-4333-a560-989dc89f5797", "cd0f2b40-9353-405c-ae22-c1097419f287" },
                    { "e46a2abc-d6e9-4333-a560-989dc89f5797", "d381c77f-aabf-46bd-80e3-cf9ee84a668b" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Dip me in water and watch me change colour", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/house-of-marbles-books-baby-touch-magic-bath-book-33551194849445_1024x1024@2x.jpg?v=1664889397", "Baby Touch Magic Bath Book", 8.99m },
                    { 2, 1, "Filled with beautiful, quirky illustrations and clever read-aloud rhyme, grown-ups will love reading this book to their children at any age as they lovingly consider all the possibilities that lie ahead. Its enduring message of love and acceptance as children grow and change is both universal and poignant, and is one to share over and over again.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/house-of-marbles-books-the-wonderful-things-you-will-be-book-33551190360229_1024x1024@2x.jpg?v=1664889390", "The Wonderful Things You Will Be - Book", 13.99m },
                    { 3, 2, "Bugaboo Turtle Air by Nuna is our ultralight car seat solution for safely transporting your newborn, from their very first ride to the everyday journeys to follow. Designed in collaboration with premium brand Nuna, it offers top comfort for your baby and seamless integration with your Bugaboo stroller. This item includes the car seat (you can purchase the Bugaboo 360 Base separately).", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/bugaboo-bugaboo-turtle-air-by-nuna-car-seat-black-33556696203429_1024x1024@2x.jpg?v=1664980829", "Bugaboo Turtle Air by Nuna Car Seat - Black", 199m },
                    { 4, 2, "The Mica Eco has been designed to provide convenience, safety and sustainability. The seat?s 360° rotation makes it much easier to get your children in and out of the car every day, without straining your back. Made to meet the highest i-Size safety standards, the Mica Eco features G-CELL Side Impact Protection and Eco Care 100% recycled fabrics, to safeguard a better tomorrow.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/maxi-cosi-maxi-cosi-mica-eco-i-size-authentic-black-33536085917861_1024x1024@2x.jpg?v=1664532268", "Maxi-Cosi Mica Eco i-Size - Authentic Black", 259.99m },
                    { 5, 3, "Crafted from 100% textured silicone, this petal shaped teether will give your little one's sore gums relief whilst they're teething. Each petal offers a different texture to explore, with a rainbow of colours and a rattle inside to add visual and sound stimulation.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/sassy-sassy-silicone-flower-rattle-teether-32104732688549_1024x1024@2x.jpg?v=1638282702", "Sassy Silicone Flower Rattle Teether", 8.49m },
                    { 6, 3, "Stick the suction base of this spinning toy to any flat smooth surface and spin the wheel. The soft exterior bumps make spinning easy for baby, who will love watching the rainbow appear as the wheel spins. ", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/sassy-sassy-light-up-rainbow-reel-spinning-developmental-tray-toy-6-months-32104676753573_1024x1024@2x.jpg?v=1638282346", "Sassy Light-Up Rainbow Reel Spinning Developmental Tray Toy - 6+ Months", 13.79m },
                    { 7, 4, "This innovation from MAM Baby features six valuable functions all in one product. Forget having to invest and store a steriliser and a bottle warmer separately, simply choose MAM for all your needs.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/mam-bottle-feeding-mam-baby-6-in-1-electric-steriliser-large-bottle-starter-bundle-32845940195493_1024x1024@2x.jpg?v=1652788714", "MAM Baby 6-in-1 Electric Steriliser & Large Bottle Starter Bundle - Matt Taupe", 165m },
                    { 8, 4, "Steriliser, dryer and bottle storage in a purified environment", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/babymoov-babymoov-turbo-pure-steriliser-and-bottle-dryer-blue-33002899701925_1024x1024@2x.jpg?v=1656496367", "Babymoov Turbo Pure Steriliser and Bottle Dryer - Blue", 89.99m },
                    { 9, 5, "Thanks to Digital Green Technology, the Premium Care baby monitor combines the performance of digital technology (zero interference and clear digital sound) with low-wave emission levels to ensure baby is safe at all times. The stylish LCD touchscreen is easy to use, and the added bonus of the nightlight assist with settling baby too.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/babymoov-baby-monitors-babymoov-premium-care-audio-monitor-black-white-32248768888997_1024x1024@2x.jpg?v=1640097653", "Babymoov Premium Care Audio Monitor - Black & White", 81.99m },
                    { 10, 5, "The Angelcare® AC527 Baby Movement Monitor, with Video is a dependable, trusted and beautifully designed baby care essential. It has Angelcare®'s new 40% smaller Wireless SensAsure Movement Sensor Pad. Rest assured, the pad offers the exact same precise levels of movement detection.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/angelcare-baby-monitors-angelcare-ac527-baby-movement-monitor-with-video-sound-31667682934949_1024x1024@2x.jpg?v=1634220465", "Angelcare AC527 Baby Movement Monitor with Video & Sound", 121.99m },
                    { 11, 6, "Introduce your little one to their nursery in soft, reassuring style. Mamas & Papas' Welcome to the World interiors collection is our much-loved, bestselling range. This new-look collection embraces soft pastel shades and cute woodland characters for pieces that are soft to touch and gentle against baby's sensitive skin.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/mamas-papas-dreampod-sleep-bags-swaddling-welcome-to-the-world-farm-yard-dreampod-blue-farm-print-29480443084965_1024x1024@2x.jpg?v=1628835782", "Welcome to the World Farm Yard Dreampod - Blue Farm Print", 25m },
                    { 12, 6, "Keep your little one wrapped up warm this winter with our two pack of Dream Pod Sleep bags. Perfect for those colder nights, the zip and button-fastening design is safer than loose bedding, while the 2.5 Tog padding is sure to keep them toasty. Made with 100% jersey cotton, they're super soft and cosy, while also being gentle against baby's sensitive skin.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/mamas-papas-dreampod-sleep-bags-swaddling-dreampod-sleep-bag-0-6-months-2-5-tog-pack-of-2-balloon-18930240389285_1024x1024@2x.jpg?v=1619068305", "Dreampod Sleep Bag 0-6 Months 2.5 Tog (Pack of 2) - Balloon", 45m },
                    { 13, 7, "Our Complete Feeding Set contains everything you need to make baby feeding straightforward. Closer to Nature bottles have the most breast-like teat ever made. It flexes and feels like mum, so switching between breast and bottle feeding is a stress-free experience. Our Advanced Steam Steriliser can sterilise up to 6 bottles in just 5 minutes, killing 99.9% of germs that may linger in bottles, teats, breast pumps and other baby feeding accessories.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/tommee-tippee-bottle-feeding-tommee-tippee-complete-feeding-kit-white-29069097992357_1024x1024@2x.jpg?v=1628424110", "Tommee Tippee Complete Feeding Kit White", 28m },
                    { 14, 7, "The kit includes our Advanced Steam Steriliser which can sterilise up to 6 bottles in just 5 minutes flat, killing 99.9% of germs that may linger in bottles, teats, breast pumps and other baby feeding accessories. ", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/tommee-tippee-bottle-feeding-tommee-tippee-anti-colic-complete-feeding-kit-white-29071235186853_1024x1024@2x.jpg?v=1628434206", "Tommee Tippee Anti Colic Complete Feeding Kit - White", 78m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProducts_ProductId",
                table: "UserProducts",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "UserProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
