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
            return _ctx.GalleryImages.Include(img => img.Tags);
        }
        public GalleryImage GetById(id)
        {
            // returns instance of gallery image that corresponds to the id that we pass to GetById
            return _ctx.GalleryImages.Find(id);
        }

        public Enumerable<GalleryImage> GetWithTags(string tag)
        {
            return GetAll().Where(Img
                => Img.Tags
                .Any(t => t.Description == tag));
        }
    }
}
