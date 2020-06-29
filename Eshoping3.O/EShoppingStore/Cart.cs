namespace EShoppingStore
{
    public class Cart
    {
        private int itemId;
        private string ItemName;
        private double ItemCost;
        
        public Cart(){}
        public Cart(int itemId, string itemName, double itemCost)
        {
            this.itemId = itemId;
            ItemName = itemName;
            ItemCost = itemCost;
            
        }

        public int _ItemId { get => itemId; set => itemId = value; }
        public string _ItemName { get => ItemName; set => ItemName = value; }
        public double _ItemCost { get => ItemCost; set => ItemCost = value; }
    }
}