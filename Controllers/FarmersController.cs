using Microsoft.AspNetCore.Mvc;
using AgriEnergyConnect.Data;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using AgriEnergyConnect.Models;

namespace AgriEnergyConnect.Controllers
{
    [Authorize]
    public class FarmersController : Controller // Fixed incorrect syntax for class declaration
    {
        private readonly ApplicationDbContext _context;

        public FarmersController(ApplicationDbContext context) // Fixed constructor syntax
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Farmer> farmers = _context.Set<Farmer>().ToList();
            return View(farmers);
        }
    }
}
