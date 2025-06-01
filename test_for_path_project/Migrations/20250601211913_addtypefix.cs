using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test_for_path_project.Migrations
{
    /// <inheritdoc />
    public partial class addtypefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AAU_INFO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    التخصص = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    الكلية = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    الحقل = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    معدل_القبول = table.Column<float>(type: "real", nullable: true),
                    الساعات = table.Column<int>(type: "int", nullable: true),
                    السعر = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AAU_INFO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEU_INFO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    التخصص = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    الكلية = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    الحقل = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    معدل_القبول = table.Column<float>(type: "real", nullable: true),
                    الساعات = table.Column<int>(type: "int", nullable: true),
                    السعر = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEU_INFO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PHU_INFO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    التخصص = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    الكلية = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    الحقل = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    معدل_القبول = table.Column<float>(type: "real", nullable: true),
                    الساعات = table.Column<int>(type: "int", nullable: true),
                    السعر = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHU_INFO", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AAU_INFO");

            migrationBuilder.DropTable(
                name: "MEU_INFO");

            migrationBuilder.DropTable(
                name: "PHU_INFO");
        }
    }
}
