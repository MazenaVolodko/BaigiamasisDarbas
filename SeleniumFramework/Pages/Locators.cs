

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
            internal static string searchButton = "//*[@id='searchbox']//button";
        }
        internal class Boxes
        {
            internal static string outOfStockBox = "//*[@id='out-of-stock-line']";
            internal static string klipShopPickBox = "//*[(@class = 'klipshop-pick')]";
            internal static string cookieDialogUnderlay = "//*[@id='CybotCookiebotDialogBodyUnderlay']";
            internal static string searchProductListBox = "//*[@id='search-popup-conteiner']//*[contains(@class, 'search-product-list')]";
            internal static string productListBox = "//*[@id='center_column']/*[contains(@class, 'productBlock')]";
            internal static string productListElements = "//*[@id='center_column']/*[contains(@class, 'productBlock')]//ul/li";
        }
        internal class Inputs
        {
            internal static string searchInput = "//*[@id='search_query_block']";
        }
    }
}
