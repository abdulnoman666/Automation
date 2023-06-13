﻿
namespace UITestAutomation
{
    internal partial class UserPools :Selenium_Methods
    {
        public void ClickUserPools()
        {
            ClickTheWebElement(UserPools_Dropdown);
            WaitForWebElementDisplayed(EditPool_Button);
        }

        public void ClickAddPoolButton()
        {
            ClickOnWebElement(AddPool_Button);
            WaitForWebElementDisplayed(PoolName_Field);
        }

        public void ClickSaveButton()
        {
            ClickOnWebElement(Save_Button);
            WaitForWebElementDisplayed(AddPool_Button);
            Thread.Sleep(10000);
        }
    }
}
