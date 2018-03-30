using System;
using System.Collections.Generic;
using SimpleImageGallery.Data;
using SimpleImageGallery.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace SimpleImageGallery.Services
{
    public class ImageService : IImage
    {
        private readonly SimpleImageGalleryDbContext _ctx;
        public ImageService(SimpleImageGalleryDbContext ctx)
        {
            _ctx = ctx;
        }
        
        public Enumerable<GalleryImage> GetAll()
        {
            // We have a reference to this DbContext
            return _ctx.GalleryImages
                .Include(img => img.Tags);      // Get all images from database including their tags
        }
        
        public GalleryImage GetById(int id)
        {
            // returns instance of gallery image that corresponds to the id that we pass to GetById
            return _ctx.GalleryImages.Find(id);
        }

        // Return images where the tags matches the tag that we pass it (string tag)
        public Enumerable<GalleryImage> GetWithTags(string tag)
        {
            return GetAll().Where(img
                => img.Tags
                .Any(t => t.Description == tag));   // Get all images where image matches the description passed in the tag(string)
        }
    }
}
