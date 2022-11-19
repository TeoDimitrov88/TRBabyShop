using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddDetailsButton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c95f880-69d2-4ee6-8e39-93508c6cb65f", "AQAAAAEAACcQAAAAECYPi05QZQGs6l57LEF8ZsJRg0pqXKkLxINCL92wh82zkEVQMs5zf678Wfb3dllq2A==", "24807d85-b314-4765-8ca9-3e4775ccb1f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43342503-df48-4a57-9f3b-b57b78a82830", "f8ffdf20-06f0-49ba-90b8-c46e55ab4d11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dfada54a-211c-431f-884f-f748d8ad364c", "a633cc8c-7228-4428-a6f2-b93e9f3972d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82baf9b5-9909-4b59-871b-9a184d44cc9d", "0e435728-59c7-48dd-9c98-89c608d64333" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 16, 26, 46, 813, DateTimeKind.Local).AddTicks(755));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
