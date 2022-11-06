using Microsoft.AspNetCore.Mvc;
using TRBabyShop.Contracts;

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
    }
}
