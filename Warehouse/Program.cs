namespace Warehouse 
{
    class Program
    {
        static void Main(string[] args)
        {
            Item milk = new Item("milk", 0.59, 20);

            milk.CurrentQuantity = milk.Sell(milk.CurrentQuantity, 5);
            milk.CurrentQuantity = milk.BuyStock(milk.CurrentQuantity, 20);



            Console.WriteLine(milk.CurrentQuantity);
        }

    }
}
