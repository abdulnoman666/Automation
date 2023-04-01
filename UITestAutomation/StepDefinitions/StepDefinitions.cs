
using UITestAutomation.Pages;

namespace UITestAutomation
{
    [Binding]
    public class StepDefinitions
    {
        Login login = new Login();
        LoginVerification loginVerification = new LoginVerification();
        Dashboard dashboard = new Dashboard();
        ChangePassword changepassword = new ChangePassword();
        UserPools userPools = new UserPools();
        TransactionProcess transactionProcess = new TransactionProcess();
        WorkflowSettings workflows = new WorkflowSettings();

        //Login
        [Given(@"User goes to DisputeDev Application")]
        public void GivenUserGoesToDisputeDevApplication()
        {
            Selenium_Methods.GoToURL("https://disputedev.azurewebsites.net/#/login");
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

        [Then(@"User should be able to see Dashboard in Application")]
        public void ThenUserShouldBeAbleToSeeDashboardInApplication()
        {
            dashboard.DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog();
        }

        //ChangePassword
        //[Given(@"User log into Dispute Tracking Application")]
        //public void GivenUserLogIntoDisputeTrackingApplication()
        //{
        //    login.InitializeDriver();
        //    login.GoToURL("https://disputedev.azurewebsites.net/#/login");
        //    login.EnterEmailOnLoginPage("abdul@finboa.com");
        //    login.EnterPasswordOnLoginPage("Password@5");
        //    login.ClickLoginButtonOnLoginPage();
        //    Thread.Sleep(5000);

        //    string otpCode = loginVerification.GetOTP();
        //    loginVerification.EnterOTPOnLoginVerificationDialog(otpCode);
        //    loginVerification.ClickAuthenticateButtonOnLoginVerificationDialog();
        //}

        //[Given(@"User should be able to see Dashboard in Application")]
        //public void GivenUserShouldBeAbleToSeeDashboardInApplication()
        //{
        //    dashboard.DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog();
        //}

        //[Given(@"User clicks the Profile Icon on Dashboard page")]
        //public void GivenUserClicksTheProfileIconOnDashboardPage()
        //{
        //    dashboard.ClickProfileIconOnDashboardPage();
        //}

        [Given(@"User selects the Change Password Field from the dropdown menu of Profile Icon")]
        public void GivenUserSelectsTheChangePasswordFieldFromTheDropdownMenuOfProfileIcon()
        {
            changepassword.ClickChangePassword();
        }

        [Given(@"User validates the following UI Controls on Change Password Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnChangePasswordPage(Table table)
        {
            changepassword.AssertUIControlsOnChangePasswordPage(table);
        }

        [Given(@"User validates the following Fields on Change Password Page")]
        public void GivenUserValidatesTheFollowingFieldsOnChangePasswordPage(Table table)
        {
            changepassword.AssertFieldsOnChangePasswordPage(table);
        }

        //UserPools
        //[Given(@"User log into Dispute Tracking Application")]
        //public void GivenUserLogIntoDisputeTrackingApplication()
        //{
        //    login.InitializeDriver();
        //    login.GoToURL("https://disputedev.azurewebsites.net/#/login");
        //    login.EnterEmailOnLoginPage("abdul@finboa.com");
        //    login.EnterPasswordOnLoginPage("Password@5");
        //    login.ClickLoginButtonOnLoginPage();
        //    Thread.Sleep(5000);

        //    string otpCode = loginVerification.GetOTP();
        //    loginVerification.EnterOTPOnLoginVerificationDialog(otpCode);
        //    loginVerification.ClickAuthenticateButtonOnLoginVerificationDialog();
        //}

        //[Given(@"User should be able to see Dashboard in Application")]
        //public void GivenUserShouldBeAbleToSeeDashboardInApplication()
        //{
        //    dashboard.DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog();
        //}

        //[Given(@"User clicks the Profile Icon on Dashboard page")]
        //public void GivenUserClicksTheProfileIconOnDashboardPage()
        //{
        //    dashboard.ClickProfileIconOnDashboardPage();
        //}

        [Given(@"User selects the User Pools Field from the dropdown menu of Profile Icon")]
        public void GivenUserSelectsTheUserPoolsFieldFromTheDropdownMenuOfProfileIcon()
        {
            userPools.ClickUserPools();
        }

        [Given(@"User validates the following UI Controls on User Pools Process Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnUserPoolsProcessPage(Table table)
        {
            userPools.AssertUIControlsonUserPoolsPage(table);
        }

        [Given(@"User clicks the Add Pool on Add User Pool Page")]
        public void GivenUserClicksTheAddPoolOnAddUserPoolPage()
        {
            userPools.ClickAddPoolButton();
        }

        [Given(@"User validates the following fileds on Add User Pool Page")]
        public void GivenUserValidatesTheFollowingFiledsOnAddUserPoolPage(Table table)
        {
            userPools.AssertFieldsOnAddPoolDialog(table);
        }

        //TransactionProcess
        //[Given(@"User log into Dispute Tracking Application")]
        //public void GivenUserLogIntoDisputeTrackingApplication()
        //{
        //    login.InitializeDriver();
        //    login.GoToURL("https://disputedev.azurewebsites.net/#/login");
        //    login.EnterEmailOnLoginPage("abdul@finboa.com");
        //    login.EnterPasswordOnLoginPage("Password@5");
        //    login.ClickLoginButtonOnLoginPage();
        //    Thread.Sleep(5000);

        //    string otpCode = loginVerification.GetOTP();
        //    loginVerification.EnterOTPOnLoginVerificationDialog(otpCode);
        //    loginVerification.ClickAuthenticateButtonOnLoginVerificationDialog();
        //}

        //[Given(@"User should be able to see Dashboard in Application")]
        //public void GivenUserShouldBeAbleToSeeDashboardInApplication()
        //{
        //    dashboard.DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog();
        //}

        //[Given(@"User clicks the Profile Icon on Dashboard page")]
        //public void GivenUserClicksTheProfileIconOnDashboardPage()
        //{
        //    dashboard.ClickProfileIconOnDashboardPage();
        //}

        [Given(@"User selects the Transaction Processes Field from the dropdown menu of Profile Icon")]
        public void GivenUserSelectsTheTransactionProcessesFieldFromTheDropdownMenuOfProfileIcon()
        {
            transactionProcess.ClickTransactionProcesses();
        }

        [Given(@"User validates the following UI Controls on Transaction Process Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTransactionProcessPage(Table table)
        {
            transactionProcess.AssertUIControlsonTransactionProcessesPage(table);
        }

        [Given(@"User clicks the Add Submission on Transaction Process Page")]
        public void GivenUserClicksTheAddSubmissionOnTransactionProcessPage()
        {
            transactionProcess.ClickAddTransactionProcessesButton();
        }

        [Given(@"User validates the following fields on Add Process Transaction Setup Dialog")]
        public void GivenUserValidatesTheFollowingFieldsOnAddProcessTransactionSetupDialog(Table table)
        {
            transactionProcess.AssertFieldsOnAddTransactionProcessesDialog(table);
        }

        //WorkflowSettings
        [Given(@"User log into Dispute Tracking Application")]
        public void GivenUserLogIntoDisputeTrackingApplication()
        {
            login.EnterEmailOnLoginPage("abdul@finboa.com");
            login.EnterPasswordOnLoginPage("Password@5");
            login.ClickLoginButtonOnLoginPage();
            Thread.Sleep(5000);

            string otpCode = loginVerification.GetOTP();
            loginVerification.EnterOTPOnLoginVerificationDialog(otpCode);
            loginVerification.ClickAuthenticateButtonOnLoginVerificationDialog();
        }

        [Given(@"User should be able to see Dashboard in Application")]
        public void GivenUserShouldBeAbleToSeeDashboardInApplication()
        {
            dashboard.DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog();
        }

        [Given(@"User clicks the Profile Icon on the Dashboard page")]
        public void GivenUserClicksTheProfileIconOnTheDashboardPage()
        {
            dashboard.ClickProfileIconOnDashboardPage();
        }

        [Given(@"User selects the Workflow Settings Field from the dropdown menu of Profile Icon")]
        public void GivenUserSelectsTheWorkflowSettingsFieldFromTheDropdownMenuOfProfileIcon()
        {
            workflows.ClickWorkflowSettings();
        }

        [Given(@"User validates the following UI Controls on Workflow Settings Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnWorkflowSettingsPage(Table table)
        {
            workflows.AssertUIControlsonWorkflowSettingPage(table);
        }

        [Given(@"User clicks the Add Workflow Setting on on Workflow Settings Page")]
        public void GivenUserClicksTheAddWorkflowSettingOnOnWorkflowSettingsPage()
        {
            workflows.ClickAddWorkflowSettings();
        }

        [Given(@"User validates the following Controls on Edit Setting Dialog")]
        public void GivenUserValidatesTheFollowingControlsOnEditSettingDialog(Table table)
        {
            workflows.AssertUIControlsonEditWorkflowSettingDialog(table);
        }

        [Given(@"User validates the following Fields in Settings Page on Edit Setting Dialog")]
        public void GivenUserValidatesTheFollowingFieldsInSettingsPageOnEditSettingDialog(Table table)
        {
            workflows.AssertFieldsonEditWorkflowSettingDialog(table);
        }

        [Given(@"User clicks the Event Triggers in Settings Page on Edit Setting Dialog")]
        public void GivenUserClicksTheEventTriggersInSettingsPageOnEditSettingDialog()
        {
            workflows.ClickEventTrigger();
        }

        [Given(@"User validates the following Controls in Event Triggers on Edit Setting Dialog")]
        public void GivenUserValidatesTheFollowingControlsInEventTriggersOnEditSettingDialog(Table table)
        {
            workflows.AssertUIControlsOnEventTriggers(table);
        }


        [Given(@"User clicks the Add Event Trigger in Event Triggers Page on on Edit Setting Dialog")]
        public void GivenUserClicksTheAddEventTriggerInEventTriggersPageOnOnEditSettingDialog()
        {
            workflows.ClickAddEventTriggerButton();
        }

        [Given(@"User validates the following Fields in Add Trigger Page on Edit Setting Dialog")]
        public void GivenUserValidatesTheFollowingFieldsInAddTriggerPageOnEditSettingDialog(Table table)
        {
            workflows.AssertFieldsOnAddTriggersDialog(table);
        }

        [Given(@"User clicks the Self-Service Verbiage in Settings Page on Edit Setting Dialog")]
        public void GivenUserClicksTheSelf_ServiceVerbiageInSettingsPageOnEditSettingDialog()
        {
            workflows.ClickSelfServiceVerbiageButton();
        }

        [Given(@"User validates the following Fields in Self-Service Verbiage Page on Edit Setting Dialog")]
        public void GivenUserValidatesTheFollowingFieldsInSelf_ServiceVerbiagePageOnEditSettingDialog(Table table)
        {
            workflows.AssertFieldsOnSelfServiceVerbiageDialog(table);
        }

    }
}
