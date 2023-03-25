using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject_prac.Pages
{
    public class Dashboard : Selenium_Methods.Selenium_Methods
    {
        By SupportElement = By.CssSelector("a[href=\"#/support\"]");
        By ProfileIconElement = By.CssSelector("a.dropdown-toggle i.fa.fa-user");
        By TransactionProcessesElement = By.XPath("//a[contains(@href,\"processsubmissionsetup\")]");
        By Dashboard_Container = By.XPath("//div[@class='container']");

        public void DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog()
        {
            WaitForWebElementDisplayed(Dashboard_Container);
        }

        public void ClickProfileIconOnDashboardPage()
        {
            WaitForWebElementDisplayed(ProfileIconElement);
            ClickOnWebElement(ProfileIconElement);
        }
        public void ClickTransactionProcessesFieldOnProfileIconDropDown()
        {
            WaitForWebElementDisplayed(TransactionProcessesElement);
            ClickOnWebElement(TransactionProcessesElement);
        }
    }
}
