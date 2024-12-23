namespace CheckoutKata1.Tests
{
    public class CheckoutTests
    {
        [Fact]
        public void Scan_SingleItem_ReturnsCorrectPrice()
        {
            ICheckout checkout = new Checkout();
            checkout.Scan("A");
            Assert.Equal(50, checkout.GetTotalPrice());
        }

        [Fact]
        public void Scan_MultipleItems_ReturnsCorrectTotalPrice()
        {
            ICheckout checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("B");
            Assert.Equal(80, checkout.GetTotalPrice());
        }

        [Fact]
        public void Scan_SpecialPrice_ReturnsCorrectTotalPriceForItemA()
        {
            ICheckout checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            Assert.Equal(130, checkout.GetTotalPrice());
        }

        [Fact]
        public void Scan_SpecialPrice_ReturnsCorrectTotalPriceForItemB()
        {
            ICheckout checkout = new Checkout();
            checkout.Scan("B");
            checkout.Scan("B");
            Assert.Equal(45, checkout.GetTotalPrice());
        }

        
    }

}