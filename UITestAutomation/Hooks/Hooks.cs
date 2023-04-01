namespace UITestAutomation
{
    [Binding]
    internal class Hooks
    {
        [BeforeFeature]
        public static void SetupDriver()
        {
            Selenium_Methods.InitializeDriver();
            Selenium_Methods.GoToURL("https://disputedev.azurewebsites.net/#/login");
        }

        [AfterFeature]
        public static void CleanupDriver()
        {
            Selenium_Methods.CloseDriver();
        }
    }
}
