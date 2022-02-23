namespace Warehouse 
{
    class Program
    {
        static void Main(string[] args)
        {
            Item milk = new Item("Milk", 0.59, 20);

            milk.Sell(5);
            milk.BuyStock(20);
            milk.Sell(2);

            Console.WriteLine(milk.CurrentQuantity);

            
            

            Warehouse north = new Warehouse("North", );

            north.DisplayInventory();
        }

    }
}
