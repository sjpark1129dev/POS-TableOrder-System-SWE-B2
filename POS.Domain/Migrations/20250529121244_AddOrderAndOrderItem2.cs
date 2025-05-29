using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderAndOrderItem2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemEntity_Orders_OrderId",
                table: "OrderItemEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItemEntity",
                table: "OrderItemEntity");

            migrationBuilder.RenameTable(
                name: "OrderItemEntity",
                newName: "OrderItems");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItemEntity_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItemEntity");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItemEntity",
                newName: "IX_OrderItemEntity_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItemEntity",
                table: "OrderItemEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemEntity_Orders_OrderId",
                table: "OrderItemEntity",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
