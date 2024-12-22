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
        private readonly Dictionary<string, (int quantity, int price)> specialPrices = new Dictionary<string, (int, int)>
    {
        { "A", (3, 130) },
        { "B", (2, 45) }
    };
        private readonly Dictionary<string, int> itemCounts = new Dictionary<string, int>();

        public void Scan(string item)
        {
            if (prices.ContainsKey(item))
            {
                if (!itemCounts.ContainsKey(item))
                {
                    itemCounts[item] = 0;
                }
                itemCounts[item]++;
                ApplyPricing(item);
            }
        }

        private void ApplyPricing(string item)
        {
            if (specialPrices.ContainsKey(item) && itemCounts[item] >= specialPrices[item].quantity)
            {
                totalPrice = specialPrices[item].price;
                itemCounts[item] -= specialPrices[item].quantity;
            }
            else
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