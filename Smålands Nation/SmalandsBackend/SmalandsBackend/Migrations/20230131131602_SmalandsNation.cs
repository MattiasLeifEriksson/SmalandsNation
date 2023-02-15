using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmalandsBackend.Migrations
{
    public partial class SmalandsNation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_images", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name", "Picture", "Role" },
                values: new object[,]
                {
                    { 1, "Gabriella Långbergs", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Ordförande" },
                    { 2, "Eric Sandberg", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Vice-Ordförande" },
                    { 3, "Oliver Nordwall", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Ekonomiansvarig" },
                    { 4, "Andre Franzen", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Festansvarig" },
                    { 5, "Dag Mattson", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Fest-och Utskottsansvarig" },
                    { 6, "Amanda Sten", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Festansvarig" },
                    { 7, "Linus Johansson", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Aktivitets-och Utskottsansvarig" },
                    { 8, "Mia Parkkinen", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Aktivitetsansvarig" },
                    { 9, "Mårten Stridh", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Housemoose" },
                    { 10, "Philip Giselson", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Band och PA" },
                    { 11, "Cornelis Blom", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Band/PA-och Jobbansvarig" },
                    { 12, "Filippa Lindblom", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Info/Webb/PR" },
                    { 13, "Josefin Augustson", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Samarbete" },
                    { 14, "Behiye Kaya", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Samarbete" },
                    { 15, "Melvin Johnsson", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Sivansansvarig" },
                    { 16, "Ramazan Soyal", "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Sivansansvarig" }
                });

            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "Id", "Description", "Height", "PictureUrl", "Title", "Width" },
                values: new object[,]
                {
                    { 1, "Generic Image", 50, "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Test image", 50 },
                    { 2, "Generic Image2", 50, "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Image", 50 },
                    { 3, "Generic Image3", 50, "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU", "Test imag3", 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropTable(
                name: "images");
        }
    }
}
