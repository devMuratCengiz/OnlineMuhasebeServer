﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMuhasebeServer.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class company_details_updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DatabaseName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ServerName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatabaseName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ServerName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Companies");
        }
    }
}
