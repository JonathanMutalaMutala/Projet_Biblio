using Projet_Biblio.Services;
using System.Reflection;

namespace Projet_Biblio.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
            //Ajout du service autoMapper à la collection des services 
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
