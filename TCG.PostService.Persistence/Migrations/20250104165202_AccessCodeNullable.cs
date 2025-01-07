using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCG.PostService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AccessCodeNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "MerchPosts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "AccessCode",
                table: "MerchPosts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");
            
            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Neuf" },
                    { 2, "Presque neuf" },
                    { 3, "Jouees" },
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "MerchPosts",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccessCode",
                table: "MerchPosts",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);
            
            migrationBuilder.DeleteData(
                table: "Grading",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3 });
        }
    }
}
