using CodeZone.Application.Contracts.Infrastructure;
using CodeZone.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Infrastructure.ImageService
{
    public class ImageToLocalService : IImageService
    {
        private readonly string _path;
        public ImageToLocalService()
        {
            _path = @"wwwroot\";
        }

        public bool DeleteImage(Item item)
        {
            try
            {
                string imagePath = $"images\\items\\item_{item.Id}";
                string fullPath = _path + imagePath;
                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<string> SaveImage(IFormFile file,Item item)
        {
            try
            {
                string fileExe = file.FileName.Split('.').Last();
                string imagePath = $"images\\items\\item_{item.Id}.{fileExe}";
                string fullPath = _path + imagePath;
                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }
                using (FileStream stream = File.Create(fullPath))
                {
                    await file.CopyToAsync(stream);
                }

                return imagePath;
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }
    }
}
