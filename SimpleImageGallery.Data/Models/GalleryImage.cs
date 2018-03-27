using System;
using System.Collections.Generic;

namespace SimpleImageGallery.Data.Models
{
    public class GalleryImage
    {
        // Properties of an instance of a gallery image
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string Url { get; set; }         // Storing image in cloud
        public virtual IEnumerable<ImageTag> Tags { get; set; }   // Users can tag pics and they can search on  
    }
}