using System;
using System.Text;
using System.Collections.Generic;
using SimpleImageGallery.Data.Models;

namespace SimpleImageGallery.Data
{
    public interface IImage
    {
        IEnumerable<GalleryImage> GetAll();     // return a collection of images
        IEnumerable<GalleryImage> GetWithTags(string tag);
        GalleryImage GetById(int id);
    }
}