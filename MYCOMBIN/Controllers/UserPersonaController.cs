using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MYCOMBIN.Data;

namespace MYCOMBIN.Controllers
{
    public class UserPersonaController : Controller
    {

        private readonly DataContext _context;

        public UserPersonaController(DataContext context)
        {

            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Users = new SelectList(await _context.UserInfos.ToListAsync(), "Id", "FullName");
            ViewBag.Personas = new SelectList(await _context.Personas.ToListAsync(), "Id", "Description");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserPersona userPersona)
        {
            userPersona.CreateDate = DateTime.Now;
            _context.UserPersonas.Add(userPersona);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> List()
        {
            var userPersonaList = await _context.UserPersonas.ToListAsync();
            return View(userPersonaList);
        }

    }
}