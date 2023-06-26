using System;
using System.ComponentModel.DataAnnotations;
using static System.Net.WebRequestMethods;

namespace SuperShop.Data.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="The field {0} can contain {1} characters lenght.")]
        public string Name { get; set; }


        [DisplayFormat(DataFormatString ="{0:c2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }


        [Display(Name = "Image")]
        public Guid ImageId { get; set; }


        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase { get; set; }


        [Display(Name = "Last Sale")]
        public DateTime? LastSale{ get; set; }


        [Display(Name = "Is Avaiable")]
        public bool IsAvilable { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode =false)]
        public double Stock { get; set; }


        public User User { get; set; }

        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://supershopmurat.azurewebsites.net/images/noimage.png"
            : $"https://supershopmurat.blob.core.windows.net/products/{ImageId}";
    }
}
