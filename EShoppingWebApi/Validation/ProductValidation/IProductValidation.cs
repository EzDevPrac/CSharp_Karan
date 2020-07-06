namespace EShoppingWebApi.Validation.ProductValidation
{
    public interface IProductValidation
    {
         int ValidateProductName(string productName);
         int ValidateProductCost(double productCost);

         int ValidateProductId(int productId);
    }
}