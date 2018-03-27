using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Models;

namespace SimpleImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IImage _imageService;

        public GalleryController(IImage imageService)
        {
            _imageService = imageService;
        }
        
        public IActionResult Index()
        {

            var imageList = _imageService.GetAll();

            var model = new GalleryIndexModel() // Passing data to the view
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}