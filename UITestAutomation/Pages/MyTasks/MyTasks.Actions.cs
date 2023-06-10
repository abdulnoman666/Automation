namespace UITestAutomation
{
    internal partial class MyTasks : Selenium_Methods
    {
        public void ClickMyTasks()
        {
            ClickTheWebElement(MyTasks_Dropdown);
            WaitForWebElementDisplayed(Actions_Field);
        }
    }
}
