using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V108.Network;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpecFlowProject_prac.Pages
{
    public class TransactionProcess : Selenium_Methods.Selenium_Methods
    {
        By AddTransactionProcessesElement = By.CssSelector("button[title='Add Transaction Process']");
        By NameElement = By.CssSelector("[ng-model='newSetup\\.description']");
        By TypeElement = By.XPath("/html//div[@id='addSubmissionSetup']//form[@name='addProcessSubmissionForm']/div[2]/select");
        By GLReferenceElement = By.XPath("/html//div[@id='addSubmissionSetup']//form[@name='addProcessSubmissionForm']//select[@name='source']");
       
         By WorkflowsElement = By.XPath("/html//div[@id='addSubmissionSetup']//form[@name='addProcessSubmissionForm']//multiselect//button[@class='btn']");
        // By WorkflowDropdown = By.XPath("//div[@id='addSubmissionSetup']//form[@name='addProcessSubmissionForm']//multiselect//ul[@class='dropdown-menu']/li/a[@class='ng-binding']");
        // 
       // By WorkflowsElement = By.CssSelector("div.dropdown.open");
        By WorkflowDropdown = By.XPath("(//li[@ng-repeat='i in items | filter:searchText'])");


         By SaveButtonElement = By.CssSelector(".btn.btn-info > span:nth-of-type(1)");

        public void ClickAddTransactionProcessesElementOnTransactionProcessPage()
        {
            WaitForWebElementDisplayed(AddTransactionProcessesElement);
            ClickOnWebElement(AddTransactionProcessesElement);
        }


        public void PerformingActionsOnAddProcessTransactionSetupDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Name":
                        WaitForWebElementDisplayed(NameElement);
                        EnterValueinWebElement(NameElement, item[1]);
                        break;
                    case "Type":
                        WaitForWebElementDisplayed(TypeElement);
                        ElementToBeSelectedFromDropdown(TypeElement, item[1]);
                        break;
                    case "GL Reference":
                        WaitForWebElementDisplayed(GLReferenceElement);
                        ClickOnWebElement(GLReferenceElement);
                        ElementToBeSelectedFromDropdown(GLReferenceElement, item[1]);         
                        break;
                    case "Workflows":
                       WaitForWebElementDisplayed(WorkflowsElement);
                        ClickOnWebElement(WorkflowsElement);
                        GetValidation(WorkflowDropdown, item[1]);
                      //  ClickOnWebElement(WorkflowsElement);
                        break;
                }

            }
           
        }
        public void UserClicksSaveButtonOnAddProcessTransactionSetupDialog()
        {
            WaitForWebElementDisplayed(SaveButtonElement);
            ClickOnWebElement(SaveButtonElement);
        }
    }
}
