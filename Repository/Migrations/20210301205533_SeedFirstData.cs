using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class SeedFirstData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Training",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 375, DateTimeKind.Local).AddTicks(2342),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 254, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Technology",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 374, DateTimeKind.Local).AddTicks(1950),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 253, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Task",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 373, DateTimeKind.Local).AddTicks(3287),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 253, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skill",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 372, DateTimeKind.Local).AddTicks(5480),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 252, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ProfessionalExperience",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 370, DateTimeKind.Local).AddTicks(4969),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 250, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "PEType",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 369, DateTimeKind.Local).AddTicks(2778),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 248, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Person",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 356, DateTimeKind.Local).AddTicks(5614),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 236, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Link",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 368, DateTimeKind.Local).AddTicks(5476),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 248, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Language",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 367, DateTimeKind.Local).AddTicks(8632),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 247, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Distinction",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 366, DateTimeKind.Local).AddTicks(8589),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 246, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.InsertData(
                table: "PEType",
                columns: new[] { "ID", "ModificationDate", "Title" },
                values: new object[,]
                {
                    { 1L, null, "Consultant" },
                    { 2L, null, "Stage" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "ID", "Address", "Email", "ModificationDate", "Name", "PhoneNumber", "Title" },
                values: new object[] { 1L, "52 rue gambetta, Levallois Perret 92300", "otmelib@gmail.com", null, "El Ibaoui Otmane", "0659058512", "Consultant Microsoft .Net/.Net Core / C#" });

            migrationBuilder.InsertData(
                table: "Technology",
                columns: new[] { "ID", "ModificationDate", "Title" },
                values: new object[,]
                {
                    { 20L, null, "Html" },
                    { 21L, null, "Css" },
                    { 22L, null, "csHtml" },
                    { 23L, null, "SQL" },
                    { 24L, null, "EntityFramework 6" },
                    { 25L, null, "nUnit" },
                    { 26L, null, "SpecFlow" },
                    { 27L, null, "AutoMapper" },
                    { 28L, null, "FluentValidation" },
                    { 29L, null, "RestSharp" },
                    { 30L, null, "SonarLint" },
                    { 31L, null, "FxCop" },
                    { 32L, null, "Security Code Scan" },
                    { 33L, null, "Application Insights" },
                    { 19L, null, "EntityFramework Core 3" },
                    { 18L, null, "EntityFramework 6" },
                    { 16L, null, "Asp.Net WebApi 2" },
                    { 34L, null, "PostMan" },
                    { 1L, null, "Visual Studio 2015" },
                    { 2L, null, "Visual Studio 2019" },
                    { 3L, null, "Visual Studio Code" },
                    { 4L, null, "TFS" },
                    { 5L, null, "GIT" },
                    { 6L, null, "Azure DevOps" },
                    { 7L, null, "SqlServer 2012" },
                    { 8L, null, "SqlServer 2016" },
                    { 9L, null, "PostgreSql" },
                    { 10L, null, "C#" },
                    { 11L, null, "TypeScript" },
                    { 12L, null, "JavaScript" },
                    { 13L, null, "jQuery" },
                    { 14L, null, "Asp.Net MVC 5" },
                    { 15L, null, "Asp.Net MVC Core" },
                    { 17L, null, "Asp.Net Core WebApi" },
                    { 35L, null, "Angular 5" }
                });

            migrationBuilder.InsertData(
                table: "Distinction",
                columns: new[] { "ID", "ModificationDate", "PersonID", "Title" },
                values: new object[,]
                {
                    { 1L, null, 1L, "2ème place au Microsoft Imagine Cup Maroc 2016" },
                    { 2L, null, 1L, "Bénévole au collectif Autisme Maroc 2016" },
                    { 3L, null, 1L, "Certifié MTA: Windows Server Administration Fundamentals" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "ID", "ModificationDate", "PersonID", "Score", "Title" },
                values: new object[,]
                {
                    { 1L, null, 1L, 90, "Francais" },
                    { 2L, null, 1L, 80, "Anglais" },
                    { 3L, null, 1L, 100, "Arabe" }
                });

            migrationBuilder.InsertData(
                table: "Link",
                columns: new[] { "ID", "ModificationDate", "PersonID", "Title", "Url" },
                values: new object[,]
                {
                    { 1L, null, 1L, "LinkedIn", "https://www.linkedin.com/in/otmane-el-ibaoui/" },
                    { 2L, null, 1L, "GitHub", "https://github.com/OtmElIB" }
                });

            migrationBuilder.InsertData(
                table: "ProfessionalExperience",
                columns: new[] { "ID", "CompanyName", "EndDate", "ModificationDate", "PersonID", "StartDate", "Title", "TypeID" },
                values: new object[,]
                {
                    { 4L, "AFNOR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consultant FullStack .Net Core", 1L },
                    { 3L, "SMoney", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consultant FullStack .Net Framework", 1L },
                    { 1L, "MNE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consultant .Net Framework MVC/C# ", 1L },
                    { 2L, "CDsicount", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consultant FullStack .Net Framework", 1L }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "ID", "ModificationDate", "PersonID", "Score", "Title" },
                values: new object[,]
                {
                    { 8L, null, 1L, 80, "TDD / BDD / nUnit / SpecFlow" },
                    { 1L, null, 1L, 90, "C# / TypeScript" },
                    { 2L, null, 1L, 80, "Asp.Net MVC / WebAPI " },
                    { 3L, null, 1L, 80, "Asp.Net / Asp.Net Core" },
                    { 4L, null, 1L, 70, "SqlServer / MySql / PostgreSql" },
                    { 5L, null, 1L, 90, "EF / EF Core" },
                    { 6L, null, 1L, 85, "Visual Studio / Visual Stuio Code" },
                    { 7L, null, 1L, 90, "TFS / Git / Azure DevOps / GitHub" }
                });

            migrationBuilder.InsertData(
                table: "Training",
                columns: new[] { "ID", "ModificationDate", "PersonID", "SchoolName", "Title", "Year" },
                values: new object[] { 1L, null, 1L, "EMSI", "Ingénierie informatique option MIAGE", 2016 });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "ID", "ModificationDate", "ProfessionalExperienceID", "Title" },
                values: new object[,]
                {
                    { 1L, null, 1L, "Migration de l'application web Massar de Silverlight vers Asp.Net MVC 5." },
                    { 25L, null, 4L, "Participation au développements du nouveau Framework qui sera par la suite utilisé par le reste des équipes" },
                    { 24L, null, 4L, "Développements de la partie parcours d’achats et l’espace personnel du site et paiement CB(ATOS)" },
                    { 23L, null, 4L, "Mise en place des architectures applicative du front office et back office" },
                    { 22L, null, 4L, "Front End : intégration des maquettes développées par l’intégrateur" },
                    { 21L, null, 4L, "Développement des tests unitaires et fonctionnels " },
                    { 20L, null, 4L, "Validation et pesage des Uses Story avec l’équipe PO" },
                    { 19L, null, 4L, "Refonte complète de la boutique normes (FrontOffice) qui sert à acheter et vendre ces dernières en utilisant la méthode Agile." },
                    { 18L, null, 3L, "Déploiement des applications et des différentes release su différents serveurs" },
                    { 17L, null, 3L, "Intégration continue via Azure DevOps" },
                    { 16L, null, 3L, "Développement destests unitaires surl’application" },
                    { 15L, null, 3L, "Conception, architecture etréalisation de la nouvelle application quisert de parcours d’inscription" },
                    { 26L, null, 4L, "Création de micro services pour chaque application tier" },
                    { 14L, null, 3L, "AsDéveloppement de la nouvelle version de l’espace partenaire" },
                    { 12L, null, 3L, "Développement des nouvelles fonctionnalités et maintenance des applications(l’Api et l’Espace partenaire) au sain de l’équipe cœur du métier de Smoney" },
                    { 11L, null, 2L, "Archivage, shelve, merge et Code Reviewsous TFS" },
                    { 10L, null, 2L, "Développement, tests unitaires et tests d'intégration" },
                    { 9L, null, 2L, "Analyse et correction des bugs sur les différents sites" },
                    { 8L, null, 2L, "Optimisation des performances" },
                    { 7L, null, 2L, "Développement des nouvelles fonctionnalités sur les différents sites: Cdiscount Market Place,Seller Zone,Esus,GoSport,Cdiscount Pro" },
                    { 6L, null, 2L, "Maintenance et évolution des services utilisés par les applications Cdiscount" },
                    { 5L, null, 1L, "Archivage et Shelve et Code Reviewsous TFS" },
                    { 4L, null, 1L, "Développement de nouvelles fonctionnalités" },
                    { 3L, null, 1L, "Amélioration des performances (time processing, bug fixes et utilisation d'Api externes pour une meilleure user experience)" },
                    { 2L, null, 1L, "Evolution des services utilisés par l'application Massar" },
                    { 13L, null, 3L, "Analyse et correction desbugssurlesdifférentes applications" },
                    { 27L, null, 4L, "Déploiement et intégration continue via Azure DevOps" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Distinction",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Distinction",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Distinction",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PEType",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "ID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "ID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "ID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "ID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "ID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "ID",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Training",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ProfessionalExperience",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ProfessionalExperience",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ProfessionalExperience",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ProfessionalExperience",
                keyColumn: "ID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PEType",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Training",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 254, DateTimeKind.Local).AddTicks(7301),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 375, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Technology",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 253, DateTimeKind.Local).AddTicks(9019),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 374, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Task",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 253, DateTimeKind.Local).AddTicks(1605),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 373, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skill",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 252, DateTimeKind.Local).AddTicks(5366),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 372, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ProfessionalExperience",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 250, DateTimeKind.Local).AddTicks(3203),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 370, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "PEType",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 248, DateTimeKind.Local).AddTicks(9726),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 369, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Person",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 236, DateTimeKind.Local).AddTicks(3045),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 356, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Link",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 248, DateTimeKind.Local).AddTicks(3125),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 368, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Language",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 247, DateTimeKind.Local).AddTicks(6768),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 367, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Distinction",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 21, 34, 15, 246, DateTimeKind.Local).AddTicks(7397),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 3, 1, 21, 55, 33, 366, DateTimeKind.Local).AddTicks(8589));
        }
    }
}
