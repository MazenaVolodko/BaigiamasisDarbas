using OpenQA.Selenium;
using System;

namespace SeleniumFramework.Pages
{
    public static class KlipShopCartPage
    {
        public static void OpenPage(string pageSlug)
        {
            Driver.OpenUrl($"https://klipshop.lt/{pageSlug}");
            KlipShopCommon.BypassAcceptCookiesDialog();
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
            Common.WaitForElementToBeVisible(Locators.Buttons.shareCartCopyButton);
        }

        public static bool CheckIfCopyInputIsVisible()
        {
            return Common.GetElementText(Locators.Inputs.shareUrlInput) != null;
        }

    }
}
