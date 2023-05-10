using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeDemoApp.EmpModel;

namespace EmployeeDemoApp.Data
{
    public class EmployeeDemoAppContext : DbContext
    {
        public EmployeeDemoAppContext (DbContextOptions<EmployeeDemoAppContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeDemoApp.EmpModel.Employee> Employee { get; set; } = default!;
    }
}
