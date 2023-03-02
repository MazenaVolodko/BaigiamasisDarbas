using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumTests.BaseTests;

namespace SeleniumTests.KlipShop
{
    internal class KlipShopSingleProductPageTests : BaseTest
    {

        [TestCase("neuma-neumoisture-restore-drekinantis-plauku-kondicionierius")]
        public void ProductIsInStock(string pageSlug)
        {
            KlipShopSingleProductPage.OpenPage(pageSlug);
            KlipShopCommon.BypassAcceptCookiesDialog();
            bool outOfStockBoxVisible = KlipShopSingleProductPage.CheckIfOutOfStockBoxExists();
            Assert.IsFalse(outOfStockBoxVisible, $"Expected result: \"Out Of Stock Box is Visible: False\", actual result: \"Out Of Stock Box is Visible: {outOfStockBoxVisible}\"");
        }

        [TestCase("neuma-neumoisture-restore-drekinantis-plauku-kondicionierius")]
        public void ProductAddToCart(string pageSlug)
        {
            KlipShopSingleProductPage.OpenPage(pageSlug);
            KlipShopCommon.BypassAcceptCookiesDialog();
            int itemsInCartBefore = KlipShopSingleProductPage.GetCurrentItemsInCart();
            bool outOfStockBoxVisible = KlipShopSingleProductPage.CheckIfOutOfStockBoxExists();
            Assert.IsFalse(outOfStockBoxVisible, $"Failed To Add Product To Cart. Product is Out Of Stock.");
            KlipShopSingleProductPage.ClickAddToCartButton();
            KlipShopSingleProductPage.CloseContinueToCartDialog();
            KlipShopSingleProductPage.ScrollToTop();
            int itemsInCartAfter = KlipShopSingleProductPage.GetCurrentItemsInCart();
            Assert.Greater(itemsInCartAfter, itemsInCartBefore, $"{itemsInCartAfter} {itemsInCartBefore}");
        }

    }
}
