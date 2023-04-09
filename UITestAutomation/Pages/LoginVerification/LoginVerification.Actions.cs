using Fyp_Arshi.Helper_Functions;

namespace UITestAutomation.Pages.LoginVerification
{
    internal partial class LoginVerification : Selenium_Methods
    {
        public string GetOTP(string appUsername,string emailPassword)
        {
            otpToken = HelperFunction.GetEmailAuthenticationCode2(appUsername, emailPassword);
            return otpToken;
        }

        public void EnterOTPOnLoginVerificationDialog(string otpCode)
        {
            WaitForWebElementDisplayed(OTP_Textbox);
            EnterValueinWebElement(OTP_Textbox, otpCode);
        }

        public void ClickAuthenticateButtonOnLoginVerificationDialog()
        {
            WaitForWebElementDisplayed(Authenticate_Button);
            ClickOnWebElement(Authenticate_Button);
        }
    }
}
