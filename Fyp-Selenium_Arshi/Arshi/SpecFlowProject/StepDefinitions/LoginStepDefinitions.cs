using FluentAssertions;
using NUnit.Framework;
using SpecFlowProject_prac.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject_prac.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        Login login = new Login();
        LoginVerification loginVerification = new LoginVerification();

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
            string otpCode = loginVerification.GetOTP();
            loginVerification.EnterOTPOnLoginVerificationDialog(otpCode);
        }

        [When(@"User clicks on Authenicate button on Login Verification dialog")]
        public void WhenUserClicksOnAuthenicateButtonOnLoginVerificationDialog()
        {
            loginVerification.ClickAuthenticateButtonOnLoginVerificationDialog();
        }

        [Then(@"User sholud be able to Login into Application")]
        public void ThenUserSholudBeAbleToLoginIntoApplication()
        {
            
        }

    }
}
