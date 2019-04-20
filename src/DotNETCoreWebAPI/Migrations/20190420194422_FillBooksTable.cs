using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNETCoreWebAPI.Migrations
{
    public partial class FillBooksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                INSERT INTO Books (
                      Id,
                      Title,
                      Author,
                      ISBN,
                      Year
                  )
                  VALUES (
                      '1',
                      ' The Lord of the Rings: The Fellowship of the Ring',
                      'J. R. R. Tolkien',
                      '0618260269',
                      '2003'
                  );"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"DELETE FROM Books WHERE Id = '1'"
            );
        }
    }
}
