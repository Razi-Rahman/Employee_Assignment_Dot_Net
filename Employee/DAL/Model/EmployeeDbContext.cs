using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Model
{
    public class EmployeeDbContext : DbContext
    {


        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAttendance> EmployeeAttendances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            // Configure Employee entity
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 502030, EmployeeName = "Mehedi Hasan", EmployeeCode = "EMP319", EmployeeSalary = 50000 },
                new Employee { EmployeeId = 502031, EmployeeName = "Ashikur Rahman", EmployeeCode = "EMP321", EmployeeSalary = 45000 },
                new Employee { EmployeeId = 502032, EmployeeName = "Rakibul Islam", EmployeeCode = "EMP322", EmployeeSalary = 52000 }
            );

            modelBuilder.Entity<EmployeeAttendance>().HasData(
               new EmployeeAttendance { EmployeeId = 502030, AttendanceDate = new DateTime(2023, 06, 24), IsPresent = true, IsAbsent = false, IsOffday = false },
               new EmployeeAttendance { EmployeeId = 502031, AttendanceDate = new DateTime(2023, 06, 25), IsPresent = false, IsAbsent = true, IsOffday = false },
               new EmployeeAttendance { EmployeeId = 502032, AttendanceDate = new DateTime(2023, 06, 25), IsPresent = true, IsAbsent = false, IsOffday = false }
           );
        }
    }
}
