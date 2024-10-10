using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Crowdy.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6017), new DateTime(2025, 1, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6015), new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(5961), new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6025), new DateTime(2025, 2, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6023), new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6022), new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6032), new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6030), new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6029), new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6039), new DateTime(2025, 4, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6037), new DateTime(2025, 1, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6035), new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6046), new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6044), new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6052), new DateTime(2025, 3, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6051), new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6049), new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6060), new DateTime(2025, 2, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6058), new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6057), new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6067), new DateTime(2025, 1, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6066), new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6064), new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6074), new DateTime(2025, 4, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6071), new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6081), new DateTime(2025, 3, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6079), new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6077), new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.InsertData(
                table: "project",
                columns: new[] { "Id", "Comment", "CreatedAt", "Description", "EndDate", "ImageUrl", "Objective", "OwnerId", "StartDate", "StatusId", "Title", "UpdatedAt", "ValidatedById" },
                values: new object[,]
                {
                    { 11, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6088), "Développement d'une plateforme de réalité virtuelle immersive pour les jeux et les applications éducatives.", new DateTime(2025, 3, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6086), "project11.jpg", 40000m, 11, new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6084), 1, "Projet de Réalité Virtuelle", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6089), null },
                    { 12, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6094), "Installation de panneaux solaires dans les zones rurales pour fournir de l'énergie propre et renouvelable aux communautés locales.", new DateTime(2025, 4, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6092), "project12.jpg", 35000m, 12, new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6091), 1, "Énergie Solaire", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6095), null },
                    { 13, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6101), "Restauration d'un bâtiment historique pour préserver le patrimoine culturel et architectural de la région.", new DateTime(2025, 2, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6099), "project13.jpg", 25000m, 13, new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6098), 1, "Restauration Historique", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6102), null },
                    { 14, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6107), "Mise en place d'un programme de mentorat pour aider les jeunes à développer leurs compétences professionnelles et personnelles.", new DateTime(2025, 3, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6106), "project14.jpg", 15000m, 14, new DateTime(2025, 1, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6104), 1, "Programme de Mentorat", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6109), null },
                    { 15, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6115), "Organisation d'un festival de cinéma pour promouvoir les films indépendants et offrir une plateforme aux nouveaux réalisateurs.", new DateTime(2025, 1, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6113), "project15.jpg", 20000m, 15, new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6112), 1, "Festival de Cinéma", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6116), null },
                    { 16, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6122), "Développement d'une application mobile pour suivre et améliorer la santé et le bien-être des utilisateurs.", new DateTime(2025, 2, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6120), "project16.jpg", 30000m, 1, new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6119), 1, "Application de Santé", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6123), null },
                    { 17, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6129), "Initiative de reboisement pour planter des arbres et restaurer les forêts dégradées afin de lutter contre le changement climatique.", new DateTime(2025, 1, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6127), "project17.jpg", 10000m, 2, new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6125), 1, "Projet de Reboisement", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6130), null },
                    { 18, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6135), "Construction d'un centre communautaire pour offrir des services et des activités aux résidents locaux.", new DateTime(2025, 4, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6133), "project18.jpg", 50000m, 3, new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6132), 1, "Centre Communautaire", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6137), null },
                    { 19, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6142), "Financement d'un projet de recherche médicale pour développer de nouveaux traitements et médicaments.", new DateTime(2025, 3, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6140), "project19.jpg", 60000m, 4, new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6139), 1, "Projet de Recherche Médicale", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6143), null },
                    { 20, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6149), "Création d'une plateforme d'éducation en ligne pour offrir des cours et des ressources éducatives accessibles à tous.", new DateTime(2025, 2, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6147), "project20.jpg", 20000m, 5, new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6145), 1, "Éducation en Ligne", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6150), null },
                    { 21, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6155), "Développement d'un système de transport urbain durable pour réduire la congestion et les émissions de CO2.", new DateTime(2025, 3, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6154), "project21.jpg", 45000m, 6, new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6152), 1, "Projet de Mobilité Urbaine", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6157), null },
                    { 22, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6162), "Soutien aux artisans locaux pour promouvoir et vendre leurs produits à travers une plateforme en ligne.", new DateTime(2025, 2, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6160), "project22.jpg", 15000m, 7, new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6159), 1, "Artisanat Local", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6163), null },
                    { 23, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6169), "Protection des écosystèmes marins et des espèces en danger par des actions de conservation et de sensibilisation.", new DateTime(2025, 3, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6167), "project23.jpg", 30000m, 8, new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6165), 1, "Projet de Conservation Marine", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6170), null },
                    { 24, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6176), "Développement de technologies agricoles innovantes pour améliorer la productivité et la durabilité des exploitations agricoles.", new DateTime(2025, 4, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6174), "project24.jpg", 25000m, 9, new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6173), 1, "Innovation Agricole", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6177), null },
                    { 25, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6182), "Mise en place de programmes de réduction des déchets et de recyclage pour promouvoir une gestion durable des ressources.", new DateTime(2025, 2, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6181), "project25.jpg", 20000m, 10, new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6179), 1, "Projet de Réduction des Déchets", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6184), null },
                    { 26, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6189), "Création d'un refuge pour animaux abandonnés et maltraités, offrant des soins et des adoptions responsables.", new DateTime(2025, 3, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6187), "project26.jpg", 30000m, 11, new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6186), 1, "Projet de Bien-être Animal", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6190), null },
                    { 27, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6196), "Organisation de concerts de musique classique pour promouvoir les jeunes talents et offrir des expériences culturelles enrichissantes.", new DateTime(2025, 1, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6194), "project27.jpg", 15000m, 12, new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6192), 1, "Projet de Musique Classique", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6197), null },
                    { 28, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6202), "Promotion de la cuisine durable et locale à travers des ateliers et des événements culinaires.", new DateTime(2025, 2, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6201), "project28.jpg", 10000m, 13, new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6199), 1, "Projet de Cuisine Durable", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6204), null },
                    { 29, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6209), "Création d'une exposition de photographies pour sensibiliser à des causes sociales et environnementales.", new DateTime(2025, 1, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6207), "project29.jpg", 12000m, 14, new DateTime(2024, 11, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6206), 1, "Projet de Photographie", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6210), null },
                    { 30, null, new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6216), "Production d'une pièce de théâtre pour promouvoir les arts de la scène et offrir des spectacles de qualité.", new DateTime(2025, 3, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6214), "project30.jpg", 18000m, 15, new DateTime(2024, 12, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6212), 1, "Projet de Théâtre", new DateTime(2024, 10, 9, 16, 39, 40, 7, DateTimeKind.Local).AddTicks(6217), null }
                });

            migrationBuilder.InsertData(
                table: "MM_project_category",
                columns: new[] { "CategoryId", "ProjectId" },
                values: new object[,]
                {
                    { 3, 11 },
                    { 7, 11 },
                    { 5, 12 },
                    { 2, 13 },
                    { 8, 13 },
                    { 11, 13 },
                    { 1, 14 },
                    { 4, 14 },
                    { 9, 14 },
                    { 12, 14 },
                    { 6, 15 },
                    { 10, 15 },
                    { 3, 16 },
                    { 2, 17 },
                    { 5, 17 },
                    { 8, 17 },
                    { 7, 18 },
                    { 12, 18 },
                    { 1, 19 },
                    { 6, 19 },
                    { 9, 19 },
                    { 11, 19 },
                    { 4, 20 },
                    { 8, 21 },
                    { 10, 21 },
                    { 3, 22 },
                    { 11, 22 },
                    { 2, 23 },
                    { 5, 23 },
                    { 8, 23 },
                    { 12, 23 },
                    { 7, 24 },
                    { 1, 25 },
                    { 6, 25 },
                    { 9, 25 },
                    { 4, 26 },
                    { 10, 26 },
                    { 8, 27 },
                    { 3, 28 },
                    { 11, 28 },
                    { 12, 28 },
                    { 2, 29 },
                    { 5, 29 },
                    { 7, 30 },
                    { 9, 30 },
                    { 10, 30 },
                    { 12, 30 }
                });

            migrationBuilder.InsertData(
                table: "project_threshold",
                columns: new[] { "Id", "Amount", "Description", "ProjectId" },
                values: new object[,]
                {
                    { 41, 500m, "Niveau 1 - Accès anticipé", 11 },
                    { 42, 1000m, "Niveau 2 - Accès anticipé + Contenu exclusif", 11 },
                    { 43, 2000m, "Niveau 3 - Accès anticipé + Contenu exclusif + Mention dans les crédits", 11 },
                    { 44, 300m, "Niveau 1 - Certificat de remerciement", 12 },
                    { 45, 700m, "Niveau 2 - Certificat de remerciement + T-shirt", 12 },
                    { 46, 1500m, "Niveau 3 - Certificat de remerciement + T-shirt + Visite du site", 12 },
                    { 47, 400m, "Niveau 1 - Carte postale du bâtiment restauré", 13 },
                    { 48, 800m, "Niveau 2 - Carte postale + Livre sur l'histoire du bâtiment", 13 },
                    { 49, 1600m, "Niveau 3 - Carte postale + Livre + Visite guidée", 13 },
                    { 50, 200m, "Niveau 1 - Mention sur le site web", 14 },
                    { 51, 500m, "Niveau 2 - Mention + T-shirt", 14 },
                    { 52, 1000m, "Niveau 3 - Mention + T-shirt + Invitation à un événement", 14 },
                    { 53, 250m, "Niveau 1 - Billet pour une projection", 15 },
                    { 54, 600m, "Niveau 2 - Billet + Affiche du festival", 15 },
                    { 55, 1200m, "Niveau 3 - Billet + Affiche + Rencontre avec les réalisateurs", 15 },
                    { 56, 400m, "Niveau 1 - Accès premium à l'application", 16 },
                    { 57, 900m, "Niveau 2 - Accès premium + Consultation avec un expert", 16 },
                    { 58, 1800m, "Niveau 3 - Accès premium + Consultation + Mention dans l'application", 16 },
                    { 59, 100m, "Niveau 1 - Certificat de plantation", 17 },
                    { 60, 300m, "Niveau 2 - Certificat + T-shirt", 17 },
                    { 61, 700m, "Niveau 3 - Certificat + T-shirt + Visite du site de plantation", 17 },
                    { 62, 500m, "Niveau 1 - Mention sur le mur des donateurs", 18 },
                    { 63, 1000m, "Niveau 2 - Mention + T-shirt", 18 },
                    { 64, 2000m, "Niveau 3 - Mention + T-shirt + Invitation à l'inauguration", 18 },
                    { 65, 600m, "Niveau 1 - Mention dans le rapport de recherche", 19 },
                    { 66, 1200m, "Niveau 2 - Mention + T-shirt", 19 },
                    { 67, 2500m, "Niveau 3 - Mention + T-shirt + Invitation à une conférence", 19 },
                    { 68, 300m, "Niveau 1 - Accès à un cours exclusif", 20 },
                    { 69, 700m, "Niveau 2 - Accès à un cours + T-shirt", 20 },
                    { 70, 1500m, "Niveau 3 - Accès à un cours + T-shirt + Mention sur la plateforme", 20 },
                    { 71, 400m, "Niveau 1 - Mention sur le site web", 21 },
                    { 72, 900m, "Niveau 2 - Mention + T-shirt", 21 },
                    { 73, 1800m, "Niveau 3 - Mention + T-shirt + Invitation à un événement", 21 },
                    { 74, 200m, "Niveau 1 - Mention sur le site web", 22 },
                    { 75, 500m, "Niveau 2 - Mention + T-shirt", 22 },
                    { 76, 1000m, "Niveau 3 - Mention + T-shirt + Invitation à un événement", 22 },
                    { 77, 300m, "Niveau 1 - Certificat de remerciement", 23 },
                    { 78, 700m, "Niveau 2 - Certificat + T-shirt", 23 },
                    { 79, 1500m, "Niveau 3 - Certificat + T-shirt + Visite du site", 23 },
                    { 80, 400m, "Niveau 1 - Carte postale du projet", 24 },
                    { 81, 800m, "Niveau 2 - Carte postale + Livre sur le projet", 24 },
                    { 82, 1600m, "Niveau 3 - Carte postale + Livre + Visite guidée", 24 },
                    { 83, 250m, "Niveau 1 - Billet pour un atelier", 25 },
                    { 84, 600m, "Niveau 2 - Billet + T-shirt", 25 },
                    { 85, 1200m, "Niveau 3 - Billet + T-shirt + Mention sur le site web", 25 },
                    { 86, 300m, "Niveau 1 - Certificat de remerciement", 26 },
                    { 87, 700m, "Niveau 2 - Certificat + T-shirt", 26 },
                    { 88, 1500m, "Niveau 3 - Certificat + T-shirt + Visite du refuge", 26 },
                    { 89, 200m, "Niveau 1 - Mention sur le programme", 27 },
                    { 90, 500m, "Niveau 2 - Mention + T-shirt", 27 },
                    { 91, 1000m, "Niveau 3 - Mention + T-shirt + Invitation à un concert", 27 },
                    { 92, 100m, "Niveau 1 - Mention sur le site web", 28 },
                    { 93, 300m, "Niveau 2 - Mention + T-shirt", 28 },
                    { 94, 700m, "Niveau 3 - Mention + T-shirt + Invitation à un atelier", 28 },
                    { 95, 150m, "Niveau 1 - Mention sur l'exposition", 29 },
                    { 96, 400m, "Niveau 2 - Mention + T-shirt", 29 },
                    { 97, 900m, "Niveau 3 - Mention + T-shirt + Invitation à l'exposition", 29 },
                    { 98, 250m, "Niveau 1 - Billet pour une représentation", 30 },
                    { 99, 600m, "Niveau 2 - Billet + Affiche de la pièce", 30 },
                    { 100, 1200m, "Niveau 3 - Billet + Affiche + Rencontre avec les acteurs", 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 7, 18 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 12, 18 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 11, 19 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 8, 21 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 10, 21 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 11, 22 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 2, 23 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 5, 23 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 8, 23 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 12, 23 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 7, 24 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 6, 25 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 9, 25 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 4, 26 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 10, 26 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 8, 27 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 3, 28 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 11, 28 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 12, 28 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 5, 29 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 7, 30 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 9, 30 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 10, 30 });

            migrationBuilder.DeleteData(
                table: "MM_project_category",
                keyColumns: new[] { "CategoryId", "ProjectId" },
                keyValues: new object[] { 12, 30 });

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "project_threshold",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "project",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1031), new DateTime(2025, 1, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(974), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1038), new DateTime(2025, 2, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1036), new DateTime(2024, 12, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1035), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1045), new DateTime(2024, 12, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1043), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1042), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1051), new DateTime(2025, 4, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1050), new DateTime(2025, 1, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1058), new DateTime(2024, 12, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1057), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1055), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1065), new DateTime(2025, 3, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1063), new DateTime(2024, 12, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1072), new DateTime(2025, 2, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1070), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1069), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1079), new DateTime(2025, 1, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1078), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1076), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1086), new DateTime(2025, 4, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1084), new DateTime(2024, 12, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "project",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1093), new DateTime(2025, 3, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1091), new DateTime(2024, 11, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1090), new DateTime(2024, 10, 9, 14, 50, 57, 72, DateTimeKind.Local).AddTicks(1094) });
        }
    }
}
