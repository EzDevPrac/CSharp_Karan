namespace EShoppingStore
{
    public interface IProductHandler
    {
      //ProductHandler AddProducts(int ProductId,string ProductName,double ProductCost);
      string GetProductName(int id);
      double GetProductCost(int id);
      void AddProduct(int itemId,string ItemName,double ItemCost);
      void DisplayProduct();
      void ShowExisting();    
    }
}