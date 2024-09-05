﻿// <auto-generated />
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240903074020_Edit User Id Table")]
    partial class EditUserIdTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Models.Department", b =>
                {
                    b.Property<string>("Dept_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Dept_Initial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dept_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dept_Id");

                    b.ToTable("TB_M_Department");
                });

            modelBuilder.Entity("API.Models.Roles", b =>
                {
                    b.Property<string>("Role_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Role_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Role_Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("API.Models.Users", b =>
                {
                    b.Property<string>("Uid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uid");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
