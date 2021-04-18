using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class blogTipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogTipoId",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BlogTipo",
                columns: table => new
                {
                    BlogTipoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTipo", x => x.BlogTipoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogTipoId",
                table: "Blogs",
                column: "BlogTipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogTipo_BlogTipoId",
                table: "Blogs",
                column: "BlogTipoId",
                principalTable: "BlogTipo",
                principalColumn: "BlogTipoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogTipo_BlogTipoId",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "BlogTipo");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogTipoId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogTipoId",
                table: "Blogs");
        }
    }
}
