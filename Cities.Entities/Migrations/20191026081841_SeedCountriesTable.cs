using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cities.Entities.Migrations
{
    public partial class SeedCountriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[] { 1, new DateTime(2019, 10, 26, 10, 18, 41, 248, DateTimeKind.Local).AddTicks(4842), new DateTime(2019, 10, 26, 10, 18, 41, 250, DateTimeKind.Local).AddTicks(541), "Austrija" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[] { 2, new DateTime(2019, 10, 26, 10, 18, 41, 250, DateTimeKind.Local).AddTicks(2316), new DateTime(2019, 10, 26, 10, 18, 41, 250, DateTimeKind.Local).AddTicks(2323), "Bosna i Hercegovina" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[] { 3, new DateTime(2019, 10, 26, 10, 18, 41, 250, DateTimeKind.Local).AddTicks(2441), new DateTime(2019, 10, 26, 10, 18, 41, 250, DateTimeKind.Local).AddTicks(2444), "Hrvatska" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[] { 4, new DateTime(2019, 10, 26, 10, 18, 41, 250, DateTimeKind.Local).AddTicks(2457), new DateTime(2019, 10, 26, 10, 18, 41, 250, DateTimeKind.Local).AddTicks(2458), "Slovenija" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[] { 5, new DateTime(2019, 10, 26, 10, 18, 41, 250, DateTimeKind.Local).AddTicks(2468), new DateTime(2019, 10, 26, 10, 18, 41, 250, DateTimeKind.Local).AddTicks(2469), "Srbija" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[] { 6, new DateTime(2019, 10, 26, 10, 18, 41, 250, DateTimeKind.Local).AddTicks(2481), new DateTime(2019, 10, 26, 10, 18, 41, 250, DateTimeKind.Local).AddTicks(2483), "Mađarska" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
