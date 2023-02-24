
using System;
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
            SingleProductPage.ScrollForElementToBeVisible();
            bool outOfStockBoxVisible = SingleProductPage.CheckIfOutOfStockBoxExists();
            Assert.IsFalse(outOfStockBoxVisible, $"Expected result: \"Out Of Stock Box is Visible: False\", actual result: \"Out Of Stock Box is Visible: {outOfStockBoxVisible}\"");
        }

    }
}
