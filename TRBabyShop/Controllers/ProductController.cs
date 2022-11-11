using Microsoft.AspNetCore.Mvc;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Infrastructure.Data.Models;
using TRBabyShop.Models;

namespace TRBabyShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IRepository repo;

        public ProductController(IProductService _productService, IRepository _repo)
        {
            productService = _productService;
            repo = _repo;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await productService.GetProductAsync();
            return View(model);
        }

        public async Task<IActionResult> ProductsByCategory(int categoryId)
        {
            var model = await productService.GetProductsByCategoryAsync(categoryId);

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
        public async Task Update(int productId, ProductViewModel model)
        {
            var product = await repo.GetByIdAsync<Product>(productId);

            if (product != null)
            {
                product.Name = model.Name;
                product.Description = model.Description;
                product.Image = model.Image;
                product.Price = model.Price;
                product.Category = model.Category;

                repo.Update(product);
                await repo.SaveChangesAsync();
            }

            throw new ArgumentException("Product Id is invalid!");
        }

        public async Task<IActionResult> GetById(int productId)
        {
            var model = await productService.GetProductById(productId);
            return View(model);
        }
    }
}
