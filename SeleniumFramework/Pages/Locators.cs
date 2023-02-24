

namespace SeleniumFramework.Pages
{
    internal class Locators
    {
        internal class Text
        {
            internal static string discountedPrice = "//*[@id='old_price_display']/span";
            internal static string outOfStockBox = "//*[@id='out-of-stock-line']";
            internal static string outOfStockBoxText = "//*[@id='out-of-stock-line']//span[contains(@class, 'disklaimeris-inner')]";
        }
        internal class Buttons
        {
            internal static string acceptCookiesButton = "//*[@id='CybotCookiebotDialogBodyButtonAccept']";
        }
    }
}
