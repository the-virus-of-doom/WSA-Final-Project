using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WSA_Final_Project.Models;


namespace WSA_Final_Project.Controllers
{
    public class _3DPrintController : Controller
    {
        private WSAFinalContext context { get; set; }

        public _3DPrintController(WSAFinalContext context)
        {
            this.context = context;
        }

        [HttpGet("filaments")]
        public IActionResult GetAllFilaments()
        {
            var filaments = context.Filaments.ToList();
            return Json(filaments);
        }
    }
}
