using Microsoft.AspNetCore.Mvc;
using WSA_Final_Project.Models;

namespace WSA_Final_Project.Controllers
{
    public class FilamentController : Controller
    {
        private WSAFinalContext context { get; set; }

        public FilamentController(WSAFinalContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var filaments = context.Filaments.ToList();
            return View(filaments);
        }

        [HttpGet("json")]
        public IActionResult GetAllFilaments()
        {
            var filaments = context.Filaments.ToList();
            return Json(filaments);
        }
    }
}
