using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class UserPools
    {
        int count;
        public void AssertUIControlsonUserPoolsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add":
                        FluentWaitForWebElement(AddPool_Button);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(Refresh_Button);
                        break;
                    case "Reference Search":
                        FluentWaitForWebElement(ReferenceSearch_TextBox);
                        break;
                    case "Edit":
                        FluentWaitForWebElement(EditPool_Button);
                        break;
                    case "Delete":
                        FluentWaitForWebElement(DeletePool_Button);
                        //after
                        count = GetElements(DeletePool_Button).Count();
                        break;
                    case "Action":
                        FluentWaitForWebElement(Action_Field);
                        break;
                    case "ID":
                        FluentWaitForWebElement(ID_Field);
                        break;
                    case "Group Name":
                        FluentWaitForWebElement(GroupName_Field);
                        break;
                    case "Reference":
                        FluentWaitForWebElement(Rerefernce_Field);
                        break;
                    case "Users":
                        FluentWaitForWebElement(User_Field);
                        break;
                    case "Show":
                        FluentWaitForWebElement(show_Button);
                        break;
                }
            }
        }

        public void AssertFieldsOnAddPoolDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Pool Name":
                        FluentWaitForWebElement(PoolName_Field);
                        //    EnterValueinWebElement(PoolName_Field, "Susan");
                        break;
                    case "Pool Reference":
                        FluentWaitForWebElement(PoolReference_Field);
                        //  EnterValueinWebElement(PoolReference_Field, "ABC");
                        break;
                    case "Pool Users Email List":
                        FluentWaitForWebElement(PoolUserEmaillist_Field);
                        // ClickOnWebElement(PoolUserEmaillist_Field);
                        // ElementToBeSelectedFromDropdown(select_otpion, "abdul@finboa.com");
                        // ClickOnWebElement(PoolUserEmaillist_Field);
                        break;
                    case "Close":
                        FluentWaitForWebElement(Close_Button);
                        break;
                    case "Save":
                        FluentWaitForWebElement(Save_Button);
                        // ClickOnWebElement(Save_Button);
                        break;
                }
            }
        }

        public void AdddatatoFieldsonAddPoolDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Pool Name":
                        EnterValueinWebElement(PoolName_Field, item[1]);
                        break;
                    case "Pool Reference":
                        EnterValueinWebElement(PoolReference_Field, item[1]);
                        break;
                    case "Pool Users Email List":
                        ClickOnWebElement(PoolUserEmaillist_Field);
                        ElementToBeSelectedFromDropdown(select_otpion, item[1]);
                        ClickOnWebElement(PoolUserEmaillist_Field);
                        break;
                }
            }
        }
        public void validateActionfields()
        {
            int afteradding = GetElements(DeletePool_Button).Count();
            for (int i = 1; i <= afteradding; i++)
            {
                if (i>count)
                {
                    var value = driver.FindElement(By.XPath("(//button[@ng-click=\"deletePool($event, p)\"])[" + i + "]"));
                    Thread.Sleep(5000);
                    value.Click();
                    WaitForWebElementDisplayed(Yes_Button);
                    Thread.Sleep(5000);
                    ClickOnWebElement(Yes_Button);
                    Thread.Sleep(5000);
                }
            }
        }
        //public void validateActionfields()
        //{
        //    FluentWaitForWebElement(DeletePool_Button);
        //    var elements = GetElements(DeletePool_Button);
        //    var total_listelements = elements.Count();
        //    var lastelement = driver.FindElement(lastdelete_Element);
        //    for (int i = total_listelements; i >=1; i--)
        //    {
        //       // By.XPath("(//button[@title=\"Delete Pool\"])[7]");
        //        var value = driver.FindElement(By.XPath("(//button[@ng-click=\"deletePool($event, p)\"])[" + i + "]"));
        //        if (i > 7)
        //        {
        //            Thread.Sleep(5000);
        //            value.Click();
        //            WaitForWebElementDisplayed(Yes_Button);
        //            Thread.Sleep(5000);
        //            ClickOnWebElement(Yes_Button);
        //            Thread.Sleep(5000);
        //        }
        //    }
        //}
    }
}
