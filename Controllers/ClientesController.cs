using CRUDProyect.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDProyect.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Lista a los clientes

        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }
    }
}
