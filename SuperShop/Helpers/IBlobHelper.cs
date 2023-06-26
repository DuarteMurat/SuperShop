using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public interface IBlobHelper
    {
        Task<Guid> UplodadBlobAsync(IFormFile file, string containerName);
        Task<Guid> UplodadBlobAsync(byte[] file, string containerName);
        Task<Guid> UplodadBlobAsync(string image, string containerName);

    }
}
