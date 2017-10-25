﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Models;
using SimpleImageGallery.Data.Models;

namespace SimpleImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Description = "Adventure",
                Id =0
            };

            var tag2 = new ImageTag()
            {
                Description = "Urban",
                Id=1
            };

            var tag3 = new ImageTag()
            {
                Description = "New York",
                Id = 2
            };
            
            hikingImageTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag>{ tag2, tag3});
            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Hiking Trip",
                    Url = "https://static.pexels.com/photos/372098/pexels-photo-372098.jpeg",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },

                new GalleryImage()
                {
                    Title = "On Trail",
                    Url = "https://www.pexels.com/photo/adventure-alps-backpack-backpacker-554609/",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },

                 new GalleryImage()
                {
                    Title = "Downtown",
                    Url = "https://static.pexels.com/photos/373912/pexels-photo-373912.jpeg",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                }
            };
            var model = new GalleryIndexModel()
            {
                Images = imageList, 
                SearchQuery = ""
            };

            return View(model);
        }
    }
}