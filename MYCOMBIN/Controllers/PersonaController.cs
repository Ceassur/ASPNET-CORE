using Microsoft.AspNetCore.Mvc;
using MYCOMBIN.Data;

namespace MYCOMBIN.Controllers
{
    public class PersonaController : Controller
    {

        private readonly DataContext _context;

        public PersonaController(DataContext context)
        {

            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["HeaderName"] = "Persona Sayfası";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Persona persona)
        {
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();
            return View("Index", "Home");
        }
    }
}