

namespace SeleniumFramework.Pages
{
    internal class Locators
    {
        internal class Text
        {
            internal static string discountedPrice = "//*[@id='old_price_display']/span";
            internal static string cartIconBubbleQuantityText = "//*[@id='mini-cart']//*[contains(@class, 'ajax_cart_quantity')]";
        }
        internal class Buttons
        {
            internal static string acceptCookiesButton = "//*[@id='CybotCookiebotDialogBodyButtonAccept']";
            internal static string addToCartButton = "//*[@id='add_to_cart']/button";
            internal static string closeContinueShoppingDialogButton = "//*[@id='layer_cart']//button[contains(@class, 'mfp-close')]";
        }
        internal class Boxes
        {
            internal static string outOfStockBox = "//*[@id='out-of-stock-line']";
        }
    }
}
