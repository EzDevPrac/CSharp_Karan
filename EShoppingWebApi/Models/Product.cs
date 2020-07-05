using System.ComponentModel.DataAnnotations;

namespace EShoppingWebApi.Models
{
    public class Product
    {
        private int productId;
        private string productName;
        private double productCost;
        //private int productQuantity;
        
        
        [Required(ErrorMessage = "Product id should not be Empty")]
        public int ProductId { get => productId; set => productId = value; }

        [Required(ErrorMessage = "Product Name should not be Empty")]
        public string ProductName { get => productName; set => productName = value; }

        [Required(ErrorMessage = "Product Cost should not be Empty")]
        public double ProductCost { get => productCost; set => productCost = value; }
    }
}