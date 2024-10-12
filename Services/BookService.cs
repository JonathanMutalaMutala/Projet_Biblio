using AutoMapper;
using Projet_Biblio.DbContext;
using Projet_Biblio.Models;
using Projet_Biblio.ViewModel.Book;

namespace Projet_Biblio.Services
{
    public interface IBookService
    {
        Task<int> Create(BookDto bookDto);
    }

    public class BookService : IBookService
    {
        private readonly IMapper _autoMapper;
        private readonly BiblioDbContext _biblioDbContext;


        public BookService(IMapper autoMapper, BiblioDbContext biblioDbContext)
        {
            _autoMapper = autoMapper;
            _biblioDbContext = biblioDbContext;
        }

        public async Task<int> Create(BookDto bookDto)
        {
            bookDto.IsActive = true;
            var Book = _autoMapper.Map<Book>(bookDto);

            if(Book != null)
            {
               await _biblioDbContext.AddAsync(Book);
               await _biblioDbContext.SaveChangesAsync();
               return Book.Id;
            }

            // Pour l'instant je retourne zero pour dire que l'operation ne se pas derouler comme prevu
            return 0; 
        }
    }
}
