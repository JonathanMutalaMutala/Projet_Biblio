using Microsoft.AspNetCore.Mvc;

namespace Projet_Biblio.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
