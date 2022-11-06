using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddProduct3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ee0cb73-17e6-40c2-bce3-3f8af53cbaa6", "AQAAAAEAACcQAAAAEHbV3YqobK0RF1bGZF+f08w3k5ghD6VeJTOOTSdv2HEMTyXY9oFMcwV3od6zSOudeA==", "45f72365-43e5-403d-804d-ac69ce1ee9ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "440c542b-b776-4985-8da1-f19d42657623", "74966dac-addd-4d58-a5e9-261715162959" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "967e3cd4-2c10-46a1-85b6-c6bb5814dd65", "47172ca0-65e6-4bac-b49a-44158bd3a989" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef820799-5db5-4084-b061-e97a8ef2f1b4", "50486fba-44ec-4483-98ef-86f87a0dd95b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Bottle sterilizer");

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
                    { 8, 4, "Steriliser, dryer and bottle storage in a purified environment", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/sassy-sassy-light-up-rainbow-reel-spinning-developmental-tray-toy-6-months-32104676753573_1024x1024@2x.jpg?v=1638282346", "Babymoov Turbo Pure Steriliser and Bottle Dryer - Blue", 89.99m },
                    { 9, 5, "Thanks to Digital Green Technology, the Premium Care baby monitor combines the performance of digital technology (zero interference and clear digital sound) with low-wave emission levels to ensure baby is safe at all times. The stylish LCD touchscreen is easy to use, and the added bonus of the nightlight assist with settling baby too.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/babymoov-baby-monitors-babymoov-premium-care-audio-monitor-black-white-32248768888997_1024x1024@2x.jpg?v=1640097653", "Babymoov Premium Care Audio Monitor - Black & White", 81.99m },
                    { 10, 5, "The Angelcare® AC527 Baby Movement Monitor, with Video is a dependable, trusted and beautifully designed baby care essential. It has Angelcare®'s new 40% smaller Wireless SensAsure Movement Sensor Pad. Rest assured, the pad offers the exact same precise levels of movement detection.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/angelcare-baby-monitors-angelcare-ac527-baby-movement-monitor-with-video-sound-31667682934949_1024x1024@2x.jpg?v=1634220465", "Angelcare AC527 Baby Movement Monitor with Video & Sound", 121.99m },
                    { 11, 6, "Introduce your little one to their nursery in soft, reassuring style. Mamas & Papas' Welcome to the World interiors collection is our much-loved, bestselling range. This new-look collection embraces soft pastel shades and cute woodland characters for pieces that are soft to touch and gentle against baby's sensitive skin.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/mamas-papas-dreampod-sleep-bags-swaddling-welcome-to-the-world-farm-yard-dreampod-blue-farm-print-29480443084965_1024x1024@2x.jpg?v=1628835782", "Welcome to the World Farm Yard Dreampod - Blue Farm Print", 25m },
                    { 12, 6, "Keep your little one wrapped up warm this winter with our two pack of Dream Pod Sleep bags. Perfect for those colder nights, the zip and button-fastening design is safer than loose bedding, while the 2.5 Tog padding is sure to keep them toasty. Made with 100% jersey cotton, they're super soft and cosy, while also being gentle against baby's sensitive skin.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/mamas-papas-dreampod-sleep-bags-swaddling-dreampod-sleep-bag-0-6-months-2-5-tog-pack-of-2-balloon-18930240389285_1024x1024@2x.jpg?v=1619068305", "Dreampod Sleep Bag 0-6 Months 2.5 Tog (Pack of 2) - Balloon", 45m },
                    { 13, 7, "Our Complete Feeding Set contains everything you need to make baby feeding straightforward. Closer to Nature bottles have the most breast-like teat ever made. It flexes and feels like mum, so switching between breast and bottle feeding is a stress-free experience. Our Advanced Steam Steriliser can sterilise up to 6 bottles in just 5 minutes, killing 99.9% of germs that may linger in bottles, teats, breast pumps and other baby feeding accessories.", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/tommee-tippee-bottle-feeding-tommee-tippee-complete-feeding-kit-white-29069097992357_1024x1024@2x.jpg?v=1628424110", "Tommee Tippee Complete Feeding Kit White", 28m },
                    { 14, 7, "The kit includes our Advanced Steam Steriliser which can sterilise up to 6 bottles in just 5 minutes flat, killing 99.9% of germs that may linger in bottles, teats, breast pumps and other baby feeding accessories. ", "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/tommee-tippee-bottle-feeding-tommee-tippee-anti-colic-complete-feeding-kit-white-29071235186853_1024x1024@2x.jpg?v=1628434206", "Tommee Tippee Anti Colic Complete Feeding Kit - White", 78m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac41ff9d-6a5e-4100-8fa0-78ea0a1c6932", "AQAAAAEAACcQAAAAEC74VagqeN7KkC4ZN0xzywmkDl63rQO0xomWxbyHf18uYl2auSBb2KnJyroecKixrg==", "40af0638-201d-44b3-9368-895cf12ddc40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6fff621-a8fd-4a8d-92be-72e9122a23a2", "16dec308-796e-4b51-a819-5fee41a0989a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac2bf691-10bc-42f3-8898-f3d33dbe0d43", "e50976e4-844d-450e-a6aa-9c802871336d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "746e9b06-667b-45cd-bbd6-cdf4e3536df0", "42971d98-18a3-4888-9621-9d8c909cf46b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Car Seats");
        }
    }
}
