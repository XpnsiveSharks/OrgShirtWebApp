using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OrgShirtWebApp.Views.Home
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        //display name customize the obj name instead of displaying the default name of the table it will display the formated one
        [DisplayName("Product Price")]
        public float ProductPrice { get; set; }
        [Required]
        //custom validation
        [Range(1, 100, ErrorMessage = "Product Quantity must be between 1-100 only")]
        [DisplayName("Product Quantity")]
        public int ProductQuantity { get; set; }
        [Required]
        [DisplayName("Product Description")]
        public string ProductDescription { get; set; }
    }
}
