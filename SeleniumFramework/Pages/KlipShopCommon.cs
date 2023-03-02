namespace SeleniumFramework.Pages
{
    public class KlipShopCommon
    {
        public static void BypassAcceptCookiesDialog()
        {
            string locator = Locators.Buttons.acceptCookiesButton;
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
            Common.WaitForElementToBeNotVisisble(Locators.Boxes.cookieDialogUnderlay);
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
    }
}
