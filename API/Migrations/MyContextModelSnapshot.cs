﻿// <auto-generated />
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.Property<string>("Account_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Account_Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("API.Models.Department", b =>
                {
                    b.Property<string>("Dept_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Dept_Initial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dept_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dept_Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("API.Models.Employee", b =>
                {
                    b.Property<string>("Employee_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Dept_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Employee_Id");

                    b.HasIndex("Dept_Id");

                    b.ToTable("Employees");
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

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.HasOne("API.Models.Employee", "Employees")
                        .WithOne("Accounts")
                        .HasForeignKey("API.Models.Account", "Account_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("API.Models.Employee", b =>
                {
                    b.HasOne("API.Models.Department", "Departments")
                        .WithMany()
                        .HasForeignKey("Dept_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("API.Models.Employee", b =>
                {
                    b.Navigation("Accounts")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
