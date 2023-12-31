﻿using System;
using EmployeeCRUDOperationAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace EmployeeCRUDOperationAPI.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20230606198124_SeedEmployeeAttendanceTable")]
    partial class SeedEmployeeAttendanceTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeCRUDOperationAPI.Models.Employee", b =>
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

                b.HasData(
                    new
                    {
                        EmployeeId = 502030,
                        EmployeeCode = "EMP319",
                        EmployeeName = "Mehedi Hasan",
                        EmployeeSalary = 50000m
                    },
                    new
                    {
                        EmployeeId = 502031,
                        EmployeeCode = "EMP321",
                        EmployeeName = "Ashikur Rahman",
                        EmployeeSalary = 45000m
                    },
                    new
                    {
                        EmployeeId = 502032,
                        EmployeeCode = "EMP322",
                        EmployeeName = "Rakibul Islam",
                        EmployeeSalary = 52000m
                    });
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

                b.HasData(
                    new
                    {
                        EmployeeId = 502030,
                        AttendanceDate = new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        IsAbsent = false,
                        IsOffday = false,
                        IsPresent = true
                    },
                    new
                    {
                        EmployeeId = 502031,
                        AttendanceDate = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        IsAbsent = true,
                        IsOffday = false,
                        IsPresent = false
                    },
                    new
                    {
                        EmployeeId = 502032,
                        AttendanceDate = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        IsAbsent = false,
                        IsOffday = false,
                        IsPresent = true
                    });
            });
#pragma warning restore 612, 618
        }
    }
}