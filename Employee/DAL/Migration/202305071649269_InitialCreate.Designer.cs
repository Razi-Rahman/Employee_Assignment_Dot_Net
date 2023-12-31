﻿using System;
using System.Runtime.Remoting.Contexts;
using EmployeeCRUDOperationAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;



namespace EmployeeCRUDOperationAPI.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("202305071649269_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Employee.Models.Employee", b =>
            {
                b.Property<int>("EmployeeId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                b.Property<string>("EmployeeCode")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("EmployeeName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("EmployeeSalary")
                    .HasColumnType("decimal(18,2)");

                b.HasKey("EmployeeId");

                b.ToTable("Employees");
            });

            modelBuilder.Entity("Employee.Models.EmployeeAttendance", b =>
            {
                b.Property<int>("EmployeeId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                b.Property<DateTime>("AttendanceDate")
                    .HasColumnType("datetime2");

                b.Property<bool>("IsAbsent")
                    .HasColumnType("bit");

                b.Property<bool>("IsOffday")
                    .HasColumnType("bit");

                b.Property<bool>("IsPresent")
                    .HasColumnType("bit");

                b.HasKey("EmployeeId");

                b.ToTable("EmployeeAttendances");
            });
#pragma warning restore 612, 618
        }
    }
}