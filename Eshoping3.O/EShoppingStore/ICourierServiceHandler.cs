namespace EShoppingStore
{
    public interface ICourierServiceHandler
    {
         void Packaging(string Type);
         void Deliver(string Address);
         void returnPickup(double Cost);
    }
}