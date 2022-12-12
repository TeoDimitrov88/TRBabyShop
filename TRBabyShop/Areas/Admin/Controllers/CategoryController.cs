using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using static TRBabyShop.Infrastructure.Data.Common.Constants;

namespace TRBabyShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Status.RoleAdmin)]
    public class CategoryController : Controller
    {
        private readonly ICategoryService cateService;

        public CategoryController(ICategoryService _cateService)
        {
            cateService = _cateService;
        }
        [HttpGet]
        public IActionResult Add()
        {
           
            var model = new CategoryViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await cateService.AddCategoryAsync(model);

                return RedirectToAction("All", "Category", new { area = "Users" });
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Ooops ,something went wrong!");

                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int categoryId)
        {
            await cateService.DeleteCategory(categoryId);

            return RedirectToAction("All", "Category", new { area = "Users" });
        }
    }
}
