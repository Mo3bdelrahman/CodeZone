using CodeZone.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace CodeZone.Application.Contracts.Infrastructure
{
    public interface IImageService
    {
        Task<string> SaveImage(IFormFile file, Item item);
        bool DeleteImage(Item item);
    }
}
