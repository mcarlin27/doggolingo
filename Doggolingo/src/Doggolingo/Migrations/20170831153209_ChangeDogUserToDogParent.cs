using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Doggolingo.Migrations
{
    public partial class ChangeDogUserToDogParent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogParents_UserId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_UserId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Dogs");

            migrationBuilder.AddColumn<int>(
                name: "DogParentUserId",
                table: "Dogs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogParentUserId",
                table: "Dogs",
                column: "DogParentUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogParents_DogParentUserId",
                table: "Dogs",
                column: "DogParentUserId",
                principalTable: "DogParents",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogParents_DogParentUserId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_DogParentUserId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "DogParentUserId",
                table: "Dogs");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Dogs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_UserId",
                table: "Dogs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogParents_UserId",
                table: "Dogs",
                column: "UserId",
                principalTable: "DogParents",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
