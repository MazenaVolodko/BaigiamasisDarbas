using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumFramework.Pages
{
    public class SingleProductPage
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
        }

        public static bool CheckIfOutOfStockBoxExists()
        {
            string locator = Locators.Text.outOfStockBox;
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

        public static void ScrollForElementToBeVisible()
        {
            Common.ScrollBy(0, 150);
        }
    }
}
