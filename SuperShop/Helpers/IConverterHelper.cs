using SuperShop.Data.Entities;
using SuperShop.Models;
using System;

namespace SuperShop.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductsViewModel model, Guid imageId, bool isNew); 

        ProductsViewModel ToProductViewModel (Product product);
    }
}
