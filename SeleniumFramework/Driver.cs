using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumFramework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void SetupDriver()
        {
            ChromeOptions options = new ChromeOptions();
            driver.Value = new ChromeDriver(options);
        }

        public static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public static void OpenUrl(string url)
        {
            driver.Value.Url = url;
        }

        public static void CloseDriver()
        {
            driver.Value.Quit();
        }
    }
}
