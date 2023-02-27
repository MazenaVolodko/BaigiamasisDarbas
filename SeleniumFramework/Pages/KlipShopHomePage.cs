using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class KlipShopHomePage
    {
        public static void OpenPage()
        {
            Driver.OpenUrl($"https://klipshop.lt/");
        }

        public static void BypassAcceptCookiesDialog()
        {
            string locator = Locators.Buttons.acceptCookiesButton;
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
            Common.WaitUntilElementNotVisible(Locators.Boxes.cookieDialogUnderlay, 10);
        }

        public static void EnterSearchValue(string searchPhrase)
        {
            Common.SendKeys(Locators.Inputs.searchInput, searchPhrase);
        }

        public static bool CheckIfProductSuggestionsBoxAppeared()
        {
            try
            {
                Common.WaitForElementToBeVisible(Locators.Boxes.searchProductListBox);
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

        public static int GetHowManyProductsWereSuggested()
        {
            return Common.GetAllElements(Locators.Boxes.searchProductListBox + "//a").Length;
        }

        public static void PressEnterKey()
        {
            Common.ClickElement(Locators.Buttons.searchButton);
        }

        public static bool CheckIfSearchResultsLoaded()
        {
            try
            {
                Common.WaitForElementToBeVisible(Locators.Boxes.productListElements);
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

        public static int GetAmountOfLoadedElements()
        {
            int amount = Common.GetAllElements(Locators.Boxes.productListElements).Length;
            if (amount > 0)
            {
                return amount;
            }
            return 0;
        }
    }
}
