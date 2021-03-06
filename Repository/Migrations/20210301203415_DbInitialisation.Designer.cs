﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210301203415_DbInitialisation")]
    partial class DbInitialisation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ProfessionalExperienceTechnology", b =>
                {
                    b.Property<long>("ProfessionalExperiencesID")
                        .HasColumnType("bigint");

                    b.Property<long>("TechnologiesID")
                        .HasColumnType("bigint");

                    b.HasKey("ProfessionalExperiencesID", "TechnologiesID");

                    b.HasIndex("TechnologiesID");

                    b.ToTable("ProfessionalExperienceTechnology");
                });

            modelBuilder.Entity("Repository.Models.Distinction", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2021, 3, 1, 21, 34, 15, 246, DateTimeKind.Local).AddTicks(7397));

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("PersonID")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Distinction");
                });

            modelBuilder.Entity("Repository.Models.Language", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2021, 3, 1, 21, 34, 15, 247, DateTimeKind.Local).AddTicks(6768));

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("PersonID")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("Repository.Models.Link", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2021, 3, 1, 21, 34, 15, 248, DateTimeKind.Local).AddTicks(3125));

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("PersonID")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("Repository.Models.PEType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2021, 3, 1, 21, 34, 15, 248, DateTimeKind.Local).AddTicks(9726));

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("PEType");
                });

            modelBuilder.Entity("Repository.Models.Person", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2021, 3, 1, 21, 34, 15, 236, DateTimeKind.Local).AddTicks(3045));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Repository.Models.ProfessionalExperience", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2021, 3, 1, 21, 34, 15, 250, DateTimeKind.Local).AddTicks(3203));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("PersonID")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("TypeID")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.HasIndex("TypeID");

                    b.ToTable("ProfessionalExperience");
                });

            modelBuilder.Entity("Repository.Models.Skill", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2021, 3, 1, 21, 34, 15, 252, DateTimeKind.Local).AddTicks(5366));

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("PersonID")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Repository.Models.Task", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2021, 3, 1, 21, 34, 15, 253, DateTimeKind.Local).AddTicks(1605));

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("ProfessionalExperienceID")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("ProfessionalExperienceID");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("Repository.Models.Technology", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2021, 3, 1, 21, 34, 15, 253, DateTimeKind.Local).AddTicks(9019));

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Technology");
                });

            modelBuilder.Entity("Repository.Models.Training", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2021, 3, 1, 21, 34, 15, 254, DateTimeKind.Local).AddTicks(7301));

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("PersonID")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("ProfessionalExperienceTechnology", b =>
                {
                    b.HasOne("Repository.Models.ProfessionalExperience", null)
                        .WithMany()
                        .HasForeignKey("ProfessionalExperiencesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Models.Technology", null)
                        .WithMany()
                        .HasForeignKey("TechnologiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Repository.Models.Distinction", b =>
                {
                    b.HasOne("Repository.Models.Person", "Person")
                        .WithMany("Distinctions")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Repository.Models.Language", b =>
                {
                    b.HasOne("Repository.Models.Person", "Person")
                        .WithMany("Languages")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Repository.Models.Link", b =>
                {
                    b.HasOne("Repository.Models.Person", "Person")
                        .WithMany("Links")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Repository.Models.ProfessionalExperience", b =>
                {
                    b.HasOne("Repository.Models.Person", "Person")
                        .WithMany("ProfessionalExperiences")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Models.PEType", "Type")
                        .WithMany("ProfessionalExperiences")
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Repository.Models.Skill", b =>
                {
                    b.HasOne("Repository.Models.Person", "Person")
                        .WithMany("Skills")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Repository.Models.Task", b =>
                {
                    b.HasOne("Repository.Models.ProfessionalExperience", "ProfessionalExperience")
                        .WithMany("Tasks")
                        .HasForeignKey("ProfessionalExperienceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProfessionalExperience");
                });

            modelBuilder.Entity("Repository.Models.Training", b =>
                {
                    b.HasOne("Repository.Models.Person", "Person")
                        .WithMany("Trainings")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Repository.Models.PEType", b =>
                {
                    b.Navigation("ProfessionalExperiences");
                });

            modelBuilder.Entity("Repository.Models.Person", b =>
                {
                    b.Navigation("Distinctions");

                    b.Navigation("Languages");

                    b.Navigation("Links");

                    b.Navigation("ProfessionalExperiences");

                    b.Navigation("Skills");

                    b.Navigation("Trainings");
                });

            modelBuilder.Entity("Repository.Models.ProfessionalExperience", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
