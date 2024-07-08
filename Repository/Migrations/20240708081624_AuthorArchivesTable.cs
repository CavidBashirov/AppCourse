using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class AuthorArchivesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "GroupTeachers");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "GroupStudents");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "BookAuthors");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "SoftDelete",
                table: "Books",
                newName: "IsDeleted");

            migrationBuilder.CreateTable(
                name: "AuthorArchives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorArchives", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorArchives");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Books",
                newName: "SoftDelete");

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Teachers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "GroupTeachers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "GroupStudents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Groups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Educations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Cities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "BookAuthors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Authors",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
