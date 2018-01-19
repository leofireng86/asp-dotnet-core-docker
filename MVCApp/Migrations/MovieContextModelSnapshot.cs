﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MvcMovie.Models;
using System;

namespace MvcMovie.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcMovie.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerName");

                    b.Property<int?>("MovieID");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("TotalPrice");

                    b.HasKey("BookingID");

                    b.HasIndex("MovieID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("MvcMovie.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("TicketPrice");

                    b.Property<string>("Title");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MvcMovie.Models.Booking", b =>
                {
                    b.HasOne("MvcMovie.Models.Movie", "Movie")
                        .WithMany("Bookings")
                        .HasForeignKey("MovieID");
                });
#pragma warning restore 612, 618
        }
    }
}
