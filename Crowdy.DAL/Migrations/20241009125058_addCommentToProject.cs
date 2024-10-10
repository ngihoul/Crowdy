using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crowdy.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addCommentToProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "project",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1031), new DateTime(2025, 1, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(974), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1038), new DateTime(2025, 2, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1036), new DateTime(2024, 12, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1035), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1045), new DateTime(2024, 12, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1043), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1042), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1051), new DateTime(2025, 4, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1050), new DateTime(2025, 1, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1058), new DateTime(2024, 12, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1057), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1055), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1065), new DateTime(2025, 3, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1063), new DateTime(2024, 12, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comment", "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1072), new DateTime(2025, 2, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1070), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1069), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comment", "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1079), new DateTime(2025, 1, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1078), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1076), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Comment", "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1086), new DateTime(2025, 4, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1084), new DateTime(2024, 12, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Comment", "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1093), new DateTime(2025, 3, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1091), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1090), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "status",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "A valider");

            migrationBuilder.UpdateData(
                table: "status",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Validé");

            migrationBuilder.UpdateData(
                table: "status",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Rejeté");

            migrationBuilder.UpdateData(
                table: "status",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Terminé");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "project");

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8240), new DateTime(2025, 1, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8238), new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8192), new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8248), new DateTime(2025, 2, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 12, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8244), new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8255), new DateTime(2024, 12, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8254), new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8252), new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8262), new DateTime(2025, 4, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8261), new DateTime(2025, 1, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8259), new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8269), new DateTime(2024, 12, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8266), new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8276), new DateTime(2025, 3, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8275), new DateTime(2024, 12, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8273), new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8283), new DateTime(2025, 2, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8281), new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8280), new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8290), new DateTime(2025, 1, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8288), new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8296), new DateTime(2025, 4, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8295), new DateTime(2024, 12, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8293), new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8303), new DateTime(2025, 3, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8301), new DateTime(2024, 11, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8300), new DateTime(2024, 10, 8, 7, 36, 32, 266, DateTimeKind.Local).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "status",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "To be validated");

            migrationBuilder.UpdateData(
                table: "status",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Validated");

            migrationBuilder.UpdateData(
                table: "status",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "status",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Closed");
        }
    }
}
