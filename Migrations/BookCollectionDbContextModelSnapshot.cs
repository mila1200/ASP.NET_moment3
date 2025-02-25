﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moment3_ASPNET.Data;

#nullable disable

namespace Moment3_ASPNET.Migrations
{
    [DbContext(typeof(BookCollectionDbContext))]
    partial class BookCollectionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("Moment3_ASPNET.Models.AuthorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BirthYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Moment3_ASPNET.Models.BookModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AuthorModelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorModelId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Moment3_ASPNET.Models.BookModel", b =>
                {
                    b.HasOne("Moment3_ASPNET.Models.AuthorModel", "AuthorModel")
                        .WithMany("Books")
                        .HasForeignKey("AuthorModelId");

                    b.Navigation("AuthorModel");
                });

            modelBuilder.Entity("Moment3_ASPNET.Models.AuthorModel", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
