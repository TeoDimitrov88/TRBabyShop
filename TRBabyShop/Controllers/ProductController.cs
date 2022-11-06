using Microsoft.AspNetCore.Mvc;
using TRBabyShop.Core.Contracts;

namespace TRBabyShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }
        public async Task<IActionResult> All()
        {
            var model = await productService.GetProductAsync();
            return View(model);
        }

        public async Task<IActionResult> ProductsByCategory(int categoryId)
        {
            var model=await productService.GetProductsByCategoryAsync(categoryId);

            return View(model);
        }
    }
}
