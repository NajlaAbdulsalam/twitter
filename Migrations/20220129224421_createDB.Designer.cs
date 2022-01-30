﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Models;

namespace Test.Migrations
{
    [DbContext(typeof(TwitterDBContext))]
    [Migration("20220129224421_createDB")]
    partial class createDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test.Models.Comment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content");

                    b.Property<DateTime>("created_at");

                    b.Property<DateTime>("deleted_at");

                    b.Property<int?>("post_idid");

                    b.Property<int?>("replied_toid");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("id");

                    b.HasIndex("post_idid");

                    b.HasIndex("replied_toid");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Test.Models.Post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content");

                    b.Property<DateTime>("created_at");

                    b.Property<DateTime>("deleted_at");

                    b.Property<DateTime>("updated_at");

                    b.Property<int?>("user_idid");

                    b.HasKey("id");

                    b.HasIndex("user_idid");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Test.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created_at");

                    b.Property<string>("password");

                    b.Property<DateTime>("updated_at");

                    b.Property<string>("user_name");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Test.Models.Comment", b =>
                {
                    b.HasOne("Test.Models.Post", "post_id")
                        .WithMany()
                        .HasForeignKey("post_idid");

                    b.HasOne("Test.Models.Comment", "replied_to")
                        .WithMany()
                        .HasForeignKey("replied_toid");
                });

            modelBuilder.Entity("Test.Models.Post", b =>
                {
                    b.HasOne("Test.Models.User", "user_id")
                        .WithMany()
                        .HasForeignKey("user_idid");
                });
#pragma warning restore 612, 618
        }
    }
}