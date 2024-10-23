using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projet_Biblio.Models;

namespace Projet_Biblio.DbContext
{
    public class BiblioDbContext : IdentityDbContext<IdentityUser>
    {
        public BiblioDbContext(DbContextOptions<BiblioDbContext> options): base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Role> Roles {  get; set; }
        public DbSet<User> Users {  get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(BiblioDbContext).Assembly); 
        }

    }
}
