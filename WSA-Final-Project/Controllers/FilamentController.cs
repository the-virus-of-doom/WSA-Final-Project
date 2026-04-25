using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return View();
        }

        [HttpGet("filaments")]
        public IActionResult GetAllFilaments()
        {
            var filaments = context.Filaments.ToList();
            return Json(filaments);
        }
    }
}
