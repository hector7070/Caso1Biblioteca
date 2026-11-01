using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
