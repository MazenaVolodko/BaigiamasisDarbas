using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumTests.BaseTests;

namespace SeleniumTests.KlipShop
{
    internal class KlipShopCartPageTests : BaseTest
    {
        [TestCase("j-beverly-hills-crazy-straight-straightening-styling-lotion-tiesinantis-plauku-losjonas")]
        public void CanCopyShareCartLink(string pageSlug)
        {
            KlipShopCartPage.OpenPage(pageSlug);
            
            bool outOfStockBoxVisible = KlipShopCartPage.CheckIfOutOfStockBoxExists();
            Assert.IsFalse(outOfStockBoxVisible, $"Could not open cart page because product could not be added to cart");

            KlipShopCartPage.ClickAddToCartButton();
            KlipShopCartPage.ClickContinueToCartButton();
            KlipShopCartPage.ClickShareCartButton();
            
            
            bool actualResult = KlipShopCartPage.CheckIfCopyInputIsVisible();
            Assert.IsTrue(actualResult);
        }
    }
}
