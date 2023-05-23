using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate_API.Migrations
{
    /// <inheritdoc />
    public partial class changeListing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("405a3a92-6d4c-4a5b-842f-349e67dba7a7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("72b63d40-b7b1-4679-8950-ffc6f3981bac"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("839dcf85-5dc8-4607-9842-441724357995"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("d7772b51-0595-4fe4-8584-4577d269a032"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("405a3a92-6d4c-4a5b-842f-349e67dba7a7"), new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5569), "antonvinokurov101@gmail.com", "Male", new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5571), "Anton Vinokurov", "anton1234", 123456789L },
                    { new Guid("72b63d40-b7b1-4679-8950-ffc6f3981bac"), new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5560), "tuyichen90@gmail.com", "Female", new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5562), "Tuyi Chen", "tuyi1234", 123456789L },
                    { new Guid("839dcf85-5dc8-4607-9842-441724357995"), new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5524), "beltranalvaro08@gmail.com", "Male", new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5557), "Alvaro Beltran", "alvaro1234", 123456789L },
                    { new Guid("d7772b51-0595-4fe4-8584-4577d269a032"), new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5565), "katya.menesesr@gmail.com", "Female", new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5566), "Katya Meneses", "katya1234", 123456789L }
                });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 1,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 2,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 3,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 4,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 5,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 6,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 7,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 8,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 9,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5746));
        }
    }
}
