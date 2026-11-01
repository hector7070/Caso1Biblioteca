using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class PrestamoLibrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
