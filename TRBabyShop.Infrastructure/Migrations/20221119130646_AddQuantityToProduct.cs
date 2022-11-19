using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddQuantityToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "752ee20d-c8bd-46c1-9c6a-7181f4ceddc0", "AQAAAAEAACcQAAAAEFq8o1Z3ihGq7reoofy+m0o7WedDPIM0xBwOzQ6rSa/IvXyZDQLUSlvthe28w0f2mw==", "655c818f-1bb0-42ce-8f2e-71cd53c4cc33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bb49f528-8ed3-4f23-bb83-3b3172631699", "b1bfb3b1-e006-4e6c-b580-ba88b908e0f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "439578e5-dcd4-4238-a276-c9f1fcc980fd", "974629bf-0a6c-4cd6-ba34-6a8448ae1d4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1366e149-c0ec-48ad-8d2f-62941893a22c", "c1557fd0-9db3-4e91-80f2-8222f178017f" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 15, 6, 45, 688, DateTimeKind.Local).AddTicks(3091));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f110ed7f-1d8d-482c-a55c-81d367933480", "AQAAAAEAACcQAAAAENEhXlpoPqIVnTGbSOs24NLe4Os7IudEyLOgUF6S3Y9s4HO7OvcYNxegv26e4cbIKA==", "2486c062-834c-4f38-9c51-d49e2aa2ab7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5e37e43-d5e1-43fc-9433-c71326a9826a", "869376e8-0ce7-4184-87f8-899fc089b656" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b03fdea6-8d8c-4379-9d1f-5a6b833c34fd", "dc4fb875-c353-43e9-bdf4-08f1f758f1d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46197d42-bd86-4d87-92ba-e770d64909b7", "0b5c2b60-d840-4618-bef3-9955b5e8f631" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(574));
        }
    }
}
