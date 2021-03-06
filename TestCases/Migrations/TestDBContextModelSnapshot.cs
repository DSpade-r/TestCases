﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TestCases.Models;

namespace TestCases.Migrations
{
    [DbContext(typeof(TestDBContext))]
    partial class TestDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestCases.Models.CaseStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Step");

                    b.Property<int?>("TestCaseId");

                    b.HasKey("Id");

                    b.HasIndex("TestCaseId");

                    b.ToTable("CaseSteps");
                });

            modelBuilder.Entity("TestCases.Models.TestCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TestCases");
                });

            modelBuilder.Entity("TestCases.Models.CaseStep", b =>
                {
                    b.HasOne("TestCases.Models.TestCase", "TestCase")
                        .WithMany("CaseSteps")
                        .HasForeignKey("TestCaseId");
                });
#pragma warning restore 612, 618
        }
    }
}
