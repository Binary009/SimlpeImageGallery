using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleImageGallery.Models
{
    public class GalleryDetailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Tags { get; set; }
    }
}