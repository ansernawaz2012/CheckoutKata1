namespace CheckoutKata1
{
    public class Checkout
    {
        private int totalPrice = 0;
        private readonly Dictionary<string, int> prices = new Dictionary<string, int>
    {
        { "A", 50 },
        { "B", 30 },
        { "C", 20 },
        { "D", 15 }
    };

        public void Scan(string item)
        {
            if (prices.ContainsKey(item))
            {
                totalPrice += prices[item];
            }
        }

        public int GetTotalPrice()
        {
            return totalPrice;
        }
    }


}