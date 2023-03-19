using FluentAssertions;
using SpecFlowOtp.Pages;
using NUnit Framework;
using SpecFlowOtp.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOtp.StepDefinitions

[Binding]

public class LoginStepDef : Login
{
    //USER LOGIN

    Login log = new Login();

    [Given(@"User open the browser and Enters url")]
    public void GivenUserOpenTheBrowserAndEntersUrl()

    {

        initialize_driver();
        GoTo("https://disputedev.azurewebsites.net/#/login");

        [When(@"User Enter ""([^""]*)"" Username")]|
    public void WhenUserEntersUsername(string p0)

        {
            Email_app(p0); 
        }
    [When(@"""([^""]*)"" in Password field")]
    public void WhenInPasswordField(string pe)

{
    Password_app(pe);
    [Then(@"Clicks login button")]

    public void ThenClicksLoginButton()
    Click(); }
//OTP VERIFICATION otp_verify verify = new otp_verify();

[Given(@"Popup window appears")] O references public void GivenPopupWindowAppears()
{
    verify.Pop();
    [When(@"Otp will be entered")]
    public void WhenotpWillBeEntered()
    {
        string otp_value verify.otp_get();
        verify verify_action(otp_value);

        [Then(@"Clicks Authenticate button")]
        public void ThenClicksAuthenticateButton()
        {
            verify.otp_click();
        } 
    }
} 
}
}