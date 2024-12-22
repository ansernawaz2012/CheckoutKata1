namespace CheckoutKata1
{
    public class Checkout
    {
        private int totalPrice = 0;

        public void Scan(string item)
        {
            if (item == "A")
            {
                totalPrice += 50;
            }
        }

        public int GetTotalPrice()
        {
            return totalPrice;
        }
    }

}