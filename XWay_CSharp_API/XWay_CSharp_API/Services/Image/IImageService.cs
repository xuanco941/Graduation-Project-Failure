﻿using System.Drawing;
using System.Drawing.Imaging;

namespace XWay_CSharp_API.Services.Image
{
    public interface IImageService
    {
        public Bitmap Colorize(Bitmap bw);
        public bool IsImageFile(IFormFile file);
        public string GetContentType(string fileExtension);
        public ImageFormat GetImageFormat(string fileExtension);


    }
}
