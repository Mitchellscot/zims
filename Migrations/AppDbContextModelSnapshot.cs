﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ZIMS.Data;

namespace ZIMS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ZIMS.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("ResetToken")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Mitchellscott@me.com",
                            FirstName = "Mitchell",
                            LastName = "Scott",
                            PasswordHash = "$2a$11$6GOC938jotYVtUamR6ekKOqL6UTKPQ3NTKtrCSZ1SqppQNt3d.B9K",
                            ResetToken = "",
                            Role = "Manager"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Sarahscott@me.com",
                            FirstName = "Sarah",
                            LastName = "Scott",
                            PasswordHash = "$2a$11$HWrdjdtWVYer3SrtNj4N1OBTu78uJor9TATO/TUmNjLnPGgqxOOlK",
                            ResetToken = "",
                            Role = "Guide"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
