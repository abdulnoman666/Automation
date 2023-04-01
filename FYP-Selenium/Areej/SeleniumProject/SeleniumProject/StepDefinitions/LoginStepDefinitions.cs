using FluentAssertions;
using NUnit.Framework;
using SeleniumProject.Pages;
using System;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace SpecFlowProject_prac.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        Login login = new Login();
        LoginVerification loginVerification = new LoginVerification();
        Dashboard dashboard = new Dashboard();
        FeeReimbursementSettings feeReimbursementSettings = new FeeReimbursementSettings();
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
        [Given(@"User log into Dispute Tracking Application")]
        public void GivenUserLogIntoDisputeTrackingApplication()
        {
            login.InitializeDriver();
            login.GoToURL("https://disputedev.azurewebsites.net/#/login");

            login.EnterEmailOnLoginPage("abdul@finboa.com");
            login.EnterPasswordOnLoginPage("Password@4");
            login.ClickLoginButtonOnLoginPage();

            Thread.Sleep(5000);
            string otpCode = loginVerification.GetOTP();
            loginVerification.EnterOTPOnLoginVerificationDialog(otpCode);

            loginVerification.ClickAuthenticateButtonOnLoginVerificationDialog();

            dashboard.DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog();
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
        public void TDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHInApplication()
        {
            dashboard.DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog();
        }

        [Given(@"User should be able to see Dashboard in Application")]
        public void GivenUserShouldBeAbleToSeeDashboardInApplication()
        {
            dashboard.DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog();
        }

        [Given(@"User clicks the Profile Icon on the dashboard page")]
        public void GivenUserClicksTheProfileIconOnTheDashboardPage()
        {
            dashboard.ClickProfileIconOnDashboardPage();
        }

        [Given(@"User Selects the FeeReimbursementSettings from the dropdown menu of the Page")]
        public void GivenUserSelectsTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHDropdownMenuOfThePage()
        {
            dashboard.ClickTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHIconDropDown();
        }

        [Given(@"User clicks the AddFeeReimbursementSettingsIcon on Fee Reimbursement Settings Page")]
        public void GivenUserClicksTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHOnFeeReimbursementSettingsPage()
        {
            feeReimbursementSettings.ClickTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHOnFeeReimbursementSettingsPage();
        }

        [Given(@"User enters the following data into the fields on Add FeeReimbursementSettings Dialog")]
        public void GivenUserEntersTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHFeeReimbursementSettingsDialog(Table table)
        {
            feeReimbursementSettings.PerformingActionsOnAddFeeReimbursementSettingsDialog(table);
        }

        [When(@"User clicks on save button on the Fee Reimbursement Settings Page")]
        public void WhenUserClicksOnSaveButtonOnTheFeeReimbursementSettingsPage()
        {
            feeReimbursementSettings.UserClicksOnSaveButtonOnTheAddFeeReimbursementSettingsDialog();
        }

        [Then(@"User will be able to see the new settings saved on the Fee Reimbursement Settings Page")]
        public void TDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHngsSavedOnTheFeeReimbursementSettingsPage()
        {
          
        }
        //delete
        //[Given(@"User clicks on the Delete Fee Reimbursement button on Page")]
        //public void GivenUserClicksOnTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHage()
        //{
          //  feeReimbursementSettings.UserClicksOnTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHage();
        //}
       
      //  [When(@"User clicks on ""([^""]*)"" option on the popup to confirm deletion")]
        //public void WhenUserClicksOnOptionOnThePopupToConfirmDeletion(string yes)
        //{
          //  throw new PendingStepException();
        //}

        //[Then(@"User should be able to see the Fee Reimbursement Settings deleted from the page")]
       // public void TDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHmbursementSettingsDeletedFromThePage()
        //{
          //  throw new PendingStepException();
        //}

        //Edit

       // [Given(@"User clicks on the Edit Fee Reimbursement button on the Fee Reimbursement Settings Page")]
       // public void GivenUserClicksOnTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHFeeReimbursementSettingsPage()
       // {
        //    throw new PendingStepException();
      //  }

      //  [Given(@"User edits the infromation in the Reference textbox on the Page")]
      //  public void GivenUserEditsTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHxOnThePage()
       // {
       //     throw new PendingStepException();
      //  }

       // [Given(@"User edits the information in the Description textbox one the Page")]
       // public void GivenUserEditsTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHboxOneThePage()
       // {
       //     throw new PendingStepException();
      //  }

       // [Given(@"User unchecks the AutoGenerateGL checkbox on Fee Reimbursement Settings Page")]
       // public void GivenUserUnchecksTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHbursementSettingsPage()
       // {
       //     throw new PendingStepException();
       // }

       // [Given(@"User selects ""([^""]*)"" from the AutoFeeGLReference dropdown menu on the Fee Reimbursement Settings Page")]
       // public void GivenUserSelectsFromTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHnTheFeeReimbursementSettingsPage(string rEF)
       // {
        //    throw new PendingStepException();
        //}

       // [Given(@"User unchecks on the showOnDsputeForm checkbox on the Fee Reimbursement Settings Page")]
       // public void GivenUserUnchecksOnTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHeReimbursementSettingsPage()
       // {
       //     throw new PendingStepException();
       // }

        //[Given(@"User unchecks on the createDispute checkbox on the Fee Reimbursement Settings Page")]
       // public void GivenUserUnchecksOnTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHimbursementSettingsPage()
       // {
       //     throw new PendingStepException();
       // }

        //[Given(@"User unchecks on the includeInClaimTotal checkbox on the Fee Reimbursement Settings Page")]
       // public void GivenUserUnchecksOnTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHeFeeReimbursementSettingsPage()
       // {
        //    throw new PendingStepException();
        //}

        //[When(@"User clicks on the Save button on Fee Reimbursement Settings page")]
        //public void WhenUserClicksOnTDNEpUTHQoQUJMHLrErGJyHg89uy71MyuHtingsPage()
       // {
       //     throw new PendingStepException();
       // }
   // }
//}

