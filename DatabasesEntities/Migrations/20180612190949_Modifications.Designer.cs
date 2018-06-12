﻿// <auto-generated />
using System;
using DatabasesEntities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabasesEntities.Migrations
{
    [DbContext(typeof(SysKitContext))]
    [Migration("20180612190949_Modifications")]
    partial class Modifications
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatabasesEntities.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedByEmployeeId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<int?>("ModifiedByEmployeeId");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.Property<string>("VatId");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new { Id = 1, CreatedByEmployeeId = 1, DateCreated = new DateTime(2018, 6, 12, 21, 9, 48, 310, DateTimeKind.Local), Name = "SysKit", Status = 1, VatId = "Vat Id" }
                    );
                });

            modelBuilder.Entity("DatabasesEntities.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<int>("CreatedByEmployeeId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<bool?>("IsPotentialBuyer");

                    b.Property<string>("LastName");

                    b.Property<int?>("ModifiedByEmployeeId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new { Id = 1, CompanyId = 1, CreatedByEmployeeId = 1, DateCreated = new DateTime(2018, 6, 12, 21, 9, 48, 312, DateTimeKind.Local), FirstName = "David", LastName = "Čubela", Status = 1 }
                    );
                });

            modelBuilder.Entity("DatabasesEntities.Models.Employee", b =>
                {
                    b.HasOne("DatabasesEntities.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}