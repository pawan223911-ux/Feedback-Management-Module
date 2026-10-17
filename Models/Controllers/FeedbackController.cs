using Microsoft.AspNetCore.Mvc;
using Practical_7.Models;

namespace Practical_7.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitFeedback(FeedbackModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Feedback submitted successfully!";
                return View("Success", model);
            }

            return View("Index", model);
        }
    }
}
