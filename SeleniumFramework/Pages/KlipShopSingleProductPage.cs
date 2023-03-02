﻿using OpenQA.Selenium;
using System;

namespace SeleniumFramework.Pages
{
    public class KlipShopSingleProductPage
    {
        public static void OpenPage(string pageSlug)
        {
            Driver.OpenUrl($"https://klipshop.lt/{pageSlug}");
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

        // Labai prastas būdas tikrinti ar elementas neegzistuoja
        // Ar yra priežastis dėl ko specifiškai taip tikrinate ar tiesiog kitaip neišėjo?
        // Blogai yra gaudyti WebDriverTimeoutException ir TimeoutException
        public static bool CheckIfOutOfStockBoxExists()
        {
            // Kadangi pats elementas egzistuoja tai galime tikrinti ar jis yra matomas
            return Common.CheckIfElementIsVisible(Locators.Boxes.outOfStockBox);

            //string locator = Locators.Boxes.outOfStockBox;
            //try
            //{
            //    Common.WaitForElementToBeVisible(locator);          
            //    return  true;
            //}
            //catch (Exception ex)
            //{
            //    if (ex is WebDriverTimeoutException || ex is NoSuchElementException || ex is TimeoutException)
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        throw ex;
            //    }
            //}
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
