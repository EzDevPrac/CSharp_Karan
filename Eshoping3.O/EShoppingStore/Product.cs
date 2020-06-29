namespace EShoppingStore
{
    public class Product
    {
        private int itemId;
        private string ItemName;
        private double ItemCost;
        
      
        public Product(int itemId,string ItemName,double ItemCost){

            this.itemId = itemId;
            this.ItemName = ItemName;
            this.ItemCost = ItemCost;
        }

        public int _ItemId { get => itemId; set => itemId = value; }
        public string _ItemName { get => ItemName; set => ItemName = value; }
        public double _ItemCost { get => ItemCost; set => ItemCost = value; }
    }
}