using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data.Models;
using static TRBabyShop.Infrastructure.Data.Common.Constants;

namespace TRBabyShop.Areas.Users.Controllers
{
    [Area("Users")]
    [Authorize(Roles =Status.RoleCustomer)]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await categoryService.GetCategoriesAsync();
            return View(model);
        }

       
    }
}
