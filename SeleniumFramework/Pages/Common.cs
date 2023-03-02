using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElementsList(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static IWebElement[] GetAllElements(string locator)
        {
            List<IWebElement> elementList = GetElementsList(locator).ToList();
            return elementList.ToArray();
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void SendKeys(string locator, string message)
        {
            GetElement(locator).SendKeys(message);
        }

        internal static void ScrollBy(int xPixels, int yPixels)
        {
            ExecuteJavaScript($"window.scrollBy({xPixels}, {yPixels})");
        }

        private static void ExecuteJavaScript(string script)
        {
            Driver.GetDriver().ExecuteJavaScript(script);
        }

        private static bool IsElementVisible(string locator)
        {
            try
            {
                return GetElement(locator).Displayed;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            //wait.PollingInterval = TimeSpan.FromSeconds(10);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void WaitUntilElementNotVisible(string locator, int timeoutInSeconds)
        {
            new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(timeoutInSeconds))
                            .Until(drv => !IsElementVisible(locator));
        }

        internal static bool CheckIfElementIsVisible(string locator)
        {
            return GetElement(locator).Displayed;
        }
    }
}
