using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
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

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.PollingInterval = TimeSpan.FromSeconds(10);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }
    }
}
