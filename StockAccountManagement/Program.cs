namespace StockAccountManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            StockAccountManagement.StockInventory json = new StockAccountManagement.StockInventory();
            json.convert("C:\\Users\\91973\\source\\repos\\JSONInventory\\StockAccountManagement\\Stcok.json");
        }
    }
}