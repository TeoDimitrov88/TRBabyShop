using Microsoft.AspNetCore.Mvc;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }
        public async Task<IActionResult> All()
        {
            var model = await categoryService.GetCategoriesAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new CategoryViewModel();
            await categoryService.AddCategoryAsync(model);
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
                await categoryService.AddCategoryAsync(model);

                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Ooops ,something went wrong!");

                return View(model);
            }
        }
    }
}
