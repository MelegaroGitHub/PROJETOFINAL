using Microsoft.AspNetCore.Mvc;

namespace PROJETOFINAL.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index(){
            
            return View();
        }
    }
}