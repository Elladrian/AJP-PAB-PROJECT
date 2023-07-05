using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancialHelper.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OperationDate = table.Column<string>(type: "TEXT", nullable: false),
                    ValueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TransactionType = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    SaldoAfterTransaction = table.Column<decimal>(type: "TEXT", nullable: false),
                    TransactionDescription = table.Column<string>(type: "TEXT", nullable: false),
                    TransactionDescriptionAdditional1 = table.Column<string>(type: "TEXT", nullable: true),
                    TransactionDescriptionAdditional2 = table.Column<string>(type: "TEXT", nullable: true),
                    TransactionDescriptionAdditional3 = table.Column<string>(type: "TEXT", nullable: true),
                    TransactionDescriptionAdditional4 = table.Column<string>(type: "TEXT", nullable: true),
                    TransactionDescriptionAdditional5 = table.Column<string>(type: "TEXT", nullable: true),
                    TransactionDescriptionAdditional6 = table.Column<string>(type: "TEXT", nullable: true),
                    TransactionDescriptionAdditional7 = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankDatas_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BankDatas_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankDatas_CategoryId",
                table: "BankDatas",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BankDatas_UserId",
                table: "BankDatas",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankDatas");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
