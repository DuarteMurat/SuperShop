using Microsoft.AspNetCore.Http;
using SuperShop.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace SuperShop.Models
{
    public class ProductsViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
