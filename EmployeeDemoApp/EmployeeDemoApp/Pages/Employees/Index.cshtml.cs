using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeDemoApp.Data;
using EmployeeDemoApp.EmpModel;

namespace EmployeeDemoApp.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeDemoApp.Data.EmployeeDemoAppContext _context;

        public IndexModel(EmployeeDemoApp.Data.EmployeeDemoAppContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employee != null)
            {
                Employee = await _context.Employee.ToListAsync();
            }
        }
    }
}
