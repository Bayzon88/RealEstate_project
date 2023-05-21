using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate_API.Migrations
{
    /// <inheritdoc />
    public partial class addListings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("8538a40e-c8c7-4504-aa64-84c90b885617"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("971e239d-e109-4c0e-88a0-0b5db88da809"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("c3b8471d-a8b1-45c7-bd21-e3b13aca2125"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("ecfec008-80f0-4025-8d48-90f90b682655"));

            migrationBuilder.CreateTable(
                name: "HouseTypes",
                columns: table => new
                {
                    HouseTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseTypes", x => x.HouseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Listings",
                columns: table => new
                {
                    ListingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandlordId = table.Column<int>(type: "int", nullable: false),
                    HouseTypeId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalArea = table.Column<double>(type: "float", nullable: false),
                    BedroomNo = table.Column<int>(type: "int", nullable: false),
                    WashroomNo = table.Column<int>(type: "int", nullable: false),
                    ParkingNo = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentalPrice = table.Column<double>(type: "float", nullable: false),
                    ListingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidDays = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listings", x => x.ListingId);
                    table.ForeignKey(
                        name: "FK_Listings_HouseTypes_HouseTypeId",
                        column: x => x.HouseTypeId,
                        principalTable: "HouseTypes",
                        principalColumn: "HouseTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctId", "CreationTime", "Email", "Gender", "LastLoginTime", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { new Guid("1ef4c507-437a-49cb-bd6e-7e0b2f48c80e"), new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3572), "katya.menesesr@gmail.com", "Female", new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3574), "Katya Meneses", "katya1234", 123456789L },
                    { new Guid("7ff64216-4433-47c0-80c6-4cf57da15deb"), new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3577), "antonvinokurov101@gmail.com", "Male", new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3578), "Anton Vinokurov", "anton1234", 123456789L },
                    { new Guid("a0445060-ade5-4c45-93e5-b4a53785b0e7"), new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3568), "tuyichen90@gmail.com", "Female", new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3570), "Tuyi Chen", "tuyi1234", 123456789L },
                    { new Guid("c903e2ee-f6b8-43bf-acbc-d5dce2d05a09"), new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3533), "beltranalvaro08@gmail.com", "Male", new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3565), "Alvaro Beltran", "alvaro1234", 123456789L }
                });

            migrationBuilder.InsertData(
                table: "HouseTypes",
                columns: new[] { "HouseTypeId", "Type" },
                values: new object[,]
                {
                    { 1, "Detached House" },
                    { 2, "Semi-Detached House" },
                    { 3, "Townhouse" },
                    { 4, "Bungalow" },
                    { 5, "Split-level House" },
                    { 6, "Cottage" },
                    { 7, "Condominium" },
                    { 8, "Apartment" },
                    { 9, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "ListingId", "Address", "BedroomNo", "Description", "HouseTypeId", "LandlordId", "ListingTime", "ParkingNo", "RentalPrice", "Status", "TotalArea", "ValidDays", "WashroomNo" },
                values: new object[,]
                {
                    { 1, "1080 Mississauga Road, Mississauga, ON", 5, "Beautiful detached house with simple furniture provided", 1, 1, new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3710), 3, 2400.0, true, 240.0, 30, 5 },
                    { 2, "2072 Dundas Road West, Mississauga, ON", 5, "Beautiful semi-detached house with simple furniture provided", 2, 1, new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3717), 2, 2300.0, true, 200.0, 30, 5 },
                    { 3, "1688 Mississauga Vally, Mississauga, ON", 5, "Beautiful townhouse with simple furniture provided", 3, 1, new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3720), 2, 2300.0, true, 200.0, 30, 3 },
                    { 4, "568 Burnhamthorpe Road West, Mississauga, ON", 3, "Beautiful Bungalow", 4, 1, new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3722), 1, 2200.0, true, 180.0, 30, 3 },
                    { 5, "1266 Erindale Station Road, Mississauga, ON", 3, "Beautiful split-level House", 5, 1, new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3724), 1, 2200.0, true, 170.0, 30, 3 },
                    { 6, "760 Dunlop Street East, Barrie, ON", 4, "Beautiful cottage with a small yard", 6, 1, new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3728), 2, 2800.0, true, 160.0, 30, 4 },
                    { 7, "640 Grand Park Drive, Mississauga, ON", 2, "Beautiful condominium with security", 7, 1, new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3730), 1, 1800.0, true, 80.0, 30, 2 },
                    { 8, "395 Wolfedale Road, Mississauga, ON", 2, "Beautiful apartment", 8, 1, new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3732), 1, 1600.0, true, 80.0, 30, 2 },
                    { 9, "115 Eighth Line, Oakville, ON", 5, "Nothing special", 9, 1, new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3735), 3, 2400.0, true, 240.0, 30, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Listings_HouseTypeId",
                table: "Listings",
                column: "HouseTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Listings");

            migrationBuilder.DropTable(
                name: "HouseTypes");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("1ef4c507-437a-49cb-bd6e-7e0b2f48c80e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("7ff64216-4433-47c0-80c6-4cf57da15deb"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("a0445060-ade5-4c45-93e5-b4a53785b0e7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("c903e2ee-f6b8-43bf-acbc-d5dce2d05a09"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctId", "CreationTime", "Email", "Gender", "LastLoginTime", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { new Guid("8538a40e-c8c7-4504-aa64-84c90b885617"), new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4124), "katya.menesesr@gmail.com", "Female", new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4125), "Katya Meneses", "katya1234", 123456789L },
                    { new Guid("971e239d-e109-4c0e-88a0-0b5db88da809"), new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4128), "antonvinokurov101@gmail.com", "Male", new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4130), "Anton Vinokurov", "anton1234", 123456789L },
                    { new Guid("c3b8471d-a8b1-45c7-bd21-e3b13aca2125"), new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4079), "beltranalvaro08@gmail.com", "Male", new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4116), "Alvaro Beltran", "alvaro1234", 123456789L },
                    { new Guid("ecfec008-80f0-4025-8d48-90f90b682655"), new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4119), "tuyichen90@gmail.com", "Female", new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4121), "Tuyi Chen", "tuyi1234", 123456789L }
                });
        }
    }
}
