using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WSA_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filaments",
                columns: table => new
                {
                    FilamentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialFull = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filaments", x => x.FilamentId);
                });

            migrationBuilder.InsertData(
                table: "Filaments",
                columns: new[] { "FilamentId", "Description", "Material", "MaterialFull" },
                values: new object[,]
                {
                    { 1, "PLA is a biodegradable thermoplastic derived from renewable resources like corn starch or sugarcane. It is one of the most commonly used filaments in 3D printing due to its ease of use, low warping, and wide availability. PLA is ideal for beginners and is suitable for a variety of applications, including prototypes, models, and decorative items.", "PLA", "Polylactic Acid" },
                    { 2, "ABS is a strong and durable thermoplastic that is commonly used in 3D printing. It is known for its toughness, impact resistance, and ability to withstand higher temperatures compared to PLA. ABS is often used for functional parts, mechanical components, and objects that require strength and durability. However, it can be more challenging to print with due to its tendency to warp and emit fumes during printing.", "ABS", "Acrylonitrile Butadiene Styrene" },
                    { 3, "PETG is a popular filament that combines the ease of use of PLA with the strength and durability of ABS. It is known for its excellent layer adhesion, low warping, and resistance to moisture. PETG is often used for functional parts, mechanical components, and objects that require strength and durability. It is also food-safe and can be used for applications such as water bottles and food containers.", "PETG", "Polyethylene Terephthalate Glycol" },
                    { 4, "TPU is a flexible and elastic filament that is commonly used in 3D printing. It is known for its rubber-like properties, including high elasticity, abrasion resistance, and durability. TPU is often used for applications that require flexibility, such as phone cases, gaskets, and wearable items. It can be more challenging to print with due to its flexibility, but it offers unique possibilities for creative and functional designs.", "TPU", "Thermoplastic Polyurethane" },
                    { 5, "Nylon is a strong and durable filament that is commonly used in 3D printing. It is known for its high strength-to-weight ratio, excellent abrasion resistance, and ability to withstand high temperatures. Nylon is often used for functional parts, mechanical components, and objects that require strength and durability. However, it can be more challenging to print with due to its tendency to absorb moisture from the air, which can affect print quality.", "Nylon", "Polyamide" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filaments");
        }
    }
}
