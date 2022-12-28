namespace JsonDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            JsonDemo.StockInventory json = new JsonDemo.StockInventory();
            json.convert("C:\\Users\\91973\\source\\repos\\JSONInventory\\JsonDemo\\Stock.json");
        }
    }
}