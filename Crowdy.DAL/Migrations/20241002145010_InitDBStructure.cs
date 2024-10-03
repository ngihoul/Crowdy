using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Crowdy.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDBStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                    table.CheckConstraint("CHK_User_DateOfBirth", "DateOfBirth <= DATEADD(year, -18, GETDATE())");
                });

            migrationBuilder.CreateTable(
                name: "MM_user_role",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MM_user_role", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_MM_user_role_role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MM_user_role_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objective = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ValidatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.Id);
                    table.CheckConstraint("CK_Project_EndDate", "EndDate > GETDATE()");
                    table.CheckConstraint("CK_Project_Objective", "Objective > 0");
                    table.CheckConstraint("CK_Project_StartDate", "StartDate >= GETDATE()");
                    table.ForeignKey(
                        name: "FK_project_status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "status",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_project_user_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "user",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_project_user_ValidatedById",
                        column: x => x.ValidatedById,
                        principalTable: "user",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MM_project_category",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MM_project_category", x => new { x.ProjectId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_MM_project_category_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MM_project_category_project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "project_contribution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_contribution", x => x.Id);
                    table.CheckConstraint("CK_ProjectContribution_Amount", "Amount > 0");
                    table.ForeignKey(
                        name: "FK_project_contribution_project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "project",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_project_contribution_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "project_threshold",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_threshold", x => x.Id);
                    table.CheckConstraint("CK_ProjectThreshold_Amount", "Amount > 0");
                    table.ForeignKey(
                        name: "FK_project_threshold_project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "project",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "To be validated" },
                    { 2, "Validated" },
                    { 3, "Rejected" },
                    { 4, "Closed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_category_Name",
                table: "category",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MM_project_category_CategoryId",
                table: "MM_project_category",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MM_user_role_RoleId",
                table: "MM_user_role",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_project_OwnerId",
                table: "project",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_project_StatusId",
                table: "project",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_project_ValidatedById",
                table: "project",
                column: "ValidatedById");

            migrationBuilder.CreateIndex(
                name: "IX_project_contribution_ProjectId",
                table: "project_contribution",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_project_contribution_UserId",
                table: "project_contribution",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_project_threshold_ProjectId",
                table: "project_threshold",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_role_Name",
                table: "role",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_status_Name",
                table: "status",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_Email",
                table: "user",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_Username",
                table: "user",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MM_project_category");

            migrationBuilder.DropTable(
                name: "MM_user_role");

            migrationBuilder.DropTable(
                name: "project_contribution");

            migrationBuilder.DropTable(
                name: "project_threshold");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "project");

            migrationBuilder.DropTable(
                name: "status");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
