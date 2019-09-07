using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ColytonHubApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TalentCapacities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Capacity = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentCapacities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Suburb = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    PostCode = table.Column<int>(nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    IsInterpretorRequired = table.Column<bool>(nullable: false),
                    InterpretorLanguage = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    DateOfArrival = table.Column<DateTime>(nullable: false),
                    IsChildAtSchool = table.Column<bool>(nullable: false),
                    NoOfChildrenAtSchool = table.Column<int>(nullable: false),
                    EmergencyName = table.Column<string>(nullable: false),
                    Relationship = table.Column<string>(nullable: false),
                    EmergencyPhone = table.Column<int>(nullable: false),
                    OtherProg = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    IsPartOfTalentPool = table.Column<bool>(nullable: false),
                    PathToResume = table.Column<string>(nullable: true),
                    AreaOfInterest = table.Column<string>(nullable: true),
                    TalentCapacityID = table.Column<int>(nullable: false),
                    IsMyPhotoConsent = table.Column<bool>(nullable: false),
                    PathToMyPhoto = table.Column<string>(nullable: true),
                    Signature = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_TalentCapacities_TalentCapacityID",
                        column: x => x.TalentCapacityID,
                        principalTable: "TalentCapacities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    IsChildPhotoConsent = table.Column<bool>(nullable: false),
                    PathOfPhoto = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Language_People",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language_People", x => new { x.LanguageId, x.PersonId });
                    table.ForeignKey(
                        name: "FK_Language_People_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Language_People_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Children_PersonId",
                table: "Children",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Language_People_PersonId",
                table: "Language_People",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_People_CountryId",
                table: "People",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_People_TalentCapacityID",
                table: "People",
                column: "TalentCapacityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "Language_People");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "TalentCapacities");
        }
    }
}
