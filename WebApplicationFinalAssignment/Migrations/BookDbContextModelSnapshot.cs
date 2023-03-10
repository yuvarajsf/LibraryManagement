// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationFinalAssignment.Data;

namespace WebApplicationFinalAssignment.Migrations
{
    [DbContext(typeof(BookDbContext))]
    partial class BookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApplicationFinalAssignment.Models.BookCategories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("Bookcategory");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "IT",
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Electronics",
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2019, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Mechanical",
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Civil",
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2019, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Electricals",
                            IsDeleted = false,
                            UpdatedOn = new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Economics",
                            IsDeleted = true,
                            UpdatedOn = new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WebApplicationFinalAssignment.Models.Books", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("BookDept")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PublisherYear")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("BookId");

                    b.HasIndex("BookCategoryId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorName = "Balaguruswamy",
                            BookCategoryId = 1,
                            BookName = "C++",
                            IsDeleted = false,
                            Price = 500m,
                            PublisherYear = 2001,
                            UpdatedOn = new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 2,
                            AuthorName = "Mazidi",
                            BookCategoryId = 2,
                            BookName = "Microcontrollers",
                            IsDeleted = false,
                            Price = 550m,
                            PublisherYear = 2002,
                            UpdatedOn = new DateTime(2019, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 3,
                            AuthorName = "Sebastian",
                            BookCategoryId = 3,
                            BookName = "Robotics",
                            IsDeleted = false,
                            Price = 600m,
                            PublisherYear = 2003,
                            UpdatedOn = new DateTime(2019, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 4,
                            AuthorName = "Jacques Heyman",
                            BookCategoryId = 4,
                            BookName = "Structural Engineering",
                            IsDeleted = false,
                            Price = 800m,
                            PublisherYear = 2004,
                            UpdatedOn = new DateTime(2019, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 5,
                            AuthorName = "Michael Faraday",
                            BookCategoryId = 5,
                            BookName = "DC Motors",
                            IsDeleted = false,
                            Price = 400m,
                            PublisherYear = 2004,
                            UpdatedOn = new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 6,
                            AuthorName = "Nassim Nicholas",
                            BookCategoryId = 6,
                            BookName = "Economics",
                            IsDeleted = true,
                            Price = 300m,
                            PublisherYear = 2005,
                            UpdatedOn = new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 7,
                            AuthorName = "",
                            BookCategoryId = 1,
                            BookName = "Data Structure",
                            IsDeleted = false,
                            Price = 430m,
                            PublisherYear = 0,
                            UpdatedOn = new DateTime(2019, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 8,
                            AuthorName = "Abraham Silberschatz",
                            BookCategoryId = 1,
                            BookName = "Operating systems",
                            IsDeleted = true,
                            Price = 0m,
                            PublisherYear = 2007,
                            UpdatedOn = new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 9,
                            AuthorName = "William Gothmann",
                            BookCategoryId = 2,
                            BookName = "Digital Electronics",
                            IsDeleted = false,
                            Price = 0m,
                            PublisherYear = 0,
                            UpdatedOn = new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WebApplicationFinalAssignment.Models.Books", b =>
                {
                    b.HasOne("WebApplicationFinalAssignment.Models.BookCategories", "BookCategories")
                        .WithMany()
                        .HasForeignKey("BookCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
