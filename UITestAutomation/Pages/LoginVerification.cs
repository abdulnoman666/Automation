using Fyp_Arshi.Helper_Functions;
using OpenQA.Selenium;

namespace UITestAutomation
{
    public class LoginVerification : Selenium_Methods
    {
        string appUsername = "abdul@finboa.com";
        string emailPassword = "$Pak35tan$2026";
        string otpToken = string.Empty;
        By OTP_Textbox= By.Id("otp");
        By Authenticate_Button = By.ClassName("reply-button");

        public string GetOTP()
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
