using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Crowdy.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitAndAddData : Migration
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
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                table: "category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Alimentation" },
                    { 2, "Art" },
                    { 3, "BD & Comics" },
                    { 4, "Beauté" },
                    { 5, "Bijoux" },
                    { 6, "Cinéma & Vidéo" },
                    { 7, "Design" },
                    { 8, "Écologie" },
                    { 9, "Éducation" },
                    { 10, "Famille" },
                    { 11, "Mode" },
                    { 12, "Musique" },
                    { 13, "Photographie" },
                    { 14, "Santé" },
                    { 15, "Sport" },
                    { 16, "Technologie" },
                    { 17, "Voyage" }
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

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Avatar", "DateOfBirth", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice@example.com", "password1", "Alice" },
                    { 2, null, new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob@example.com", "password2", "Bob" },
                    { 3, null, new DateTime(1992, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "charlie@example.com", "password3", "Charlie" },
                    { 4, null, new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "diana@example.com", "password4", "Diana" },
                    { 5, null, new DateTime(1994, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "eve@example.com", "password5", "Eve" },
                    { 6, null, new DateTime(1990, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "frank@example.com", "password6", "Frank" },
                    { 7, null, new DateTime(1991, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "grace@example.com", "password7", "Grace" },
                    { 8, null, new DateTime(1992, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "hank@example.com", "password8", "Hank" },
                    { 9, null, new DateTime(1993, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ivy@example.com", "password9", "Ivy" },
                    { 10, null, new DateTime(1994, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack@example.com", "password10", "Jack" },
                    { 11, null, new DateTime(1990, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "karen@example.com", "password11", "Karen" },
                    { 12, null, new DateTime(1991, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "leo@example.com", "password12", "Leo" },
                    { 13, null, new DateTime(1992, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "mona@example.com", "password13", "Mona" },
                    { 14, null, new DateTime(1993, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "nina@example.com", "password14", "Nina" },
                    { 15, null, new DateTime(1994, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "oscar@example.com", "password15", "Oscar" }
                });

            migrationBuilder.InsertData(
                table: "project",
                columns: new[] { "Id", "CreatedAt", "Description", "EndDate", "ImageUrl", "Objective", "OwnerId", "StartDate", "StatusId", "Title", "UpdatedAt", "ValidatedById" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8240), "Projet de maison intelligente", new DateTime(2025, 1, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8238), "project1.jpg", 10000m, 1, new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8192), 1, "Smart Home", new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8242), null },
                    { 2, new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8248), "Collection de peintures abstraites", new DateTime(2025, 2, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8246), "project2.jpg", 5000m, 2, new DateTime(2024, 12, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8244), 1, "Peinture Abstraite", new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8249), null },
                    { 3, new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8255), "Enregistrement d'un album de rock", new DateTime(2024, 12, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8254), "project3.jpg", 8000m, 3, new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8252), 1, "Album Rock", new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8257), null },
                    { 4, new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8262), "Développement d'une application mobile", new DateTime(2025, 4, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8261), "project4.jpg", 15000m, 4, new DateTime(2025, 1, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8259), 1, "Application Mobile", new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8264), null },
                    { 5, new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8269), "Organisation d'un concert live", new DateTime(2024, 12, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8267), "project5.jpg", 12000m, 5, new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8266), 1, "Concert Live", new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8270), null },
                    { 6, new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8276), "Réalisation d'un film documentaire", new DateTime(2025, 3, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8275), "project6.jpg", 20000m, 6, new DateTime(2024, 12, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8273), 1, "Film Documentaire", new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8278), null },
                    { 7, new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8283), "Développement d'un jeu vidéo", new DateTime(2025, 2, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8281), "project7.jpg", 30000m, 7, new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8280), 1, "Jeu Vidéo", new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8284), null },
                    { 8, new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8290), "Publication d'un livre de cuisine", new DateTime(2025, 1, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8288), "project8.jpg", 7000m, 8, new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8287), 1, "Livre de Cuisine", new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8291), null },
                    { 9, new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8296), "Organisation d'un festival de musique", new DateTime(2025, 4, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8295), "project9.jpg", 25000m, 9, new DateTime(2024, 12, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8293), 1, "Festival de Musique", new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8298), null },
                    { 10, new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8303), "Lancement d'une startup technologique", new DateTime(2025, 3, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8301), "project10.jpg", 50000m, 10, new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8300), 1, "Startup Technologique", new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8304), null }
                });

            migrationBuilder.InsertData(
                table: "MM_project_category",
                columns: new[] { "CategoryId", "ProjectId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 16, 1 },
                    { 2, 2 },
                    { 13, 2 },
                    { 12, 3 },
                    { 7, 4 },
                    { 16, 4 },
                    { 12, 5 },
                    { 6, 6 },
                    { 8, 6 },
                    { 15, 6 },
                    { 16, 7 },
                    { 1, 8 },
                    { 10, 8 },
                    { 12, 9 },
                    { 15, 9 },
                    { 14, 10 },
                    { 16, 10 },
                    { 17, 10 }
                });

            migrationBuilder.InsertData(
                table: "project_threshold",
                columns: new[] { "Id", "Amount", "Description", "ProjectId" },
                values: new object[,]
                {
                    { 1, 100m, "Seuil 1 pour Smart Home", 1 },
                    { 2, 200m, "Seuil 2 pour Smart Home", 1 },
                    { 3, 300m, "Seuil 3 pour Smart Home", 1 },
                    { 4, 400m, "Seuil 4 pour Smart Home", 1 },
                    { 5, 500m, "Seuil 5 pour Smart Home", 1 },
                    { 6, 100m, "Seuil 1 pour Peinture Abstraite", 2 },
                    { 7, 200m, "Seuil 2 pour Peinture Abstraite", 2 },
                    { 8, 300m, "Seuil 3 pour Peinture Abstraite", 2 },
                    { 9, 400m, "Seuil 4 pour Peinture Abstraite", 2 },
                    { 10, 100m, "Seuil 1 pour Album Rock", 3 },
                    { 11, 200m, "Seuil 2 pour Album Rock", 3 },
                    { 12, 300m, "Seuil 3 pour Album Rock", 3 },
                    { 13, 400m, "Seuil 4 pour Album Rock", 3 },
                    { 14, 100m, "Seuil 1 pour Application Mobile", 4 },
                    { 15, 200m, "Seuil 2 pour Application Mobile", 4 },
                    { 16, 300m, "Seuil 3 pour Application Mobile", 4 },
                    { 17, 100m, "Seuil 1 pour Concert Live", 5 },
                    { 18, 200m, "Seuil 2 pour Concert Live", 5 },
                    { 19, 300m, "Seuil 3 pour Concert Live", 5 },
                    { 20, 400m, "Seuil 4 pour Concert Live", 5 },
                    { 21, 100m, "Seuil 1 pour Film Documentaire", 6 },
                    { 22, 200m, "Seuil 2 pour Film Documentaire", 6 },
                    { 23, 300m, "Seuil 3 pour Film Documentaire", 6 },
                    { 24, 100m, "Seuil 1 pour Jeu Vidéo", 7 },
                    { 25, 200m, "Seuil 2 pour Jeu Vidéo", 7 },
                    { 26, 300m, "Seuil 3 pour Jeu Vidéo", 7 },
                    { 27, 400m, "Seuil 4 pour Jeu Vidéo", 7 },
                    { 28, 500m, "Seuil 5 pour Jeu Vidéo", 7 },
                    { 29, 100m, "Seuil 1 pour Livre de Cuisine", 8 },
                    { 30, 200m, "Seuil 2 pour Livre de Cuisine", 8 },
                    { 31, 300m, "Seuil 3 pour Livre de Cuisine", 8 },
                    { 32, 100m, "Seuil 1 pour Festival de Musique", 9 },
                    { 33, 200m, "Seuil 2 pour Festival de Musique", 9 },
                    { 34, 300m, "Seuil 3 pour Festival de Musique", 9 },
                    { 35, 400m, "Seuil 4 pour Festival de Musique", 9 },
                    { 36, 100m, "Seuil 1 pour Startup Technologique", 10 },
                    { 37, 200m, "Seuil 2 pour Startup Technologique", 10 },
                    { 38, 300m, "Seuil 3 pour Startup Technologique", 10 },
                    { 39, 400m, "Seuil 4 pour Startup Technologique", 10 },
                    { 40, 500m, "Seuil 5 pour Startup Technologique", 10 }
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
