using FluentAssertions;
using NUnit.Framework;
using SpecFlowProject_prac.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject_prac.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        Login login = new Login();
        LoginVerification loginVerification = new LoginVerification();
        Dashboard dashboard = new Dashboard();
        TransactionProcess transactionProcess = new TransactionProcess();

        //After
        [Given(@"User goes to DisputeDev Application")]
        public void GivenUserGoesToDisputeDevApplication()
        {
            login.InitializeDriver();
            login.GoToURL("https://disputedev.azurewebsites.net/#/login");
        }

        [Given(@"User enters ""([^""]*)"" in Username field on Login page")]
        public void GivenUserEntersInUsernameFieldOnLoginPage(string username)
        {
            login.EnterEmailOnLoginPage(username);
        }

        [Given(@"User enters ""([^""]*)"" in Password field on Login page")]
        public void GivenUserEntersInPasswordFieldOnLoginPage(string password)
        {
            login.EnterPasswordOnLoginPage(password);
        }

        [Given(@"User clicks on Login button on Login page")]
        public void GivenUserClicksOnLoginButtonOnLoginPage()
        {
           login.ClickLoginButtonOnLoginPage();
        }

        [Given(@"User enters OTP on Login Verification dialog")]
        public void GivenUserEntersOTPOnLoginVerificationDialog()
        {
            Thread.Sleep(5000);
            string otpCode = loginVerification.GetOTP();
            loginVerification.EnterOTPOnLoginVerificationDialog(otpCode);
        }

        [When(@"User clicks on Authenicate button on Login Verification dialog")]
        public void WhenUserClicksOnAuthenicateButtonOnLoginVerificationDialog()
        {
            loginVerification.ClickAuthenticateButtonOnLoginVerificationDialog();
            

        }

        [Then(@"User should be able to see Dashboard in Application")]
        public void ThenUserShouldBeAbleToSeeDashboardInApplication()
        {
            dashboard.DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog();
        }

        //Futher Work

        [Given(@"User clicks the ProfileIcon on the Dashboard page")]
        public void GivenUserClicksTheProfileIconOnTheDashboardPage()
        {
            dashboard.ClickProfileIconOnDashboardPage();
        }

        [Given(@"User selects the Transaction Processes Field from the dropdown menu of ProfileIcon")]
        public void GivenUserSelectsTheTransactionProcessesFieldFromTheDropdownMenuOfProfileIcon()
        {
            dashboard.ClickTransactionProcessesFieldOnProfileIconDropDown();
        }

        [Given(@"User clicks the AddTransactionProcessIcon on Transaction Process Page")]
        public void GivenUserClicksTheAddTransactionProcessIconOnTransactionProcessPage()
        {
            transactionProcess.ClickAddTransactionProcessesElementOnTransactionProcessPage();
        }

        [Given(@"User enters the following data into the fields on Add Process Transaction Setup Dialog")]
        public void GivenUserEntersTheFollowingDataIntoTheFieldsOnAddProcessTransactionSetupDialog(Table table)
        {
            // var transactionProcessesValues = table.CreateInstance<TransactionProcesses>();
            //  transactionProcesses.EnterNameOnAddProcessTransactionSetupDialog(transactionProcessesValues.Name);
            //  transactionProcesses.SelectTypeOnAddProcessTransactionSetupDialog(transactionProcessesValues.Type);
            //  transactionProcesses.SelectGLReferenceOnAddProcessTransactionSetupDialog(transactionProcessesValues.GLReference);
            //  transactionProcesses.SelectWorkflowsOnAddProcessTransactionSetupDialog(transactionProcessesValues.Workflows);
            transactionProcess.PerformingActionsOnAddProcessTransactionSetupDialog(table);

        }

        [When(@"User clicks the Save Button on Add Process Transaction Setup Dialog")]
        public void WhenUserClicksTheSaveButtonOnAddProcessTransactionSetupDialog()
        {
            transactionProcess.UserClicksSaveButtonOnAddProcessTransactionSetupDialog();
        }

        [Then(@"User should be able to see Process Transaction Setup saved on Transaction Process Page")]
        public void ThenUserShouldBeAbleToSeeProcessTransactionSetupSavedOnTransactionProcessPage()
        {
            
        }



    }
}