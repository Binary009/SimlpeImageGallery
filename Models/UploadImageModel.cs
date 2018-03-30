using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace SimpleImageGallery.Models
{
    public class UploadImageModel
    {
        public string Title { get; set; }
        public string Tags { get; set; }    // A user upload an image and specify comma-seperated tags in a form text field
        public IFormFile ImageUpload { get; set; }
    }
}