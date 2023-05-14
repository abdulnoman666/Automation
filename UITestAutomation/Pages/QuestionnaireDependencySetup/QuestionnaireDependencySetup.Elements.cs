using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation
{
    internal partial class QuestionnaireDependencySetup 
    {
        //UI Controls on QuestionareDPage
        By QuestionnaireDependencySetupOption = By.LinkText("Questionnaire Dependency Setup");
        By AddFormDependancyList = By.CssSelector("button[title='Add Form Dependency List']");
        By DeleteList = By.XPath("//button[@class='btn btn-danger glyphicon glyphicon-trash']");
        By EditFormDependencySetup = By.CssSelector("tr:nth-of-type(1)  button[title='Edit Form Dependency Setup']");
        By CopyForm = By.ClassName("btn btn-default glyphicon glyphicon-copy");
        By RefreshIcon = By.CssSelector("button[title='Refresh']");
        By ConditionSearchText = By.CssSelector("[ng-model='formsearch\\.conditions']");

        //Add Brand Page (Field)
        By WorkFlowName = By.CssSelector("[ng-model='newFormDependencyList\\.workFlowName']");
        By SaveButton = By.ClassName("btn btn-info");
        By CloseButton = By.ClassName("btn btn-default");
    }

}
