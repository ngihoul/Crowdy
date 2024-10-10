using Crowdy.DAL.Database.Configurations;
using Crowdy.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crowdy.DAL.Database
{
    public class ApplicationContext : DbContext
    {
        #region DbSet
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectThreshold> ProjectThresholds { get; set; }
        public DbSet<ProjectContribution> ProjectContributions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Role> Roles { get; set; }

        #endregion

        #region Constructor
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new ProjectContributionConfig());
            modelBuilder.ApplyConfiguration(new ProjectThresholdConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new StatusConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "Alice", Email = "alice@example.com", Password = "password1", Avatar = null, DateOfBirth = new DateTime(1990, 1, 1) },
                new User { Id = 2, Username = "Bob", Email = "bob@example.com", Password = "password2", Avatar = null, DateOfBirth = new DateTime(1991, 2, 2) },
                new User { Id = 3, Username = "Charlie", Email = "charlie@example.com", Password = "password3", Avatar = null, DateOfBirth = new DateTime(1992, 3, 3) },
                new User { Id = 4, Username = "Diana", Email = "diana@example.com", Password = "password4", Avatar = null, DateOfBirth = new DateTime(1993, 4, 4) },
                new User { Id = 5, Username = "Eve", Email = "eve@example.com", Password = "password5", Avatar = null, DateOfBirth = new DateTime(1994, 5, 5) },
                new User { Id = 6, Username = "Frank", Email = "frank@example.com", Password = "password6", Avatar = null, DateOfBirth = new DateTime(1990, 6, 6) },
                new User { Id = 7, Username = "Grace", Email = "grace@example.com", Password = "password7", Avatar = null, DateOfBirth = new DateTime(1991, 7, 7) },
                new User { Id = 8, Username = "Hank", Email = "hank@example.com", Password = "password8", Avatar = null, DateOfBirth = new DateTime(1992, 8, 8) },
                new User { Id = 9, Username = "Ivy", Email = "ivy@example.com", Password = "password9", Avatar = null, DateOfBirth = new DateTime(1993, 9, 9) },
                new User { Id = 10, Username = "Jack", Email = "jack@example.com", Password = "password10", Avatar = null, DateOfBirth = new DateTime(1994, 10, 10) },
                new User { Id = 11, Username = "Karen", Email = "karen@example.com", Password = "password11", Avatar = null, DateOfBirth = new DateTime(1990, 11, 11) },
                new User { Id = 12, Username = "Leo", Email = "leo@example.com", Password = "password12", Avatar = null, DateOfBirth = new DateTime(1991, 12, 12) },
                new User { Id = 13, Username = "Mona", Email = "mona@example.com", Password = "password13", Avatar = null, DateOfBirth = new DateTime(1992, 1, 13) },
                new User { Id = 14, Username = "Nina", Email = "nina@example.com", Password = "password14", Avatar = null, DateOfBirth = new DateTime(1993, 2, 14) },
                new User { Id = 15, Username = "Oscar", Email = "oscar@example.com", Password = "password15", Avatar = null, DateOfBirth = new DateTime(1994, 3, 15) }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Alimentation" },
                new Category { Id = 2, Name = "Art" },
                new Category { Id = 3, Name = "BD & Comics" },
                new Category { Id = 4, Name = "Beauté" },
                new Category { Id = 5, Name = "Bijoux" },
                new Category { Id = 6, Name = "Cinéma & Vidéo" },
                new Category { Id = 7, Name = "Design" },
                new Category { Id = 8, Name = "Écologie" },
                new Category { Id = 9, Name = "Éducation" },
                new Category { Id = 10, Name = "Famille" },
                new Category { Id = 11, Name = "Mode" },
                new Category { Id = 12, Name = "Musique" },
                new Category { Id = 13, Name = "Photographie" },
                new Category { Id = 14, Name = "Santé" },
                new Category { Id = 15, Name = "Sport" },
                new Category { Id = 16, Name = "Technologie" },
                new Category { Id = 17, Name = "Voyage" }
                );

            modelBuilder.Entity<Project>().HasData(
                new { Id = 1, Title = "Smart Home", Description = "Projet de maison intelligente", Objective = 10000m, ImageUrl = "project1.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(3), OwnerId = 1, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 2, Title = "Peinture Abstraite", Description = "Collection de peintures abstraites", Objective = 5000m, ImageUrl = "project2.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(4), OwnerId = 2, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 3, Title = "Album Rock", Description = "Enregistrement d'un album de rock", Objective = 8000m, ImageUrl = "project3.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(2), OwnerId = 3, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 4, Title = "Application Mobile", Description = "Développement d'une application mobile", Objective = 15000m, ImageUrl = "project4.jpg", StartDate = DateTime.Now.AddMonths(3), EndDate = DateTime.Now.AddMonths(6), OwnerId = 4, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 5, Title = "Concert Live", Description = "Organisation d'un concert live", Objective = 12000m, ImageUrl = "project5.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(2), OwnerId = 5, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 6, Title = "Film Documentaire", Description = "Réalisation d'un film documentaire", Objective = 20000m, ImageUrl = "project6.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(5), OwnerId = 6, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 7, Title = "Jeu Vidéo", Description = "Développement d'un jeu vidéo", Objective = 30000m, ImageUrl = "project7.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(4), OwnerId = 7, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 8, Title = "Livre de Cuisine", Description = "Publication d'un livre de cuisine", Objective = 7000m, ImageUrl = "project8.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(3), OwnerId = 8, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 9, Title = "Festival de Musique", Description = "Organisation d'un festival de musique", Objective = 25000m, ImageUrl = "project9.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(6), OwnerId = 9, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 10, Title = "Startup Technologique", Description = "Lancement d'une startup technologique", Objective = 50000m, ImageUrl = "project10.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(5), OwnerId = 10, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 11, Title = "Projet de Réalité Virtuelle", Description = "Développement d'une plateforme de réalité virtuelle immersive pour les jeux et les applications éducatives.", Objective = 40000m, ImageUrl = "project11.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(5), OwnerId = 11, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 12, Title = "Énergie Solaire", Description = "Installation de panneaux solaires dans les zones rurales pour fournir de l'énergie propre et renouvelable aux communautés locales.", Objective = 35000m, ImageUrl = "project12.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(6), OwnerId = 12, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 13, Title = "Restauration Historique", Description = "Restauration d'un bâtiment historique pour préserver le patrimoine culturel et architectural de la région.", Objective = 25000m, ImageUrl = "project13.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(4), OwnerId = 13, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 14, Title = "Programme de Mentorat", Description = "Mise en place d'un programme de mentorat pour aider les jeunes à développer leurs compétences professionnelles et personnelles.", Objective = 15000m, ImageUrl = "project14.jpg", StartDate = DateTime.Now.AddMonths(3), EndDate = DateTime.Now.AddMonths(5), OwnerId = 14, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 15, Title = "Festival de Cinéma", Description = "Organisation d'un festival de cinéma pour promouvoir les films indépendants et offrir une plateforme aux nouveaux réalisateurs.", Objective = 20000m, ImageUrl = "project15.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(3), OwnerId = 15, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 16, Title = "Application de Santé", Description = "Développement d'une application mobile pour suivre et améliorer la santé et le bien-être des utilisateurs.", Objective = 30000m, ImageUrl = "project16.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(4), OwnerId = 1, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 17, Title = "Projet de Reboisement", Description = "Initiative de reboisement pour planter des arbres et restaurer les forêts dégradées afin de lutter contre le changement climatique.", Objective = 10000m, ImageUrl = "project17.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(3), OwnerId = 2, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 18, Title = "Centre Communautaire", Description = "Construction d'un centre communautaire pour offrir des services et des activités aux résidents locaux.", Objective = 50000m, ImageUrl = "project18.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(6), OwnerId = 3, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 19, Title = "Projet de Recherche Médicale", Description = "Financement d'un projet de recherche médicale pour développer de nouveaux traitements et médicaments.", Objective = 60000m, ImageUrl = "project19.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(5), OwnerId = 4, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 20, Title = "Éducation en Ligne", Description = "Création d'une plateforme d'éducation en ligne pour offrir des cours et des ressources éducatives accessibles à tous.", Objective = 20000m, ImageUrl = "project20.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(4), OwnerId = 5, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 21, Title = "Projet de Mobilité Urbaine", Description = "Développement d'un système de transport urbain durable pour réduire la congestion et les émissions de CO2.", Objective = 45000m, ImageUrl = "project21.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(5), OwnerId = 6, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 22, Title = "Artisanat Local", Description = "Soutien aux artisans locaux pour promouvoir et vendre leurs produits à travers une plateforme en ligne.", Objective = 15000m, ImageUrl = "project22.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(4), OwnerId = 7, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 23, Title = "Projet de Conservation Marine", Description = "Protection des écosystèmes marins et des espèces en danger par des actions de conservation et de sensibilisation.", Objective = 30000m, ImageUrl = "project23.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(5), OwnerId = 8, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 24, Title = "Innovation Agricole", Description = "Développement de technologies agricoles innovantes pour améliorer la productivité et la durabilité des exploitations agricoles.", Objective = 25000m, ImageUrl = "project24.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(6), OwnerId = 9, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 25, Title = "Projet de Réduction des Déchets", Description = "Mise en place de programmes de réduction des déchets et de recyclage pour promouvoir une gestion durable des ressources.", Objective = 20000m, ImageUrl = "project25.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(4), OwnerId = 10, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 26, Title = "Projet de Bien-être Animal", Description = "Création d'un refuge pour animaux abandonnés et maltraités, offrant des soins et des adoptions responsables.", Objective = 30000m, ImageUrl = "project26.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(5), OwnerId = 11, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 27, Title = "Projet de Musique Classique", Description = "Organisation de concerts de musique classique pour promouvoir les jeunes talents et offrir des expériences culturelles enrichissantes.", Objective = 15000m, ImageUrl = "project27.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(3), OwnerId = 12, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 28, Title = "Projet de Cuisine Durable", Description = "Promotion de la cuisine durable et locale à travers des ateliers et des événements culinaires.", Objective = 10000m, ImageUrl = "project28.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(4), OwnerId = 13, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 29, Title = "Projet de Photographie", Description = "Création d'une exposition de photographies pour sensibiliser à des causes sociales et environnementales.", Objective = 12000m, ImageUrl = "project29.jpg", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(3), OwnerId = 14, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new { Id = 30, Title = "Projet de Théâtre", Description = "Production d'une pièce de théâtre pour promouvoir les arts de la scène et offrir des spectacles de qualité.", Objective = 18000m, ImageUrl = "project30.jpg", StartDate = DateTime.Now.AddMonths(2), EndDate = DateTime.Now.AddMonths(5), OwnerId = 15, StatusId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<ProjectThreshold>().HasData(
                new { Id = 1, ProjectId = 1, Amount = 100m, Description = "Seuil 1 pour Smart Home" },
                new { Id = 2, ProjectId = 1, Amount = 200m, Description = "Seuil 2 pour Smart Home" },
                new { Id = 3, ProjectId = 1, Amount = 300m, Description = "Seuil 3 pour Smart Home" },
                new { Id = 4, ProjectId = 1, Amount = 400m, Description = "Seuil 4 pour Smart Home" },
                new { Id = 5, ProjectId = 1, Amount = 500m, Description = "Seuil 5 pour Smart Home" },
                new { Id = 6, ProjectId = 2, Amount = 100m, Description = "Seuil 1 pour Peinture Abstraite" },
                new { Id = 7, ProjectId = 2, Amount = 200m, Description = "Seuil 2 pour Peinture Abstraite" },
                new { Id = 8, ProjectId = 2, Amount = 300m, Description = "Seuil 3 pour Peinture Abstraite" },
                new { Id = 9, ProjectId = 2, Amount = 400m, Description = "Seuil 4 pour Peinture Abstraite" },
                new { Id = 10, ProjectId = 3, Amount = 100m, Description = "Seuil 1 pour Album Rock" },
                new { Id = 11, ProjectId = 3, Amount = 200m, Description = "Seuil 2 pour Album Rock" },
                new { Id = 12, ProjectId = 3, Amount = 300m, Description = "Seuil 3 pour Album Rock" },
                new { Id = 13, ProjectId = 3, Amount = 400m, Description = "Seuil 4 pour Album Rock" },
                new { Id = 14, ProjectId = 4, Amount = 100m, Description = "Seuil 1 pour Application Mobile" },
                new { Id = 15, ProjectId = 4, Amount = 200m, Description = "Seuil 2 pour Application Mobile" },
                new { Id = 16, ProjectId = 4, Amount = 300m, Description = "Seuil 3 pour Application Mobile" },
                new { Id = 17, ProjectId = 5, Amount = 100m, Description = "Seuil 1 pour Concert Live" },
                new { Id = 18, ProjectId = 5, Amount = 200m, Description = "Seuil 2 pour Concert Live" },
                new { Id = 19, ProjectId = 5, Amount = 300m, Description = "Seuil 3 pour Concert Live" },
                new { Id = 20, ProjectId = 5, Amount = 400m, Description = "Seuil 4 pour Concert Live" },
                new { Id = 21, ProjectId = 6, Amount = 100m, Description = "Seuil 1 pour Film Documentaire" },
                new { Id = 22, ProjectId = 6, Amount = 200m, Description = "Seuil 2 pour Film Documentaire" },
                new { Id = 23, ProjectId = 6, Amount = 300m, Description = "Seuil 3 pour Film Documentaire" },
                new { Id = 24, ProjectId = 7, Amount = 100m, Description = "Seuil 1 pour Jeu Vidéo" },
                new { Id = 25, ProjectId = 7, Amount = 200m, Description = "Seuil 2 pour Jeu Vidéo" },
                new { Id = 26, ProjectId = 7, Amount = 300m, Description = "Seuil 3 pour Jeu Vidéo" },
                new { Id = 27, ProjectId = 7, Amount = 400m, Description = "Seuil 4 pour Jeu Vidéo" },
                new { Id = 28, ProjectId = 7, Amount = 500m, Description = "Seuil 5 pour Jeu Vidéo" },
                new { Id = 29, ProjectId = 8, Amount = 100m, Description = "Seuil 1 pour Livre de Cuisine" },
                new { Id = 30, ProjectId = 8, Amount = 200m, Description = "Seuil 2 pour Livre de Cuisine" },
                new { Id = 31, ProjectId = 8, Amount = 300m, Description = "Seuil 3 pour Livre de Cuisine" },
                new { Id = 32, ProjectId = 9, Amount = 100m, Description = "Seuil 1 pour Festival de Musique" },
                new { Id = 33, ProjectId = 9, Amount = 200m, Description = "Seuil 2 pour Festival de Musique" },
                new { Id = 34, ProjectId = 9, Amount = 300m, Description = "Seuil 3 pour Festival de Musique" },
                new { Id = 35, ProjectId = 9, Amount = 400m, Description = "Seuil 4 pour Festival de Musique" },
                new { Id = 36, ProjectId = 10, Amount = 100m, Description = "Seuil 1 pour Startup Technologique" },
                new { Id = 37, ProjectId = 10, Amount = 200m, Description = "Seuil 2 pour Startup Technologique" },
                new { Id = 38, ProjectId = 10, Amount = 300m, Description = "Seuil 3 pour Startup Technologique" },
                new { Id = 39, ProjectId = 10, Amount = 400m, Description = "Seuil 4 pour Startup Technologique" },
                new { Id = 40, ProjectId = 10, Amount = 500m, Description = "Seuil 5 pour Startup Technologique" },
                new { Id = 41, ProjectId = 11, Amount = 500m, Description = "Niveau 1 - Accès anticipé" },
                new { Id = 42, ProjectId = 11, Amount = 1000m, Description = "Niveau 2 - Accès anticipé + Contenu exclusif" },
                new { Id = 43, ProjectId = 11, Amount = 2000m, Description = "Niveau 3 - Accès anticipé + Contenu exclusif + Mention dans les crédits" },

                // Thresholds for Project 12
                new { Id = 44, ProjectId = 12, Amount = 300m, Description = "Niveau 1 - Certificat de remerciement" },
                new { Id = 45, ProjectId = 12, Amount = 700m, Description = "Niveau 2 - Certificat de remerciement + T-shirt" },
                new { Id = 46, ProjectId = 12, Amount = 1500m, Description = "Niveau 3 - Certificat de remerciement + T-shirt + Visite du site" },

                // Thresholds for Project 13
                new { Id = 47, ProjectId = 13, Amount = 400m, Description = "Niveau 1 - Carte postale du bâtiment restauré" },
                new { Id = 48, ProjectId = 13, Amount = 800m, Description = "Niveau 2 - Carte postale + Livre sur l'histoire du bâtiment" },
                new { Id = 49, ProjectId = 13, Amount = 1600m, Description = "Niveau 3 - Carte postale + Livre + Visite guidée" },

                // Thresholds for Project 14
                new { Id = 50, ProjectId = 14, Amount = 200m, Description = "Niveau 1 - Mention sur le site web" },
                new { Id = 51, ProjectId = 14, Amount = 500m, Description = "Niveau 2 - Mention + T-shirt" },
                new { Id = 52, ProjectId = 14, Amount = 1000m, Description = "Niveau 3 - Mention + T-shirt + Invitation à un événement" },

                // Thresholds for Project 15
                new { Id = 53, ProjectId = 15, Amount = 250m, Description = "Niveau 1 - Billet pour une projection" },
                new { Id = 54, ProjectId = 15, Amount = 600m, Description = "Niveau 2 - Billet + Affiche du festival" },
                new { Id = 55, ProjectId = 15, Amount = 1200m, Description = "Niveau 3 - Billet + Affiche + Rencontre avec les réalisateurs" },

                // Thresholds for Project 16
                new { Id = 56, ProjectId = 16, Amount = 400m, Description = "Niveau 1 - Accès premium à l'application" },
                new { Id = 57, ProjectId = 16, Amount = 900m, Description = "Niveau 2 - Accès premium + Consultation avec un expert" },
                new { Id = 58, ProjectId = 16, Amount = 1800m, Description = "Niveau 3 - Accès premium + Consultation + Mention dans l'application" },

                // Thresholds for Project 17
                new { Id = 59, ProjectId = 17, Amount = 100m, Description = "Niveau 1 - Certificat de plantation" },
                new { Id = 60, ProjectId = 17, Amount = 300m, Description = "Niveau 2 - Certificat + T-shirt" },
                new { Id = 61, ProjectId = 17, Amount = 700m, Description = "Niveau 3 - Certificat + T-shirt + Visite du site de plantation" },

                // Thresholds for Project 18
                new { Id = 62, ProjectId = 18, Amount = 500m, Description = "Niveau 1 - Mention sur le mur des donateurs" },
                new { Id = 63, ProjectId = 18, Amount = 1000m, Description = "Niveau 2 - Mention + T-shirt" },
                new { Id = 64, ProjectId = 18, Amount = 2000m, Description = "Niveau 3 - Mention + T-shirt + Invitation à l'inauguration" },

                // Thresholds for Project 19
                new { Id = 65, ProjectId = 19, Amount = 600m, Description = "Niveau 1 - Mention dans le rapport de recherche" },
                new { Id = 66, ProjectId = 19, Amount = 1200m, Description = "Niveau 2 - Mention + T-shirt" },
                new { Id = 67, ProjectId = 19, Amount = 2500m, Description = "Niveau 3 - Mention + T-shirt + Invitation à une conférence" },

                // Thresholds for Project 20
                new { Id = 68, ProjectId = 20, Amount = 300m, Description = "Niveau 1 - Accès à un cours exclusif" },
                new { Id = 69, ProjectId = 20, Amount = 700m, Description = "Niveau 2 - Accès à un cours + T-shirt" },
                new { Id = 70, ProjectId = 20, Amount = 1500m, Description = "Niveau 3 - Accès à un cours + T-shirt + Mention sur la plateforme" },

                // Thresholds for Project 21
                new { Id = 71, ProjectId = 21, Amount = 400m, Description = "Niveau 1 - Mention sur le site web" },
                new { Id = 72, ProjectId = 21, Amount = 900m, Description = "Niveau 2 - Mention + T-shirt" },
                new { Id = 73, ProjectId = 21, Amount = 1800m, Description = "Niveau 3 - Mention + T-shirt + Invitation à un événement" },
                // Thresholds for Project 22
                new { Id = 74, ProjectId = 22, Amount = 200m, Description = "Niveau 1 - Mention sur le site web" },
                new { Id = 75, ProjectId = 22, Amount = 500m, Description = "Niveau 2 - Mention + T-shirt" },
                new { Id = 76, ProjectId = 22, Amount = 1000m, Description = "Niveau 3 - Mention + T-shirt + Invitation à un événement" },

                // Thresholds for Project 23
                new { Id = 77, ProjectId = 23, Amount = 300m, Description = "Niveau 1 - Certificat de remerciement" },
                new { Id = 78, ProjectId = 23, Amount = 700m, Description = "Niveau 2 - Certificat + T-shirt" },
                new { Id = 79, ProjectId = 23, Amount = 1500m, Description = "Niveau 3 - Certificat + T-shirt + Visite du site" },

                // Thresholds for Project 24
                new { Id = 80, ProjectId = 24, Amount = 400m, Description = "Niveau 1 - Carte postale du projet" },
                new { Id = 81, ProjectId = 24, Amount = 800m, Description = "Niveau 2 - Carte postale + Livre sur le projet" },
                new { Id = 82, ProjectId = 24, Amount = 1600m, Description = "Niveau 3 - Carte postale + Livre + Visite guidée" },

                // Thresholds for Project 25
                new { Id = 83, ProjectId = 25, Amount = 250m, Description = "Niveau 1 - Billet pour un atelier" },
                new { Id = 84, ProjectId = 25, Amount = 600m, Description = "Niveau 2 - Billet + T-shirt" },
                new { Id = 85, ProjectId = 25, Amount = 1200m, Description = "Niveau 3 - Billet + T-shirt + Mention sur le site web" },

                // Thresholds for Project 26
                new { Id = 86, ProjectId = 26, Amount = 300m, Description = "Niveau 1 - Certificat de remerciement" },
                new { Id = 87, ProjectId = 26, Amount = 700m, Description = "Niveau 2 - Certificat + T-shirt" },
                new { Id = 88, ProjectId = 26, Amount = 1500m, Description = "Niveau 3 - Certificat + T-shirt + Visite du refuge" },

                // Thresholds for Project 27
                new { Id = 89, ProjectId = 27, Amount = 200m, Description = "Niveau 1 - Mention sur le programme" },
                new { Id = 90, ProjectId = 27, Amount = 500m, Description = "Niveau 2 - Mention + T-shirt" },
                new { Id = 91, ProjectId = 27, Amount = 1000m, Description = "Niveau 3 - Mention + T-shirt + Invitation à un concert" },

                // Thresholds for Project 28
                new { Id = 92, ProjectId = 28, Amount = 100m, Description = "Niveau 1 - Mention sur le site web" },
                new { Id = 93, ProjectId = 28, Amount = 300m, Description = "Niveau 2 - Mention + T-shirt" },
                new { Id = 94, ProjectId = 28, Amount = 700m, Description = "Niveau 3 - Mention + T-shirt + Invitation à un atelier" },

                // Thresholds for Project 29
                new { Id = 95, ProjectId = 29, Amount = 150m, Description = "Niveau 1 - Mention sur l'exposition" },
                new { Id = 96, ProjectId = 29, Amount = 400m, Description = "Niveau 2 - Mention + T-shirt" },
                new { Id = 97, ProjectId = 29, Amount = 900m, Description = "Niveau 3 - Mention + T-shirt + Invitation à l'exposition" },

                // Thresholds for Project 30
                new { Id = 98, ProjectId = 30, Amount = 250m, Description = "Niveau 1 - Billet pour une représentation" },
                new { Id = 99, ProjectId = 30, Amount = 600m, Description = "Niveau 2 - Billet + Affiche de la pièce" },
                new { Id = 100, ProjectId = 30, Amount = 1200m, Description = "Niveau 3 - Billet + Affiche + Rencontre avec les acteurs" }
            );

            modelBuilder.Entity("MM_project_category").HasData(
                new { ProjectId = 1, CategoryId = 1 },
                new { ProjectId = 1, CategoryId = 16 },
                new { ProjectId = 2, CategoryId = 2 },
                new { ProjectId = 2, CategoryId = 13 },
                new { ProjectId = 3, CategoryId = 12 },
                new { ProjectId = 4, CategoryId = 16 },
                new { ProjectId = 4, CategoryId = 7 },
                new { ProjectId = 5, CategoryId = 12 },
                new { ProjectId = 6, CategoryId = 6 },
                new { ProjectId = 6, CategoryId = 8 },
                new { ProjectId = 6, CategoryId = 15 },
                new { ProjectId = 7, CategoryId = 16 },
                new { ProjectId = 8, CategoryId = 1 },
                new { ProjectId = 8, CategoryId = 10 },
                new { ProjectId = 9, CategoryId = 12 },
                new { ProjectId = 9, CategoryId = 15 },
                new { ProjectId = 10, CategoryId = 16 },
                new { ProjectId = 10, CategoryId = 14 },
                new { ProjectId = 10, CategoryId = 17 },
                new { ProjectId = 11, CategoryId = 3 },
                new { ProjectId = 11, CategoryId = 7 },

                // Categories for Project 12
                new { ProjectId = 12, CategoryId = 5 },

                // Categories for Project 13
                new { ProjectId = 13, CategoryId = 2 },
                new { ProjectId = 13, CategoryId = 8 },
                new { ProjectId = 13, CategoryId = 11 },

                // Categories for Project 14
                new { ProjectId = 14, CategoryId = 1 },
                new { ProjectId = 14, CategoryId = 4 },
                new { ProjectId = 14, CategoryId = 9 },
                new { ProjectId = 14, CategoryId = 12 },

                // Categories for Project 15
                new { ProjectId = 15, CategoryId = 6 },
                new { ProjectId = 15, CategoryId = 10 },

                // Categories for Project 16
                new { ProjectId = 16, CategoryId = 3 },

                // Categories for Project 17
                new { ProjectId = 17, CategoryId = 2 },
                new { ProjectId = 17, CategoryId = 5 },
                new { ProjectId = 17, CategoryId = 8 },

                // Categories for Project 18
                new { ProjectId = 18, CategoryId = 7 },
                new { ProjectId = 18, CategoryId = 12 },

                // Categories for Project 19
                new { ProjectId = 19, CategoryId = 1 },
                new { ProjectId = 19, CategoryId = 6 },
                new { ProjectId = 19, CategoryId = 9 },
                new { ProjectId = 19, CategoryId = 11 },

                // Categories for Project 20
                new { ProjectId = 20, CategoryId = 4 },

                // Categories for Project 21
                new { ProjectId = 21, CategoryId = 8 },
                new { ProjectId = 21, CategoryId = 10 },

                // Categories for Project 22
                new { ProjectId = 22, CategoryId = 3 },
                new { ProjectId = 22, CategoryId = 11 },

                // Categories for Project 23
                new { ProjectId = 23, CategoryId = 2 },
                new { ProjectId = 23, CategoryId = 5 },
                new { ProjectId = 23, CategoryId = 8 },
                new { ProjectId = 23, CategoryId = 12 },

                // Categories for Project 24
                new { ProjectId = 24, CategoryId = 7 },

                // Categories for Project 25
                new { ProjectId = 25, CategoryId = 1 },
                new { ProjectId = 25, CategoryId = 6 },
                new { ProjectId = 25, CategoryId = 9 },

                // Categories for Project 26
                new { ProjectId = 26, CategoryId = 4 },
                new { ProjectId = 26, CategoryId = 10 },

                // Categories for Project 27
                new { ProjectId = 27, CategoryId = 8 },

                // Categories for Project 28
                new { ProjectId = 28, CategoryId = 3 },
                new { ProjectId = 28, CategoryId = 11 },
                new { ProjectId = 28, CategoryId = 12 },

                // Categories for Project 29
                new { ProjectId = 29, CategoryId = 2 },
                new { ProjectId = 29, CategoryId = 5 },

                // Categories for Project 30
                new { ProjectId = 30, CategoryId = 7 },
                new { ProjectId = 30, CategoryId = 12 },
                new { ProjectId = 30, CategoryId = 10 },
                new { ProjectId = 30, CategoryId = 9 }
            );
        }
        #endregion
    }
}
