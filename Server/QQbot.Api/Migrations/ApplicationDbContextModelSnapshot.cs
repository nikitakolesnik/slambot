﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QQbot.DataAccessLayer.Contexts;

namespace QQbot.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QQbot.DataAccessLayer.Entities.AdminAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectMatchId")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectPlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("SubjectMatchId");

                    b.HasIndex("SubjectPlayerId");

                    b.ToTable("AdminHistory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminId = 1,
                            SubjectPlayerId = 1,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(6392)
                        },
                        new
                        {
                            Id = 2,
                            AdminId = 1,
                            SubjectPlayerId = 2,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(8883)
                        },
                        new
                        {
                            Id = 3,
                            AdminId = 1,
                            SubjectPlayerId = 3,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(8970)
                        },
                        new
                        {
                            Id = 4,
                            AdminId = 1,
                            SubjectPlayerId = 4,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9009)
                        },
                        new
                        {
                            Id = 5,
                            AdminId = 1,
                            SubjectPlayerId = 5,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9050)
                        },
                        new
                        {
                            Id = 6,
                            AdminId = 1,
                            SubjectPlayerId = 6,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9088)
                        },
                        new
                        {
                            Id = 7,
                            AdminId = 1,
                            SubjectPlayerId = 7,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9124)
                        },
                        new
                        {
                            Id = 8,
                            AdminId = 1,
                            SubjectPlayerId = 8,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9160)
                        },
                        new
                        {
                            Id = 9,
                            AdminId = 1,
                            SubjectPlayerId = 9,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9198)
                        },
                        new
                        {
                            Id = 10,
                            AdminId = 1,
                            SubjectPlayerId = 10,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9236)
                        },
                        new
                        {
                            Id = 11,
                            AdminId = 1,
                            SubjectPlayerId = 11,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9272)
                        },
                        new
                        {
                            Id = 12,
                            AdminId = 1,
                            SubjectPlayerId = 12,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9308)
                        },
                        new
                        {
                            Id = 13,
                            AdminId = 1,
                            SubjectPlayerId = 13,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9432)
                        },
                        new
                        {
                            Id = 14,
                            AdminId = 1,
                            SubjectPlayerId = 14,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9473)
                        },
                        new
                        {
                            Id = 15,
                            AdminId = 1,
                            SubjectPlayerId = 15,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9508)
                        },
                        new
                        {
                            Id = 16,
                            AdminId = 1,
                            SubjectPlayerId = 16,
                            Type = 2,
                            When = new DateTime(2020, 3, 26, 7, 48, 52, 523, DateTimeKind.Utc).AddTicks(9543)
                        });
                });

            modelBuilder.Entity("QQbot.DataAccessLayer.Entities.LobbyPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Joined")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("TeamNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Lobby");
                });

            modelBuilder.Entity("QQbot.DataAccessLayer.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LosingTeamId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Submitted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WinningTeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LosingTeamId");

                    b.HasIndex("WinningTeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("QQbot.DataAccessLayer.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Discord")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Submitted")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Discord")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Discord = 240413827718578177L,
                            Name = "Slam",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(2524)
                        },
                        new
                        {
                            Id = 2,
                            Discord = 175325337196953600L,
                            Name = "Yoko",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3488)
                        },
                        new
                        {
                            Id = 3,
                            Discord = 287275232236929026L,
                            Name = "Candyboy",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3504)
                        },
                        new
                        {
                            Id = 4,
                            Discord = 232147476008796161L,
                            Name = "Godly",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3506)
                        },
                        new
                        {
                            Id = 5,
                            Discord = 416266623847235584L,
                            Name = "Santana",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3507)
                        },
                        new
                        {
                            Id = 6,
                            Discord = 208987498368598016L,
                            Name = "Purif",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3511)
                        },
                        new
                        {
                            Id = 7,
                            Discord = 361620009815900170L,
                            Name = "Chrona",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3512)
                        },
                        new
                        {
                            Id = 8,
                            Discord = 382998762533945344L,
                            Name = "Lisek",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3527)
                        },
                        new
                        {
                            Id = 9,
                            Discord = 277194459576532992L,
                            Name = "Oln",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3528)
                        },
                        new
                        {
                            Id = 10,
                            Discord = 288009866080157697L,
                            Name = "Rainy",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3531)
                        },
                        new
                        {
                            Id = 11,
                            Discord = 465126942656561152L,
                            Name = "Butters",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3532)
                        },
                        new
                        {
                            Id = 12,
                            Discord = 241149128216674305L,
                            Name = "Takida",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3534)
                        },
                        new
                        {
                            Id = 13,
                            Discord = 99492885015048192L,
                            Name = "Jo",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3535)
                        },
                        new
                        {
                            Id = 14,
                            Discord = 221445321530540032L,
                            Name = "Bounty",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3536)
                        },
                        new
                        {
                            Id = 15,
                            Discord = 430796233783640066L,
                            Name = "Cracks",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3538)
                        },
                        new
                        {
                            Id = 16,
                            Discord = 242126086983516160L,
                            Name = "Jonas",
                            Rating = 1000,
                            Status = 2,
                            Submitted = new DateTime(2020, 3, 26, 7, 48, 52, 522, DateTimeKind.Utc).AddTicks(3539)
                        });
                });

            modelBuilder.Entity("QQbot.DataAccessLayer.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("QQbot.DataAccessLayer.Entities.TeamPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamPlayers");
                });

            modelBuilder.Entity("QQbot.DataAccessLayer.Entities.AdminAction", b =>
                {
                    b.HasOne("QQbot.DataAccessLayer.Entities.Player", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QQbot.DataAccessLayer.Entities.Match", "SubjectMatch")
                        .WithMany()
                        .HasForeignKey("SubjectMatchId");

                    b.HasOne("QQbot.DataAccessLayer.Entities.Player", "SubjectPlayer")
                        .WithMany()
                        .HasForeignKey("SubjectPlayerId");
                });

            modelBuilder.Entity("QQbot.DataAccessLayer.Entities.LobbyPlayer", b =>
                {
                    b.HasOne("QQbot.DataAccessLayer.Entities.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QQbot.DataAccessLayer.Entities.Match", b =>
                {
                    b.HasOne("QQbot.DataAccessLayer.Entities.Team", "LosingTeam")
                        .WithMany()
                        .HasForeignKey("LosingTeamId");

                    b.HasOne("QQbot.DataAccessLayer.Entities.Team", "WinningTeam")
                        .WithMany()
                        .HasForeignKey("WinningTeamId");
                });

            modelBuilder.Entity("QQbot.DataAccessLayer.Entities.TeamPlayer", b =>
                {
                    b.HasOne("QQbot.DataAccessLayer.Entities.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QQbot.DataAccessLayer.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });
#pragma warning restore 612, 618
        }
    }
}
