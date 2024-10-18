using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Projet_Biblio.DbContext;
using Projet_Biblio.Models;
using Projet_Biblio.ViewModel.Book;
using System.Collections.Immutable;

namespace Projet_Biblio.Services
{
    public interface IBookService
    {
        Task<int> CreateAsync(BookDto bookDto);
        Task<List<BookDto>> GetAllBooksAsync();
        Task<BookDto> GetBookByIdAsync(int id);
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

        public async Task<int> CreateAsync(BookDto bookDto)
        {
            bookDto.IsActive = true;
            var Book = _autoMapper.Map<Book>(bookDto);

            if(Book != null)
            {
               await _biblioDbContext.AddAsync(Book);
               await _biblioDbContext.SaveChangesAsync();
               return Book.Id;
            }

            throw new Exception("erreur ajout"); 
        }

        public async Task<List<BookDto>> GetAllBooksAsync()
        {
            var allBooks = await _biblioDbContext.Books.ToListAsync(); 

            if(allBooks == null)
            {
                throw new Exception("Error de books"); 
            }

            return _autoMapper.Map<List<BookDto>>(allBooks);
        }

        public async Task<BookDto> GetBookByIdAsync(int id)
        {
           var singlBook  = await _biblioDbContext.Books.FirstOrDefaultAsync(x => x.Id == id && x.IsActive);

            if(singlBook == null)
            {
                throw new Exception("Not found"); 
            }

            return _autoMapper.Map<BookDto>(singlBook);
        }
    }
}
