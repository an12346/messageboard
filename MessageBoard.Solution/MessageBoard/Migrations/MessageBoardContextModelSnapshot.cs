﻿// <auto-generated />
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    partial class MessageBoardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MessageBoard.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("GroupName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Description = "Cooking lessons",
                            GroupName = "Cooking"
                        },
                        new
                        {
                            GroupId = 2,
                            Description = "Weekly hiking group",
                            GroupName = "Hiking"
                        },
                        new
                        {
                            GroupId = 3,
                            Description = "Best camping spots",
                            GroupName = "Camping"
                        },
                        new
                        {
                            GroupId = 4,
                            Description = "DIY classes",
                            GroupName = "DIY"
                        },
                        new
                        {
                            GroupId = 5,
                            Description = "Crafting club",
                            GroupName = "Crafting"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}