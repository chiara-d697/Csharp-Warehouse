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

        public int Sell(int currentQuantity, int deductAmount)
        {
            if (currentQuantity <= 0)
            {
                throw new Exception("Item out of stock");
            }

            else
            {
                return currentQuantity - deductAmount;
            }
        }

        public int BuyStock(int currentQuantity, int purchaseAmount)
        {
            return currentQuantity + purchaseAmount;
        }


    }
}