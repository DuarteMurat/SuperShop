using SuperShop.Data.Entities;
using SuperShop.Models;

namespace SuperShop.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductsViewModel model,string path, bool isNew); 

        ProductsViewModel ToProductViewModel (Product product);
    }
}
