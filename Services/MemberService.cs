using Projet_Biblio.DbContext;
using Projet_Biblio.ViewModel;

namespace Projet_Biblio.Services
{
    public interface IMemberService
    {
        Task CreateAsync(MemberDto memberDto); 
    }


    public class MemberService : IMemberService
    {
        private readonly BiblioDbContext _biblioDbContext;

        public MemberService(BiblioDbContext biblioDbContext)
        {
            _biblioDbContext = biblioDbContext;
        }

        public Task CreateAsync(MemberDto memberDto)
        {
            throw new NotImplementedException();
        }
    }
}
