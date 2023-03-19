using OpenQA.Selenium;
using OTP_S.Helper_Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpecFlowOtp.Pages;

public class authenicate_app : Selenium_Methods.SMethods

{

    string appUsername = "abdul@finboa.com";
    string emailPassword = "$Pak35tan$2025";
    string otpToken = string.Empty;

    By popup = By.ClassName("modal-content");
    By otpverify = By.Id("otp");
    By otpclkbtn = By.ClassName("reply-button");

 public void Pop()
    {
        Thread.Sleep(5000);
        driver.FindElement(popup);
    }
    public string otp_get()
    {

        Thread.Sleep(5000);
        otpToken = HelperFunction.GetEmailAuthenticationCode2(appUsername, emailPassword);
        return otpToken;
    }
    public void verify_action(string otp)

    {

        Thread.Sleep(5000);

        driver.FindElement(otpverify).SendKeys(otp);
    }
    public void otp_click()

    {

        ClickOn(otpclkbtn);
    }
}
