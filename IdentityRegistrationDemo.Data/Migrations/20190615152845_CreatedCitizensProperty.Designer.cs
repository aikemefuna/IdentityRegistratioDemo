﻿// <auto-generated />
using System;
using IdentityRegistrationDemo.Data.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IdentityRegistrationDemo.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190615152845_CreatedCitizensProperty")]
    partial class CreatedCitizensProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityRegistrationDemo.Data.DbEntities.Citizen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BVN");

                    b.Property<string>("ContactAddress")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LGA")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("MotherMaidenName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Occupation")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("ReferenceAddress")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ReferenceName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ReferencePhoneNumber")
                        .IsRequired();

                    b.Property<string>("StateOfOrigin")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Citizens");
                });
#pragma warning restore 612, 618
        }
    }
}