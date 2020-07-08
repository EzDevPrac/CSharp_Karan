using System;
using System.ComponentModel.Design;
using System.Collections.Generic;
namespace EShoppingWebApi.Models
{
    public class Cart
    {
        private int productId;
        private string productName;
        private double productCost;
        //private int productQuantity;
        private Guid customerCartId;
        
        
        public int ProductId { get => productId; set => productId = value; }

        
        public string ProductName { get => productName; set => productName = value; }

        public double ProductCost { get => productCost; set => productCost = value; }
        public Guid CustomerCartId { get => customerCartId; set => customerCartId = value; }
    }
}