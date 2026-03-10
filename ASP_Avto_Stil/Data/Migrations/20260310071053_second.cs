using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_Avto_Stil.Data.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_BrandModels_BrandModelsId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Categories_CategoriesId",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_BrandModelsId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "BrandModelsId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "BrandsModelId",
                table: "Parts");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Parts",
                newName: "CategorieId");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "Parts",
                newName: "BrandModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_CategoriesId",
                table: "Parts",
                newName: "IX_Parts_BrandModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_CategorieId",
                table: "Parts",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_BrandModels_BrandModelId",
                table: "Parts",
                column: "BrandModelId",
                principalTable: "BrandModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Categories_CategorieId",
                table: "Parts",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_BrandModels_BrandModelId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Categories_CategorieId",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_CategorieId",
                table: "Parts");

            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Parts",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "BrandModelId",
                table: "Parts",
                newName: "CategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_BrandModelId",
                table: "Parts",
                newName: "IX_Parts_CategoriesId");

            migrationBuilder.AddColumn<int>(
                name: "BrandModelsId",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandsModelId",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Parts_BrandModelsId",
                table: "Parts",
                column: "BrandModelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_BrandModels_BrandModelsId",
                table: "Parts",
                column: "BrandModelsId",
                principalTable: "BrandModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Categories_CategoriesId",
                table: "Parts",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
