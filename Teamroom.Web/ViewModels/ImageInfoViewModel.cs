﻿namespace HobbyClue.Web.ViewModels
{
    public class ImageInfoViewModel
    {
        public string Name { get; set; }

        public string ThumbnailUrl { get; set; }

        public string Url { get; set; }

        public string Error { get; set; }

        public string Size { get; set; }
        
        public bool IsActive { get; set; }

        public bool IsPrivate { get; set; }
    }
}