﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCost.Migrations
{
    public partial class w1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Productid",
                table: "Priceses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Priceses_Productid",
                table: "Priceses",
                column: "Productid");

            migrationBuilder.AddForeignKey(
                name: "FK_Priceses_Products_Productid",
                table: "Priceses",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Priceses_Products_Productid",
                table: "Priceses");

            migrationBuilder.DropIndex(
                name: "IX_Priceses_Productid",
                table: "Priceses");

            migrationBuilder.DropColumn(
                name: "Productid",
                table: "Priceses");
        }
    }
}
