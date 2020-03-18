using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dt",
                table: "BlogPosts",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Creator",
                table: "BlogPosts",
                newName: "Slug");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "BlogPosts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BlogPosts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PostsCount",
                table: "BlogPosts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "PostsCount",
                table: "BlogPosts");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "BlogPosts",
                newName: "Dt");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "BlogPosts",
                newName: "Creator");
        }
    }
}
