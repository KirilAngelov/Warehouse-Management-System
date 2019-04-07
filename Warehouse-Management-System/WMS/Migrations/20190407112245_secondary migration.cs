using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class secondarymigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
              name: "Employees",
              columns: table => new
              {
                  Employee_Id = table.Column<int>(nullable: false)
                      .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                  First_Name = table.Column<string>(nullable: false),
                  Last_Name = table.Column<string>(nullable: false),
                  Age = table.Column<int>(nullable: false),
                  Years_Of_Service = table.Column<int>(nullable: false),
                  Salary = table.Column<decimal>(nullable: false),
                  Position = table.Column<string>(nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Employees", x => x.Employee_Id);
              });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
