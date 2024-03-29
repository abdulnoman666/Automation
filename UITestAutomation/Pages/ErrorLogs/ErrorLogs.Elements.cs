﻿using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class ErrorLogs
    {
        By ErrorLogsOption = By.LinkText("Error Logs");
 By SearchandsetdateRange_Button = By.CssSelector("button[title='Search and set date range']");
        By CreatedOn_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table//th[.='Created On']");
        By ErrorMessage_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table//th[.='Error Message']");
        By URL_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table//th[.='URL']");
        By StartDate_Button = By.CssSelector("md-datepicker[name='startDate'] > .md-datepicker-input-container > .md-datepicker-input");
        By EndDate_Button = By.CssSelector("md-datepicker[name='endDate'] > .md-datepicker-input-container > .md-datepicker-input");
        By Close_Button = By.XPath("/html//div[@id='dateSearch']//div[@class='modal-footer']/button[@type='button']");
    }
}