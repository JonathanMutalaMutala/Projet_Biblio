using Microsoft.EntityFrameworkCore;
using Projet_Biblio.DbContext;
using Projet_Biblio.Models;
using Projet_Biblio.ViewModel;

namespace Projet_Biblio.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers(); 
    }


    public class UserService : IUserService
    {
        private readonly BiblioDbContext _biblioDbContext;

        public UserService(BiblioDbContext biblioDbContext)
        {
            _biblioDbContext = biblioDbContext;
        }

        public async Task<List<User>> GetAllUsers()
        {
           return await _biblioDbContext.Users.Where(x => x.IsActive).ToListAsync();
        }
    }
}
