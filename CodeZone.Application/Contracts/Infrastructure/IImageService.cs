using CodeZone.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Contracts.Infrastructure
{
    public interface IImageService
    {
        Task<string> SaveImage(IFormFile file,Item item);
        bool DeleteImage(Item item);
    }
}
