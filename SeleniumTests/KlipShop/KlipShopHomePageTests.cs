using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumTests.BaseTests;

namespace SeleniumTests.KlipShop
{
    internal class KlipShopHomePageTests : BaseTest
    {
        [TestCase("solidu")]
        [TestCase("solid----u")]
        public void SearchAutocompleteReturnsSuggestedProducts(string searchPhraseValue)
        {
            KlipShopHomePage.OpenPage();
            KlipShopHomePage.BypassAcceptCookiesDialog();
            KlipShopHomePage.EnterSearchValue(searchPhraseValue);
            bool autocompleteSuggestionBoxAppeared = KlipShopHomePage.CheckIfProductSuggestionsBoxAppeared();
            Assert.IsTrue(autocompleteSuggestionBoxAppeared, "Product suggestions box did not appear");
            int suggestedProducts = KlipShopHomePage.GetHowManyProductsWereSuggested();
            Assert.Greater(suggestedProducts, 0);
        }

        [TestCase("solid----u")]
        [TestCase("solidu")]
        public void PerformingSearchReturnsResults(string searchPhraseValue)
        {
            KlipShopHomePage.OpenPage();
            KlipShopHomePage.BypassAcceptCookiesDialog();
            KlipShopHomePage.EnterSearchValue(searchPhraseValue);
            KlipShopHomePage.PressEnterKey();
            bool searchResultsLoaded = KlipShopHomePage.CheckIfSearchResultsLoaded();
            Assert.IsTrue(searchResultsLoaded, "Search did not return any results");
            int foundProductsAmount = KlipShopHomePage.GetAmountOfLoadedElements();
            Assert.Greater(foundProductsAmount, 0, "Search did not return any results");
        }
    }
}
