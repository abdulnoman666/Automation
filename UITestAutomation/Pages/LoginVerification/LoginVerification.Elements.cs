using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class LoginVerification
    {
        //string appUsername = "abdul@finboa.com";
        //string emailPassword = "$Pak35tan$2026";
        string otpToken = string.Empty;
        By OTP_Textbox = By.Id("otp");
        By Authenticate_Button = By.ClassName("reply-button");
    }
}
