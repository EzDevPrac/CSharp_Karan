using System.Text.RegularExpressions;
using System;
namespace EShoppingWebApi.Validation.ProductValidation
{
    public class ProductValidation : IProductValidation
    {
        string MatchValue;
        public int ValidateProductName(string productName){
         
         MatchValue = @"^[a-zA-Z0-9\s]+$";

         if(productName == null || productName == " ")
           return -1;
         if(Regex.IsMatch(productName,MatchValue))
           return 1 ;
        return 0 ;    
        }
        public  int ValidateProductCost(double productCost){
          MatchValue = @"^[1-9]{1}[0-9]{4}$";
          string cost = Convert.ToString(productCost);

          if(productCost == 0)
            return -1;
          if(Regex.IsMatch(cost,MatchValue))
            return 1;
        return 0;
        }

        public int ValidateProductId(int productId){
          MatchValue = @"^[1-9]{1}[0-9]{2}$"; 
          if(productId == 0)
            return -1;
          if(Regex.IsMatch(Convert.ToString(productId),MatchValue))
            return 1;
        return 0;
        }
        
    }
}