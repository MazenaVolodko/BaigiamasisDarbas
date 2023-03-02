using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumTests.BaseTests;

namespace SeleniumTests.KlipShop
{
    internal class KlipShopHomePageTests : BaseTest
    {
        [TestCase("solidu")]
        public void SearchAutocompleteReturnsSuggestedProducts(string searchPhraseValue)
        {
            KlipShopHomePage.OpenPage();
            
            KlipShopHomePage.EnterSearchValue(searchPhraseValue);
            bool autocompleteSuggestionBoxAppeared = KlipShopHomePage.CheckIfProductSuggestionsBoxAppeared();
            int suggestedProducts = KlipShopHomePage.GetHowManyProductsWereSuggested();

            Assert.IsTrue(autocompleteSuggestionBoxAppeared, "Product suggestions box did not appear");
            Assert.Greater(suggestedProducts, 0);
        }

        [TestCase("solidu")]
        public void PerformingSearchReturnsResults(string searchPhraseValue)
        {
            KlipShopHomePage.OpenPage();
            
            KlipShopHomePage.EnterSearchValue(searchPhraseValue);
            KlipShopHomePage.PressEnterKey();
            bool searchResultsLoaded = KlipShopHomePage.CheckIfSearchResultsLoaded();
            int foundProductsAmount = KlipShopHomePage.GetAmountOfLoadedElements();

            Assert.IsTrue(searchResultsLoaded, "Search did not return any results");
            Assert.Greater(foundProductsAmount, 0, "Search did not return any results");
        }
    }
}
