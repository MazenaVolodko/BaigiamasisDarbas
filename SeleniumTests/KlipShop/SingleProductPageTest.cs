
using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumTests.BaseTests;

namespace SeleniumTests.KlipShop
{
    internal class SingleProductPageTest : BaseTest
    {

        [TestCase("solidu-balance-riebiu-plauku-sampunas-su-rozmarinais-ir-metomis")]
        [TestCase("neuma-neumoisture-restore-drekinantis-plauku-kondicionierius")]
        public void ProductIsInStock(string pageSlug)
        {
            SingleProductPage.OpenPage(pageSlug);
            SingleProductPage.BypassAcceptCookiesDialog();
            SingleProductPage.ScrollToOutOfStockBoxVisible();
            bool outOfStockBoxVisible = SingleProductPage.CheckIfOutOfStockBoxExists();
            Assert.IsFalse(outOfStockBoxVisible, $"Expected result: \"Out Of Stock Box is Visible: False\", actual result: \"Out Of Stock Box is Visible: {outOfStockBoxVisible}\"");
        }

        [TestCase("solidu-balance-riebiu-plauku-sampunas-su-rozmarinais-ir-metomis")]
        [TestCase("neuma-neumoisture-restore-drekinantis-plauku-kondicionierius")]
        public void ProductAddToCart(string pageSlug)
        {
            SingleProductPage.OpenPage(pageSlug);
            SingleProductPage.BypassAcceptCookiesDialog();
            int itemsInCartBefore = SingleProductPage.GetCurrentItemsInCart();
            SingleProductPage.ScrollToOutOfStockBoxVisible();
            bool outOfStockBoxVisible = SingleProductPage.CheckIfOutOfStockBoxExists();
            Assert.IsFalse(outOfStockBoxVisible, $"Failed To Add Product To Cart. Product is Out Of Stock.");
            SingleProductPage.ClickAddToCartButton();
            SingleProductPage.CloseContinueToCartDialog();
            SingleProductPage.ScrollToTop();
            int itemsInCartAfter = SingleProductPage.GetCurrentItemsInCart();
            Assert.Greater(itemsInCartAfter, itemsInCartBefore, $"{itemsInCartAfter} {itemsInCartBefore}");

        }

    }
}
