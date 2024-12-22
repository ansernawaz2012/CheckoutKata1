namespace CheckoutKata1.Tests
{
    public class CheckoutTests
    {
        [Fact]
        public void Scan_SingleItem_ReturnsCorrectPrice()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            Assert.Equal(50, checkout.GetTotalPrice());
        }
    }

}