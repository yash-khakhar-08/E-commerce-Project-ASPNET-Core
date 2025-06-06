﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketMatrix_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusChangeColumnToOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "StatusChangeDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusChangeDate",
                table: "Orders");
        }
    }
}
