using System;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Models;

namespace SimpleImageGallery.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Upload()
        {
            // Present the user with an empty form, user fills it out & post to another actionResult (will handle all properties the user provide to the new object to be created)
            var model = new UploadImageModel();
            return View(model);
        }

        // This method handles happens after user post image
        [HttpPost]
        public IAsyncResult UploadNewImage()
        {
            return Ok();
        }

        // Logic to parse out each tag seperated by comma.
    }
}