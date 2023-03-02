using OpenQA.Selenium;
using System;

namespace SeleniumFramework.Pages
{
    public class KlipShopSingleProductPage
    {
        public static void OpenPage(string pageSlug)
        {
            Driver.OpenUrl($"https://klipshop.lt/{pageSlug}");
            KlipShopCommon.BypassAcceptCookiesDialog();
        }

        public static void ScrollToOutOfStockBoxVisible()
        {
            Common.ScrollBy(0, 150);
        }

        public static void ScrollToTop()
        {
            // Šitas veiksmas nieko nedaro :)
            // Scrollinam per nei kiek pikselių abiem kryptim
            Common.ScrollBy(0, 0);
        }

        public static int GetCurrentItemsInCart()
        {
            string quantity = Common.GetElementText(Locators.Text.cartIconBubbleQuantityText).ToString();
            return Convert.ToInt32(quantity);
        }

        public static void ClickAddToCartButton()
        {
            Common.WaitForElementToBeClickable(Locators.Buttons.addToCartButton);
            Common.ClickElement(Locators.Buttons.addToCartButton);
        }

        public static void CloseContinueToCartDialog()
        {
            string locator = Locators.Buttons.closeContinueShoppingDialogButton;
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }
    }
}
