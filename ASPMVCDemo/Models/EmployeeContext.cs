using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPMVCDemo.Models
{
    public class EmployeeContext : DbContext
    {
         public DbSet<Employees> Employees { get; set; }
         public DbSet<Department> Departments { get; set; }
    }
}