﻿// <auto-generated />
using Labb4___Rest_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb4___Rest_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APILibrary.Models.Hobby", b =>
                {
                    b.Property<int>("HobbyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HobbyID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HobbyID");

                    b.ToTable("Hobby");

                    b.HasData(
                        new
                        {
                            HobbyID = 1,
                            Description = "Fishing club",
                            Title = "Fishing"
                        },
                        new
                        {
                            HobbyID = 2,
                            Description = "Racing with motorized vehicles.",
                            Title = "Racing"
                        },
                        new
                        {
                            HobbyID = 3,
                            Description = "Plant flowers.",
                            Title = "Gardening"
                        },
                        new
                        {
                            HobbyID = 4,
                            Description = "Skiing down steep slopes.",
                            Title = "Skiing"
                        });
                });

            modelBuilder.Entity("APILibrary.Models.Link", b =>
                {
                    b.Property<int>("LinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LinkID"));

                    b.Property<string>("LinkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LinkID");

                    b.ToTable("Link");

                    b.HasData(
                        new
                        {
                            LinkID = 1,
                            LinkName = "Google",
                            URL = "http://www.google.com"
                        },
                        new
                        {
                            LinkID = 2,
                            LinkName = "YouTube",
                            URL = "http://www.youtube.com"
                        },
                        new
                        {
                            LinkID = 3,
                            LinkName = "Facebook",
                            URL = "http://www.facebook.com"
                        },
                        new
                        {
                            LinkID = 4,
                            LinkName = "Twitter",
                            URL = "http://www.twitter.com"
                        },
                        new
                        {
                            LinkID = 5,
                            LinkName = "Instagram",
                            URL = "http://www.instagram.com"
                        },
                        new
                        {
                            LinkID = 6,
                            LinkName = "LinkedIn",
                            URL = "http://www.linkedin.com"
                        },
                        new
                        {
                            LinkID = 7,
                            LinkName = "Reddit",
                            URL = "http://www.reddit.com"
                        },
                        new
                        {
                            LinkID = 8,
                            LinkName = "Pinterest",
                            URL = "http://www.pinterest.com"
                        },
                        new
                        {
                            LinkID = 9,
                            LinkName = "Tumblr",
                            URL = "http://www.tumblr.com"
                        },
                        new
                        {
                            LinkID = 10,
                            LinkName = "Snapchat",
                            URL = "http://www.snapchat.com"
                        });
                });

            modelBuilder.Entity("APILibrary.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("PersonID");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            PersonID = 1,
                            FirstName = "Arne",
                            LastName = "Trampo",
                            Phone = 123483723
                        },
                        new
                        {
                            PersonID = 2,
                            FirstName = "Börje",
                            LastName = "Severinsson",
                            Phone = 124383723
                        },
                        new
                        {
                            PersonID = 3,
                            FirstName = "Sara",
                            LastName = "Palmqvist",
                            Phone = 123443723
                        },
                        new
                        {
                            PersonID = 4,
                            FirstName = "Reidar",
                            LastName = "Folkesson",
                            Phone = 123543723
                        },
                        new
                        {
                            PersonID = 5,
                            FirstName = "Elina",
                            LastName = "Johansson",
                            Phone = 125483723
                        },
                        new
                        {
                            PersonID = 6,
                            FirstName = "Hans",
                            LastName = "Gustavsson",
                            Phone = 126383723
                        },
                        new
                        {
                            PersonID = 7,
                            FirstName = "Lena",
                            LastName = "Karlsson",
                            Phone = 127443723
                        },
                        new
                        {
                            PersonID = 8,
                            FirstName = "Mikael",
                            LastName = "Lindgren",
                            Phone = 128543723
                        },
                        new
                        {
                            PersonID = 9,
                            FirstName = "Pernilla",
                            LastName = "Ekström",
                            Phone = 129483723
                        },
                        new
                        {
                            PersonID = 10,
                            FirstName = "Oscar",
                            LastName = "Nilsson",
                            Phone = 130383723
                        });
                });

            modelBuilder.Entity("APILibrary.Models.PersonHobby", b =>
                {
                    b.Property<int>("PersonHobbyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonHobbyID"));

                    b.Property<int>("HobbyID")
                        .HasColumnType("int");

                    b.Property<int>("LinkID")
                        .HasColumnType("int");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.HasKey("PersonHobbyID");

                    b.HasIndex("HobbyID");

                    b.HasIndex("LinkID");

                    b.HasIndex("PersonID");

                    b.ToTable("PersonHobby");

                    b.HasData(
                        new
                        {
                            PersonHobbyID = 1,
                            HobbyID = 1,
                            LinkID = 1,
                            PersonID = 1
                        },
                        new
                        {
                            PersonHobbyID = 2,
                            HobbyID = 2,
                            LinkID = 2,
                            PersonID = 2
                        },
                        new
                        {
                            PersonHobbyID = 3,
                            HobbyID = 3,
                            LinkID = 3,
                            PersonID = 3
                        },
                        new
                        {
                            PersonHobbyID = 4,
                            HobbyID = 4,
                            LinkID = 4,
                            PersonID = 4
                        },
                        new
                        {
                            PersonHobbyID = 5,
                            HobbyID = 1,
                            LinkID = 5,
                            PersonID = 5
                        },
                        new
                        {
                            PersonHobbyID = 6,
                            HobbyID = 2,
                            LinkID = 6,
                            PersonID = 6
                        },
                        new
                        {
                            PersonHobbyID = 7,
                            HobbyID = 3,
                            LinkID = 7,
                            PersonID = 7
                        },
                        new
                        {
                            PersonHobbyID = 8,
                            HobbyID = 4,
                            LinkID = 8,
                            PersonID = 8
                        },
                        new
                        {
                            PersonHobbyID = 9,
                            HobbyID = 1,
                            LinkID = 9,
                            PersonID = 9
                        },
                        new
                        {
                            PersonHobbyID = 10,
                            HobbyID = 2,
                            LinkID = 10,
                            PersonID = 10
                        });
                });

            modelBuilder.Entity("APILibrary.Models.PersonHobby", b =>
                {
                    b.HasOne("APILibrary.Models.Hobby", "Hobby")
                        .WithMany()
                        .HasForeignKey("HobbyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APILibrary.Models.Link", "Link")
                        .WithMany()
                        .HasForeignKey("LinkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APILibrary.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hobby");

                    b.Navigation("Link");

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}