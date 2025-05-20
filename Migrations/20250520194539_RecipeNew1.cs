using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yemek_Tarifi_Site.Migrations
{
    /// <inheritdoc />
    public partial class RecipeNew1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RecipeList",
                keyColumn: "RecipeName",
                keyValue: null,
                column: "RecipeName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "RecipeName",
                table: "RecipeList",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "RecipeList",
                keyColumn: "RecipeMaterial",
                keyValue: null,
                column: "RecipeMaterial",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "RecipeMaterial",
                table: "RecipeList",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "RecipeList",
                keyColumn: "RecipeExp",
                keyValue: null,
                column: "RecipeExp",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "RecipeExp",
                table: "RecipeList",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RecipeHowPerson",
                table: "RecipeList",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RecipePrepTime",
                table: "RecipeList",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipeHowPerson",
                table: "RecipeList");

            migrationBuilder.DropColumn(
                name: "RecipePrepTime",
                table: "RecipeList");

            migrationBuilder.AlterColumn<string>(
                name: "RecipeName",
                table: "RecipeList",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "RecipeMaterial",
                table: "RecipeList",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "RecipeExp",
                table: "RecipeList",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
