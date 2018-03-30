using System;
using System.Text;
using System.Collections.Generic;
using SimpleImageGallery.Data.Models;

namespace SimpleImageGallery.Data
{
    public interface IImage
    {
        IEnumerable<GalleryImage> GetAll();     // Whoever implements this, returns a collection of images
        IEnumerable<GalleryImage> GetWithTags(string tag);  // return images by tags that might be on the image
        GalleryImage GetById(int id);
    }
}