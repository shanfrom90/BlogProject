using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    PublishDate = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Personal Wellness" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Food" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Plans & Dreams" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 3, "Shannon", "My cat, my mom, my sister, WCCI, a warm place to sleep", 1, "1/31/2021", "Gratitute List" },
                    { 6, "BP", "Whether you are experienced with yoga or brand new, Yoga With Adriene on YouTube is a dream come true. Namaste!", 1, "12/05/2020", "Yoga With Adriene" },
                    { 2, "JP", "I can't believe this only have 5 ingredients! For best results roast the red peppers yourself. You can put this sauce on anything and everything!", 2, "2/12/2021", "Roasted Red Pepper Sauce" },
                    { 5, "Mary", "So easy and delicious! The perfect vegetarian weeknight meal. Tip: Keep fresh basil out of the fridge as it is cold-sensitive.", 2, "03/02/2021", "Creamy Instant Pot Pasta" },
                    { 1, "Shannon", "I want to visit my family in Cincinnati first, and then plan a trip out west, hopefully to Arizona and/or New Mexico", 3, "3/6/2021", "Once I am Vaccinated" },
                    { 4, "Shannon", "I'm going on an 8+ mile hike.", 3, "01/01/2021", "When Winter Is Over" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CategoryId",
                table: "Contents",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
