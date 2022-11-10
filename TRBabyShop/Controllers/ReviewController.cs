using Microsoft.AspNetCore.Mvc;
using TRBabyShop.Core.Contracts;

namespace TRBabyShop.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService reviewService;

        public ReviewController(IReviewService _reviewService)
        {
            reviewService = _reviewService;
        }

        public async Task<IActionResult> All(int productId)
        {
            var model = await reviewService.GetProductReviews(productId);

            return View(model);
        }
    }
}
