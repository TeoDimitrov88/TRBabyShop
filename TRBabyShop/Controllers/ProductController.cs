using Microsoft.AspNetCore.Mvc;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Models;

namespace TRBabyShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }
        [HttpGet]
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

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddProductViewModel()
            {
                Categories = await productService.GetCategoriesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await productService.AddProductAsync(model);

                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Ooops ,something went wrong!");

                return View(model);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int productId)
        {
            await productService.DeleteProduct(productId);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int productId)
        {
            var product = await productService.GetProductById(productId);

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int productId, ProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await productService.UpdateProduct(productId, model);

                return RedirectToAction(nameof(All));
            }
            catch (Exception e)
            {
                var error = new ErrorViewModel { RequestId = e.Message };
                return View("Error", error);
            }
        }

        public async Task<IActionResult> GetById(int productId)
        {
            var model = await productService.GetProductById(productId);
            return View(model);
        }
    }
}
