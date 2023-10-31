using Microsoft.EntityFrameworkCore.Migrations;

namespace RectangleApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rectangles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    x = table.Column<float>(nullable: false),
                    y = table.Column<float>(nullable: false),
                    width = table.Column<float>(nullable: false),
                    height = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rectangles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 1L, 4f, 2f, 1f, 1f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 128L, 4f, 2f, 128f, 128f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 129L, 4f, 2f, 129f, 129f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 130L, 4f, 2f, 130f, 130f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 131L, 4f, 2f, 131f, 131f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 132L, 4f, 2f, 132f, 132f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 133L, 4f, 2f, 133f, 133f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 134L, 4f, 2f, 134f, 134f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 135L, 4f, 2f, 135f, 135f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 136L, 4f, 2f, 136f, 136f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 137L, 4f, 2f, 137f, 137f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 138L, 4f, 2f, 138f, 138f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 139L, 4f, 2f, 139f, 139f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 140L, 4f, 2f, 140f, 140f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 141L, 4f, 2f, 141f, 141f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 142L, 4f, 2f, 142f, 142f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 143L, 4f, 2f, 143f, 143f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 144L, 4f, 2f, 144f, 144f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 145L, 4f, 2f, 145f, 145f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 146L, 4f, 2f, 146f, 146f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 147L, 4f, 2f, 147f, 147f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 148L, 4f, 2f, 148f, 148f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 127L, 4f, 2f, 127f, 127f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 149L, 4f, 2f, 149f, 149f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 126L, 4f, 2f, 126f, 126f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 124L, 4f, 2f, 124f, 124f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 103L, 4f, 2f, 103f, 103f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 104L, 4f, 2f, 104f, 104f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 105L, 4f, 2f, 105f, 105f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 106L, 4f, 2f, 106f, 106f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 107L, 4f, 2f, 107f, 107f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 108L, 4f, 2f, 108f, 108f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 109L, 4f, 2f, 109f, 109f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 110L, 4f, 2f, 110f, 110f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 111L, 4f, 2f, 111f, 111f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 112L, 4f, 2f, 112f, 112f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 113L, 4f, 2f, 113f, 113f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 114L, 4f, 2f, 114f, 114f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 115L, 4f, 2f, 115f, 115f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 116L, 4f, 2f, 116f, 116f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 117L, 4f, 2f, 117f, 117f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 118L, 4f, 2f, 118f, 118f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 119L, 4f, 2f, 119f, 119f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 120L, 4f, 2f, 120f, 120f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 121L, 4f, 2f, 121f, 121f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 122L, 4f, 2f, 122f, 122f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 123L, 4f, 2f, 123f, 123f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 125L, 4f, 2f, 125f, 125f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 102L, 4f, 2f, 102f, 102f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 150L, 4f, 2f, 150f, 150f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 152L, 4f, 2f, 152f, 152f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 178L, 4f, 2f, 178f, 178f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 179L, 4f, 2f, 179f, 179f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 180L, 4f, 2f, 180f, 180f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 181L, 4f, 2f, 181f, 181f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 182L, 4f, 2f, 182f, 182f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 183L, 4f, 2f, 183f, 183f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 184L, 4f, 2f, 184f, 184f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 185L, 4f, 2f, 185f, 185f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 186L, 4f, 2f, 186f, 186f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 187L, 4f, 2f, 187f, 187f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 188L, 4f, 2f, 188f, 188f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 189L, 4f, 2f, 189f, 189f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 190L, 4f, 2f, 190f, 190f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 191L, 4f, 2f, 191f, 191f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 192L, 4f, 2f, 192f, 192f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 193L, 4f, 2f, 193f, 193f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 194L, 4f, 2f, 194f, 194f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 195L, 4f, 2f, 195f, 195f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 196L, 4f, 2f, 196f, 196f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 197L, 4f, 2f, 197f, 197f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 198L, 4f, 2f, 198f, 198f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 177L, 4f, 2f, 177f, 177f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 151L, 4f, 2f, 151f, 151f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 176L, 4f, 2f, 176f, 176f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 174L, 4f, 2f, 174f, 174f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 153L, 4f, 2f, 153f, 153f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 154L, 4f, 2f, 154f, 154f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 155L, 4f, 2f, 155f, 155f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 156L, 4f, 2f, 156f, 156f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 157L, 4f, 2f, 157f, 157f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 158L, 4f, 2f, 158f, 158f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 159L, 4f, 2f, 159f, 159f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 160L, 4f, 2f, 160f, 160f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 161L, 4f, 2f, 161f, 161f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 162L, 4f, 2f, 162f, 162f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 163L, 4f, 2f, 163f, 163f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 164L, 4f, 2f, 164f, 164f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 165L, 4f, 2f, 165f, 165f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 166L, 4f, 2f, 166f, 166f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 167L, 4f, 2f, 167f, 167f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 168L, 4f, 2f, 168f, 168f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 169L, 4f, 2f, 169f, 169f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 170L, 4f, 2f, 170f, 170f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 171L, 4f, 2f, 171f, 171f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 172L, 4f, 2f, 172f, 172f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 173L, 4f, 2f, 173f, 173f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 175L, 4f, 2f, 175f, 175f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 101L, 4f, 2f, 101f, 101f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 100L, 4f, 2f, 100f, 100f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 99L, 4f, 2f, 99f, 99f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 27L, 4f, 2f, 27f, 27f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 28L, 4f, 2f, 28f, 28f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 29L, 4f, 2f, 29f, 29f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 30L, 4f, 2f, 30f, 30f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 31L, 4f, 2f, 31f, 31f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 32L, 4f, 2f, 32f, 32f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 33L, 4f, 2f, 33f, 33f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 34L, 4f, 2f, 34f, 34f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 35L, 4f, 2f, 35f, 35f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 36L, 4f, 2f, 36f, 36f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 37L, 4f, 2f, 37f, 37f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 38L, 4f, 2f, 38f, 38f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 39L, 4f, 2f, 39f, 39f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 40L, 4f, 2f, 40f, 40f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 41L, 4f, 2f, 41f, 41f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 42L, 4f, 2f, 42f, 42f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 43L, 4f, 2f, 43f, 43f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 44L, 4f, 2f, 44f, 44f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 45L, 4f, 2f, 45f, 45f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 46L, 4f, 2f, 46f, 46f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 47L, 4f, 2f, 47f, 47f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 26L, 4f, 2f, 26f, 26f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 48L, 4f, 2f, 48f, 48f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 25L, 4f, 2f, 25f, 25f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 23L, 4f, 2f, 23f, 23f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 2L, 4f, 2f, 2f, 2f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 3L, 4f, 2f, 3f, 3f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 4L, 4f, 2f, 4f, 4f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 5L, 4f, 2f, 5f, 5f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 6L, 4f, 2f, 6f, 6f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 7L, 4f, 2f, 7f, 7f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 8L, 4f, 2f, 8f, 8f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 9L, 4f, 2f, 9f, 9f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 10L, 4f, 2f, 10f, 10f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 11L, 4f, 2f, 11f, 11f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 12L, 4f, 2f, 12f, 12f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 13L, 4f, 2f, 13f, 13f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 14L, 4f, 2f, 14f, 14f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 15L, 4f, 2f, 15f, 15f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 16L, 4f, 2f, 16f, 16f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 17L, 4f, 2f, 17f, 17f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 18L, 4f, 2f, 18f, 18f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 19L, 4f, 2f, 19f, 19f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 20L, 4f, 2f, 20f, 20f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 21L, 4f, 2f, 21f, 21f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 22L, 4f, 2f, 22f, 22f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 24L, 4f, 2f, 24f, 24f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 49L, 4f, 2f, 49f, 49f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 50L, 4f, 2f, 50f, 50f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 51L, 4f, 2f, 51f, 51f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 78L, 4f, 2f, 78f, 78f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 79L, 4f, 2f, 79f, 79f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 80L, 4f, 2f, 80f, 80f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 81L, 4f, 2f, 81f, 81f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 82L, 4f, 2f, 82f, 82f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 83L, 4f, 2f, 83f, 83f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 84L, 4f, 2f, 84f, 84f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 85L, 4f, 2f, 85f, 85f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 86L, 4f, 2f, 86f, 86f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 87L, 4f, 2f, 87f, 87f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 88L, 4f, 2f, 88f, 88f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 89L, 4f, 2f, 89f, 89f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 90L, 4f, 2f, 90f, 90f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 91L, 4f, 2f, 91f, 91f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 92L, 4f, 2f, 92f, 92f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 93L, 4f, 2f, 93f, 93f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 94L, 4f, 2f, 94f, 94f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 95L, 4f, 2f, 95f, 95f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 96L, 4f, 2f, 96f, 96f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 97L, 4f, 2f, 97f, 97f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 98L, 4f, 2f, 98f, 98f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 77L, 4f, 2f, 77f, 77f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 76L, 4f, 2f, 76f, 76f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 75L, 4f, 2f, 75f, 75f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 74L, 4f, 2f, 74f, 74f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 52L, 4f, 2f, 52f, 52f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 53L, 4f, 2f, 53f, 53f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 54L, 4f, 2f, 54f, 54f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 55L, 4f, 2f, 55f, 55f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 56L, 4f, 2f, 56f, 56f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 57L, 4f, 2f, 57f, 57f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 58L, 4f, 2f, 58f, 58f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 59L, 4f, 2f, 59f, 59f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 60L, 4f, 2f, 60f, 60f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 61L, 4f, 2f, 61f, 61f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 199L, 4f, 2f, 199f, 199f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 62L, 4f, 2f, 62f, 62f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 64L, 4f, 2f, 64f, 64f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 65L, 4f, 2f, 65f, 65f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 66L, 4f, 2f, 66f, 66f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 67L, 4f, 2f, 67f, 67f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 68L, 4f, 2f, 68f, 68f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 69L, 4f, 2f, 69f, 69f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 70L, 4f, 2f, 70f, 70f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 71L, 4f, 2f, 71f, 71f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 72L, 4f, 2f, 72f, 72f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 73L, 4f, 2f, 73f, 73f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 63L, 4f, 2f, 63f, 63f });

            migrationBuilder.InsertData(
                table: "rectangles",
                columns: new[] { "Id", "height", "width", "x", "y" },
                values: new object[] { 200L, 4f, 2f, 200f, 200f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rectangles");
        }
    }
}
