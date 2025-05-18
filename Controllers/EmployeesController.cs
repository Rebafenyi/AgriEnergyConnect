using Microsoft.AspNetCore.Mvc;
using AgriEnergyConnect.Data;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using AgriEnergyConnect.Models;

namespace AgriEnergyConnect.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees = _context.Set<Employees>().ToList(); // Explicitly specify the DbSet to resolve ambiguity
            return View(employees);
        }
    }
}
