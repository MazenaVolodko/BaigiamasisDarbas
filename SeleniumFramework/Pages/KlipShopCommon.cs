﻿namespace SeleniumFramework.Pages
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
    }
}
