namespace Warehouse
{
    public class Warehouse
    {
        public string WarehouseName {get; private set;}
        public List<Item> Items {get; set;}

        public Warehouse(string warehouseName, List<Item> items)
        {
            WarehouseName = warehouseName;
            List<Item>() = items;
        }

        public void DisplayInventory()
        {
            foreach (Item item in Items)
            {
                Console.WriteLine($"${item.ItemDescription}: ${item.CurrentQuantity}");
            }
        }

    }
}