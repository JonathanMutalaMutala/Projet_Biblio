using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_Biblio.Services;
using Projet_Biblio.ViewModel.Book;

namespace Projet_Biblio.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService; 

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }


        // GET: BookController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BookController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var currentBook = await _bookService.GetBookByIdAsync(id);
            return View();
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(BookDto bookDto)
        {
            // Faire la validation 
            if (!ModelState.IsValid)
                return View();


            try
            {
               await _bookService.CreateAsync(bookDto);

                return RedirectToAction("Index","Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
