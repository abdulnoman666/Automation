using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Pages
{
  public class FeeReimbursementSettings : Selenium_Methods.Selenium_Methods
    {
        By AddFeeReimbursementSetting_Button = By.CssSelector("button[title='Add Fee Reimbursement Setting']");
        By Name_Textbox = By.CssSelector("input[name='reference']");
        By Name_Textarea = By.CssSelector("textarea[name='alertName']");
        By Type_Dropdown = By.XPath("//select[@ng-model='newSetup.processType']");
        By Workflows_Dropdown = By.XPath("//button[@ng-click='toggleSelect()']");



