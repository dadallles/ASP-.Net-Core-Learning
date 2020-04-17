using Microsoft.EntityFrameworkCore.Migrations;

namespace GigHub.Data.Migrations
{
    public partial class GigAddForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gigs_Genres_GenreId",
                table: "Gigs");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Gigs",
                newName: "GenreID");

            migrationBuilder.RenameIndex(
                name: "IX_Gigs_GenreId",
                table: "Gigs",
                newName: "IX_Gigs_GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gigs_Genres_GenreID",
                table: "Gigs",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gigs_Genres_GenreID",
                table: "Gigs");

            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "Gigs",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Gigs_GenreID",
                table: "Gigs",
                newName: "IX_Gigs_GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gigs_Genres_GenreId",
                table: "Gigs",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
