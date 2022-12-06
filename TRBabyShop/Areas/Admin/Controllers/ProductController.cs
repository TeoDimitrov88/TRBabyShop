using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Models;

namespace TRBabyShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService prodService;
        private readonly ApplicationDbContext dbContext;
        private readonly IRepository repo;

        public ProductController(IProductService _prodService, ApplicationDbContext _dbContext, IRepository _repo)
        {
            prodService = _prodService; 
            dbContext = _dbContext;
            repo = _repo;
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

        [HttpGet]
        public async Task<IActionResult> Update(int productId)
        {
            if (productId == 0)
            {
                return NotFound();
            }
            var product = await prodService.GetProductById(productId);
            var categoryId=await prodService.GetProductsCategoryId(productId);

            var model = new UpdateProductVM()
            {
                Id = productId,
                Name = product.Name,
                Description=product.Description,
                Price = product.Price,
                CategoryId = categoryId,
                Image = product.Image,
                Categories= await prodService.GetCategoriesAsync()
            };
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int productId, UpdateProductVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await prodService.UpdateProductAsync(model.Id, model);

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
