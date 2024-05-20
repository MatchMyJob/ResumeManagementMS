using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MinimumSalary = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "StudyType",
                columns: table => new
                {
                    StudyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyType", x => x.StudyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.ExperienceId);
                    table.ForeignKey(
                        name: "FK_Experience_Resume_UserId",
                        column: x => x.UserId,
                        principalTable: "Resume",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeSkill",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSkill", x => new { x.UserId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ResumeSkill_Resume_UserId",
                        column: x => x.UserId,
                        principalTable: "Resume",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumeSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Study",
                columns: table => new
                {
                    StudyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudyTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StarDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Study", x => x.StudyId);
                    table.ForeignKey(
                        name: "FK_Study_Resume_UserId",
                        column: x => x.UserId,
                        principalTable: "Resume",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Study_StudyType_StudyTypeId",
                        column: x => x.StudyTypeId,
                        principalTable: "StudyType",
                        principalColumn: "StudyTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Resume",
                columns: new[] { "UserId", "Description", "Image", "MinimumSalary" },
                values: new object[,]
                {
                    { new Guid("13e82a47-9bfe-4170-b94e-8ad3cbb13086"), "Cv2", "...", 300 },
                    { new Guid("189e1d58-3c3d-4b45-9156-9bf898cecec9"), "Cv3", "...", 1000 },
                    { new Guid("c5aa74a3-416d-411a-989e-b06c6ba067b6"), "Cv1", "...", 100 }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "SkillId", "Name" },
                values: new object[,]
                {
                    { 1, "Java" },
                    { 2, "Javascript" },
                    { 3, "C#" },
                    { 4, "Python" },
                    { 5, "Ruby" },
                    { 6, "PHP" },
                    { 7, "Swift" },
                    { 8, "Go" },
                    { 9, "Rust" },
                    { 10, "Kotlin" },
                    { 11, "TypeScript" },
                    { 12, "C++" },
                    { 13, "Scala" },
                    { 14, "Perl" },
                    { 15, "R" },
                    { 16, "MATLAB" },
                    { 17, "Haskell" },
                    { 18, "Cobol" },
                    { 19, "Lisp" },
                    { 20, "Prolog" },
                    { 21, "Ada" },
                    { 22, "Fortran" },
                    { 23, "Assembly (x86, ARM)" },
                    { 24, ".NET" },
                    { 25, "Spring" },
                    { 26, "Django" },
                    { 27, "React" },
                    { 28, "Angular" },
                    { 29, "Vue.js" },
                    { 30, "Node.js" },
                    { 31, "Express.js" },
                    { 32, "Flask" },
                    { 33, "Ruby on Rails" },
                    { 34, "Laravel" },
                    { 35, "Symfony" },
                    { 36, "Hibernate" },
                    { 37, "Xamarin" },
                    { 38, "Unity" },
                    { 39, "TensorFlow" },
                    { 40, "PyTorch" },
                    { 41, "Adobe Photoshop" },
                    { 42, "Adobe Illustrator" },
                    { 43, "Adobe InDesign" },
                    { 44, "Sketch" },
                    { 45, "CorelDRAW" },
                    { 46, "AutoCAD" },
                    { 47, "Revit" },
                    { 48, "Legal Research" },
                    { 49, "Litigation" },
                    { 50, "Contract Drafting" },
                    { 51, "Microsoft Office" },
                    { 52, "Excel" },
                    { 53, "Word" },
                    { 54, "PowerPoint" },
                    { 55, "Outlook" },
                    { 56, "Adobe Premiere Pro" },
                    { 57, "Final Cut Pro" },
                    { 58, "Avid Media Composer" },
                    { 59, "Blender" },
                    { 60, "Maya" },
                    { 61, "3ds Max" },
                    { 62, "ZBrush" },
                    { 63, "SketchUp" },
                    { 64, "Illustration" },
                    { 65, "Typography" },
                    { 66, "Digital Painting" },
                    { 67, "User Experience (UX) Design" },
                    { 68, "User Interface (UI) Design" },
                    { 69, "Wireframing" },
                    { 70, "Prototyping" },
                    { 71, "Information Architecture" },
                    { 72, "Interaction Design" },
                    { 73, "Brand Identity" },
                    { 74, "Print Design" },
                    { 75, "Packaging Design" },
                    { 76, "Logo Design" },
                    { 77, "Motion Graphics" },
                    { 78, "2D Animation" },
                    { 79, "3D Animation" },
                    { 80, "Character Animation" },
                    { 81, "Legal Writing" },
                    { 82, "Corporate Law" },
                    { 83, "Intellectual Property Law" },
                    { 84, "Family Law" },
                    { 85, "Environmental Law" },
                    { 86, "Immigration Law" },
                    { 87, "Real Estate Law" },
                    { 88, "Bankruptcy Law" },
                    { 89, "Criminal Law" },
                    { 90, "Health Law" },
                    { 91, "Tax Law" },
                    { 92, "International Law" },
                    { 93, "Administrative Law" },
                    { 94, "Legal Compliance" },
                    { 95, "Legal Consulting" },
                    { 96, "Legal Research" },
                    { 97, "Legal Writing" },
                    { 98, "Legal Analysis" },
                    { 99, "Legal Documentation" },
                    { 100, "Data Entry" },
                    { 101, "Typing" },
                    { 102, "Proofreading" },
                    { 103, "Document Formatting" },
                    { 104, "Transcription" },
                    { 105, "Virtual Assistance" },
                    { 106, "Customer Service" },
                    { 107, "Email Handling" },
                    { 108, "Calendar Management" },
                    { 109, "Travel Arrangements" },
                    { 110, "Event Planning" },
                    { 111, "Research" },
                    { 112, "Social Media Management" },
                    { 113, "Content Creation" },
                    { 114, "Digital Marketing" },
                    { 115, "Search Engine Optimization (SEO)" },
                    { 116, "Search Engine Marketing (SEM)" },
                    { 117, "Email Marketing" },
                    { 118, "Graphic Design" },
                    { 119, "Web Design" },
                    { 120, "Video Editing" },
                    { 121, "Audio Editing" },
                    { 122, "Photography" },
                    { 123, "Videography" },
                    { 124, "Photo Editing" },
                    { 125, "Image Retouching" },
                    { 126, "Color Grading" },
                    { 127, "Storyboarding" },
                    { 128, "Scriptwriting" },
                    { 129, "Creative Writing" },
                    { 130, "Copywriting" },
                    { 131, "Technical Writing" },
                    { 132, "Editing" },
                    { 133, "Translation" },
                    { 134, "Localization" },
                    { 135, "Subtitling" }
                });

            migrationBuilder.InsertData(
                table: "StudyType",
                columns: new[] { "StudyTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Primaria" },
                    { 2, "Secundaria" },
                    { 3, "Terciario" },
                    { 4, "Universitario" },
                    { 5, "Posgrado" },
                    { 6, "Master" },
                    { 7, "Doctorado" },
                    { 8, "Curso" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Experience_UserId",
                table: "Experience",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSkill_SkillId",
                table: "ResumeSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_StudyTypeId",
                table: "Study",
                column: "StudyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_UserId",
                table: "Study",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "ResumeSkill");

            migrationBuilder.DropTable(
                name: "Study");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Resume");

            migrationBuilder.DropTable(
                name: "StudyType");
        }
    }
}
