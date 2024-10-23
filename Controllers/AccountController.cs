using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Projet_Biblio.DbContext;
using Projet_Biblio.Models;
using Projet_Biblio.ViewModel;

namespace Projet_Biblio.Controllers
{
    public class AccountController : Controller
    {
        private readonly BiblioDbContext _biblioDbContext;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;


        public AccountController(BiblioDbContext biblioDbContext, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _biblioDbContext = biblioDbContext;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {

            var currentUser = _biblioDbContext.Users.Where(x => x.Email.Equals(loginDto.Email)).FirstOrDefault();

            // If we find any user 
            if (currentUser != null)
            {
                // We must connect the user 
                var result = await _signInManager.PasswordSignInAsync(currentUser, loginDto.Password, loginDto.RememberMe, lockoutOnFailure: true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(loginDto);
        }

        [HttpPost]
        public async Task<IActionResult> LogOut(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");

        }

        [AllowAnonymous]
        [HttpGet]
        public  IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(LoginDto loginViewModel)
        {

            var userInfo = new User
            {
                Email = loginViewModel.Email,
                UserName = loginViewModel.UserName,
                FirstName = loginViewModel.FirstName, 
                LastName = loginViewModel.LastName,
                IsActive = true, 
                
            };

            var userResult = await _userManager.CreateAsync(userInfo, loginViewModel.Password); // Permet de crée un utilisateur 

            if (userResult.Succeeded)
            {
                await _signInManager.SignInAsync(userInfo, isPersistent: false);
                await _userManager.AddToRoleAsync(userInfo, loginViewModel.Role);
                return RedirectToAction("Index", "Home"); // Redirige ver la page de connexion 
            }

            return View();

        }

    }
}
