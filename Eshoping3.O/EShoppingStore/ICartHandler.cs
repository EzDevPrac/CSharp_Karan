namespace EShoppingStore
{
    public interface ICartHandler
    {
        void AddToCart(IProductHandler _ProductHandler);
         int ShowCart();

        

    }
}