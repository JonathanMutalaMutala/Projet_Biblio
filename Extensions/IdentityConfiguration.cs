using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projet_Biblio.DbContext;
using Projet_Biblio.Models;

namespace Projet_Biblio.Extensions
{
    public class IdentityConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            // Ajouter les roles par defaut nous avons trois roles 
            // Librarian,Member, EMPLOYEE, ADMIN
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Id = "524e1a90-a13f-4bc1-bea8-b062539bee1c",
                    Name = "Librarian",
                    NormalizedName = "LIBRARIAN",
                },
                new IdentityRole
                {
                    Id = "126de5ee-a527-4781-90ae-088f50c4e5bb",
                    Name = "Member",
                    NormalizedName = "MEMBER",
                },
                new IdentityRole
                {
                    Id = "237f8bf4-22ef-4f81-8375-92b5516ae1a0",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                },
                new IdentityRole
                {
                    Id = "33839dce-3f1d-4460-8c35-cec7aeac4608",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                }
            };

            builder.HasData(roles);
        }
    }
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();

           List<User> users = new List<User>()
           {
               new User()
               {
                    Id = "53965792-59c5-4d25-b6fa-c096541856d0",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "Admin",
                    NormalizedUserName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "qwerty"),
                    EmailConfirmed = true,
                    IsActive = true,
               },
               new User()
               {
                    Id = "c10e1a0e-9b8f-407e-8f38-f9ad7a8028d4",
                    Email = "librarian@localhost.com",
                    NormalizedEmail = "LIBRARIAN@LOCALHOST.COM",
                    FirstName = "librarian",
                    LastName = "librarian",
                    UserName = "librarian",
                    NormalizedUserName = "LIBRARIAN",
                    PasswordHash = hasher.HashPassword(null, "qwerty"),
                    EmailConfirmed = true, 
                    IsActive = true,
               },
               new User()
               {
                    Id = "011edf74-2c6e-4513-a965-4191f34405a9",
                    Email = "member@localhost.com",
                    NormalizedEmail = "MEMBER@LOCALHOST.COM",
                    FirstName = "Member",
                    LastName = "Member",
                    UserName = "Member",
                    NormalizedUserName = "MEMBER",
                    PasswordHash = hasher.HashPassword(null, "qwerty"),
                    EmailConfirmed = true, 
                    IsActive = true
               },
               new User()
               {
                    Id = "da1ce89a-476d-46d0-897e-ee7aa6576179",
                    Email = "employee@localhost.com",
                    NormalizedEmail = "EMPLOYEE@LOCALHOST.COM",
                    FirstName = "Employee",
                    LastName = "Employee",
                    UserName = "Employee",
                    NormalizedUserName = "EMPLOYEE",
                    PasswordHash = hasher.HashPassword(null, "qwerty"),
                    EmailConfirmed = true, 
                    IsActive = true,
               },
           };
            builder.HasData(users); 
        }
    }
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "33839dce-3f1d-4460-8c35-cec7aeac4608", // Admin Role
                    UserId = "53965792-59c5-4d25-b6fa-c096541856d0" // Admin User
                },
                new IdentityUserRole<string>
                {
                    RoleId = "524e1a90-a13f-4bc1-bea8-b062539bee1c", // Librarian Role
                    UserId = "c10e1a0e-9b8f-407e-8f38-f9ad7a8028d4" // Librarian User
                },
                new IdentityUserRole<string>
                {
                    RoleId = "126de5ee-a527-4781-90ae-088f50c4e5bb", // Member Role
                    UserId = "011edf74-2c6e-4513-a965-4191f34405a9" // Member User
                },
                new IdentityUserRole<string>
                {
                    RoleId = "237f8bf4-22ef-4f81-8375-92b5516ae1a0", // Employee Role
                    UserId = "da1ce89a-476d-46d0-897e-ee7aa6576179" // Employee User
                }
            );

        }
    }

}
