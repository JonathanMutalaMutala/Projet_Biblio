using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projet_Biblio.Models;
using Projet_Biblio.Services;
using Projet_Biblio.ViewModel;
using System.Diagnostics;

namespace Projet_Biblio.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _bookService;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IBookService bookService, IUserService userService)
        {
            _logger = logger;
            _bookService = bookService;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var allBooks = await _bookService.GetAllBooksAsync();
            var allUsers = await _userService.GetAllUsers();
            var model = new HomeViewModel()
            {
                BookDtos = allBooks,
                AllUsers = allUsers
            }; 

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
