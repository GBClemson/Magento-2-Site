using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SeedPark_01.Models;

namespace SeedPark_01.Migrations
{
    [DbContext(typeof(SeedPark_01Context))]
    [Migration("20170709141018_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SeedPark_01.Models.Products", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<decimal>("Price");

                    b.Property<int>("Rank");

                    b.Property<string>("Tagline");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });
        }
    }
}
