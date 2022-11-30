using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Models;

namespace TRBabyShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService prodService;

        public ProductController(IProductService _prodService)
        {
            prodService = _prodService;  
        }
       
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var category = await prodService.GetCategoriesAsync();
            var model = new AddProductViewModel()
            {
                Categories = category
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
                await prodService.AddProductAsync(model);

                return RedirectToAction("All", "Product", new { area = "Users" });
            }
            catch (Exception ex)
            {
                var error = new ErrorViewModel
                {
                    RequestId = ex.Message
                };
                return View("Error", error);
            }

        }
        [HttpPost]
        public async Task<IActionResult> Delete(int productId)
        {
            await prodService.DeleteProduct(productId);

            return RedirectToAction("All", "Product", new { area = "Users" });
        }

  
        public async Task<IActionResult> Update(int productId)
        {
            if (productId == 0)
            {
                return NotFound();
            }
            var product = await prodService.GetProductUpdateAsync(productId);

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int productId, ProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await prodService.UpdateProductAsync(productId, model);

                return RedirectToAction("All", "Product", new { area = "Users" });
            }
            catch (Exception ex)
            {
                var error = new ErrorViewModel { RequestId = ex.Message };
                return View("Error", error);
            }
        }

       
       
    }
}
