using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfConstruction = table.Column<int>(type: "int", nullable: false),
                    NumberOfStudent = table.Column<int>(type: "int", nullable: false),
                    NumberOfTeacher = table.Column<int>(type: "int", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassLevel = table.Column<int>(type: "int", nullable: false),
                    ClassBranch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ParentSurname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ParentPhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Adress", "CreatedTime", "DateOfConstruction", "MailAdress", "Name", "NumberOfStudent", "NumberOfTeacher", "PhoneNumber", "SchoolType", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "Uluyazi Cankiri/Turkiye", new DateTime(2023, 3, 14, 18, 23, 55, 587, DateTimeKind.Local).AddTicks(7921), 2007, "caku@caku.com", "Cankiri Karatekin Universitesi", 17000, 250, "1234567890", "Universite", null },
                    { 2, "Maltepe/Istanbul", new DateTime(2023, 3, 14, 18, 23, 55, 587, DateTimeKind.Local).AddTicks(7934), 2010, "maltepe@info.com", "Maltepe Universitesi", 7000, 100, "1234567890", "Universitesi", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "ClassBranch", "ClassLevel", "CreatedTime", "DateOfBirth", "Gender", "Name", "ParentName", "ParentPhoneNumber", "ParentSurname", "PhoneNumber", "SchoolId", "Surname", "UpdateTime" },
                values: new object[,]
                {
                    { 1, 21, "Computer Engineer", 2, new DateTime(2023, 3, 14, 18, 23, 55, 587, DateTimeKind.Local).AddTicks(8081), "17/01/2002", "E", "Ferhat", "Ali", "1234567890", "Cakmakoglu", "1234567890", 1, "Cakmakoglu", null },
                    { 2, 20, "Computer Engineer", 2, new DateTime(2023, 3, 14, 18, 23, 55, 587, DateTimeKind.Local).AddTicks(8084), "20/10/2002", "E", "Sakir", "Bilmiyom", "1234567890", "Ayitki", "9876541230", 2, "Ayitki", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Age", "Branch", "BranchType", "CreatedTime", "DateOfBirth", "Gender", "Name", "PhoneNumber", "SchoolId", "Surname", "UpdateTime" },
                values: new object[,]
                {
                    { 1, 34, "Computer Since", "Lecturer", new DateTime(2023, 3, 14, 18, 23, 55, 587, DateTimeKind.Local).AddTicks(8192), "20/07/1989", "E", "Selim", "1234567890", 1, "Buyrukoglu", null },
                    { 2, 44, "Network Since", "Professor Lecturer", new DateTime(2023, 3, 14, 18, 23, 55, 587, DateTimeKind.Local).AddTicks(8194), "10/11/1989", "E", "Kazim", "1478523690", 2, "Nalburoglu", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolId",
                table: "Teachers",
                column: "SchoolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
