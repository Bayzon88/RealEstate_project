using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate_API.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("74c6a851-2f1a-4b69-8328-3cf1dab6a365"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("b8c83bf1-c13d-48c1-b3a2-0beaede472e1"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("c213d561-3880-4eeb-9244-e571ae8e1b67"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("d7ad28ba-6cde-49eb-bb5e-f427e004d49a"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctId", "CreationTime", "Email", "Gender", "LastLoginTime", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { new Guid("6eb83cd6-b0e9-46d6-b3d0-e8a107bf8041"), new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8474), "tuyichen90@gmail.com", "Female", new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8476), "Tuyi Chen", "tuyi1234", 123456789L },
                    { new Guid("9c86a843-c779-414e-856b-bd8ddb091674"), new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8435), "beltranalvaro08@gmail.com", "Male", new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8471), "Alvaro Beltran", "alvaro1234", 123456789L },
                    { new Guid("bb1ac6f0-c031-4866-bff9-c2bbc3abd893"), new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8497), "antonvinokurov101@gmail.com", "Male", new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8499), "Anton Vinokurov", "anton1234", 123456789L },
                    { new Guid("cccdde63-2be9-40d3-a74a-4dcf07c674f1"), new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8479), "katya.menesesr@gmail.com", "Female", new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8481), "Katya Meneses", "katya1234", 123456789L }
                });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 1,
                column: "ListingTime",
                value: new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 2,
                column: "ListingTime",
                value: new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 3,
                column: "ListingTime",
                value: new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 4,
                column: "ListingTime",
                value: new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 5,
                column: "ListingTime",
                value: new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 6,
                column: "ListingTime",
                value: new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 7,
                column: "ListingTime",
                value: new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 8,
                column: "ListingTime",
                value: new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 9,
                column: "ListingTime",
                value: new DateTime(2023, 5, 23, 0, 11, 11, 444, DateTimeKind.Local).AddTicks(8649));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("6eb83cd6-b0e9-46d6-b3d0-e8a107bf8041"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("9c86a843-c779-414e-856b-bd8ddb091674"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("bb1ac6f0-c031-4866-bff9-c2bbc3abd893"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("cccdde63-2be9-40d3-a74a-4dcf07c674f1"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctId", "CreationTime", "Email", "Gender", "LastLoginTime", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { new Guid("74c6a851-2f1a-4b69-8328-3cf1dab6a365"), new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6416), "tuyichen90@gmail.com", "Female", new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6418), "Tuyi Chen", "tuyi1234", 123456789L },
                    { new Guid("b8c83bf1-c13d-48c1-b3a2-0beaede472e1"), new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6379), "beltranalvaro08@gmail.com", "Male", new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6413), "Alvaro Beltran", "alvaro1234", 123456789L },
                    { new Guid("c213d561-3880-4eeb-9244-e571ae8e1b67"), new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6425), "antonvinokurov101@gmail.com", "Male", new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6427), "Anton Vinokurov", "anton1234", 123456789L },
                    { new Guid("d7ad28ba-6cde-49eb-bb5e-f427e004d49a"), new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6421), "katya.menesesr@gmail.com", "Female", new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6423), "Katya Meneses", "katya1234", 123456789L }
                });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 1,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 2,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 3,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 4,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 5,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 6,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 7,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 8,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 9,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 22, 20, 39, 266, DateTimeKind.Local).AddTicks(6618));
        }
    }
}
