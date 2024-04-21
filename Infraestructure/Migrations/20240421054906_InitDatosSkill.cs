﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDatosSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    ResumeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimunSalary = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume", x => x.ResumeId);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.ExperienceId);
                    table.ForeignKey(
                        name: "FK_Experience_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeSkill",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSkill", x => new { x.ResumeId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ResumeSkill_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "ResumeId",
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    StudyTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Study", x => x.StudyId);
                    table.ForeignKey(
                        name: "FK_Study_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Study_StudyType_StudyTypeId",
                        column: x => x.StudyTypeId,
                        principalTable: "StudyType",
                        principalColumn: "StudyTypeId",
                        onDelete: ReferentialAction.Cascade);
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
                    { 40, "PyTorch" }
                });

            migrationBuilder.InsertData(
                table: "StudyType",
                columns: new[] { "StudyTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Secundaria basica" },
                    { 2, "Secundaria superior" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Experience_ResumeId",
                table: "Experience",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSkill_SkillId",
                table: "ResumeSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_ResumeId",
                table: "Study",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_StudyTypeId",
                table: "Study",
                column: "StudyTypeId");
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
