using OpenQA.Selenium;
using System;

namespace SeleniumFramework.Pages
{
    public static class KlipShopCartPage
    {
        public static void OpenPage(string pageSlug)
        {
            Driver.OpenUrl($"https://klipshop.lt/{pageSlug}");
        }

        public static bool CheckIfOutOfStockBoxExists()
        {
            string locator = Locators.Boxes.outOfStockBox;
            try
            {
                Common.WaitForElementToBeVisible(locator);
                return true;
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

        public static void ClickAddToCartButton()
        {
            Common.ClickElement(Locators.Buttons.addToCartButton);
        }

        public static void ClickContinueToCartButton()
        {
            string locator = Locators.Buttons.continueToCartButton;
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void ClickShareCartButton()
        {
            Common.WaitForElementToBeVisible(Locators.Buttons.shareCartButton);
            Common.ClickElement(Locators.Buttons.shareCartButton);
        }

        public static void WaitForCopyButtonToAppear()
        {
            Common.WaitForElementToBeVisible(Locators.Buttons.shareCartCopyButton);
        }

        public static bool CheckIfCopyInputIsVisible()
        {
            return Common.GetElementText(Locators.Inputs.shareUrlInput) != null;
        }

    }
}
