using OpenQA.Selenium;
using System;

namespace SeleniumFramework.Pages
{
    public class KlipShopSingleProductPage
    {
        public static void OpenPage(string pageSlug)
        {
            Driver.OpenUrl($"https://klipshop.lt/{pageSlug}");
        }

        public static void BypassAcceptCookiesDialog()
        {
            string locator = Locators.Buttons.acceptCookiesButton;
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
            Common.WaitUntilElementNotVisible(Locators.Boxes.cookieDialogUnderlay, 10);
        }

        public static void ScrollToOutOfStockBoxVisible()
        {
            Common.ScrollBy(0, 150);
        }

        public static void ScrollToTop()
        {
            Common.ScrollBy(0, 0);
        }

        public static bool CheckIfOutOfStockBoxExists()
        {
            string locator = Locators.Boxes.outOfStockBox;
            try
            {
                Common.WaitForElementToBeVisible(locator);          
                return  true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (TimeoutException)
            {
                return false;
            }
        }

        public static int GetCurrentItemsInCart()
        {
            string quantity = Common.GetElementText(Locators.Text.cartIconBubbleQuantityText).ToString();
            return Convert.ToInt32(quantity);
        }

        public static void ClickAddToCartButton()
        {
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
