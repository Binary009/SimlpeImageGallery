using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleImageGallery.Data.Models;

namespace SimpleImageGallery.Models
{
    public class GalleryIndexModel
    {
        // User should see a series of images they can interact on
        public IEnumerable<GalleryImage> Images { get; set; }
        public string SearchQuery { get; set; }     // A search box user can query and get the image, this property stores the user input
    }
}