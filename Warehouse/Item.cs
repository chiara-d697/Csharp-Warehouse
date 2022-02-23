namespace Warehouse 
{
    public class Item
    {
        public string ItemDescription { get; set; }
        public double ItemPrice { get; private set; }
        public int CurrentQuantity { get; set; }

        public Item(string itemDescription, double itemPrice, int currentQuantity)
        {
            ItemDescription = itemDescription;
            ItemPrice = itemPrice;
            CurrentQuantity = currentQuantity;
        }

        public void Sell(int deductAmount)
        {
            if (CurrentQuantity <= 0)
            {
                throw new Exception("Item out of stock");
            }

            else
            {
                CurrentQuantity = CurrentQuantity - deductAmount;
            }
        }

        public void BuyStock(int purchaseAmount)
        {
            CurrentQuantity = CurrentQuantity + purchaseAmount;
        }
    }
}