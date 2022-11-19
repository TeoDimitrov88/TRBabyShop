using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Core.Service;
using TRBabyShop.Infrastructure.Data.Models;
using TRBabyShop.Models;

namespace TRBabyShop.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        private readonly SignInManager<AppUser> signInManager;

        private readonly IUserService userservice;

        public UserController(
           UserManager<AppUser> _userManager,
           SignInManager<AppUser> _signInManager, IUserService _userservice)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            userservice = _userservice;
        }

        [HttpGet]
        [AllowAnonymous]

        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index","Home");
            }
            var model = new RegisterViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var newUser = new AppUser()
            {
                Email = model.Email,
                UserName = model.UserName,
            };

            var result = await userManager.CreateAsync(newUser, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "User");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]

        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Login", "User");
            }
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");

                }
            }
            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> MyFavoriteProducts()
        {
            try
            {
                var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                var model = await userservice.GetFavoriteProductForUsersAsync(userId);

                return View("Favorite", model);
            }
            catch (Exception e)
            {
                var error = new ErrorViewModel { RequestId = e.Message };
                return View("Error", error);
            }
        }

        public async Task<IActionResult> AddToCollection(int productId)
        {
            try
            {
                var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                await userservice.AddProductToUserCollectionAsync(productId, userId);
            }
            catch (Exception e)
            {
                var erroMassage = new ErrorViewModel { RequestId = e.Message };
                return View("Error", erroMassage);
            }

            return RedirectToAction(nameof(MyFavoriteProducts));
        }
        public async Task<IActionResult> RemoveFromCollection(int productId)
        {
            try
            {
                var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                await userservice.RemoveProductFromFavoriteAsync(productId, userId);
                return RedirectToAction(nameof(MyFavoriteProducts));
            }
            catch (Exception ex)
            {
                var error = new ErrorViewModel { RequestId = ex.Message };
                return View("Error", error);
            }

        }
    }
}
