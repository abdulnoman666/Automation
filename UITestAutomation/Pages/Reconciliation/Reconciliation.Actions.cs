
namespace UITestAutomation.Pages.Reconciliation
{
    internal partial class Reconciliation
    {
        public void ClickReconciliation()
        {
            ClickTheWebElement(Reconciliation_Dropdown);
            WaitForWebElementDisplayed(Reset_Button);
        }
    }
}
