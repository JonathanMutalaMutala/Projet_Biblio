using AutoMapper;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Projet_Biblio.Models;
using Projet_Biblio.ViewModel.Book;

namespace Projet_Biblio.MappingProfiles
{
    public class BiblioProfile : Profile
    {
        public BiblioProfile()
        {
            CreateMap<Book,BookDto>().ReverseMap();
        }
    }
}
