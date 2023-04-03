
using UITestAutomation.Pages;
using UITestAutomation.Pages.ChangePassword;
using UITestAutomation.Pages.Customer;
using UITestAutomation.Pages.Dashboard;
using UITestAutomation.Pages.Login;
using UITestAutomation.Pages.LoginVerification;
using UITestAutomation.Pages.TransactionProcess;
using UITestAutomation.Pages.UserPools;
using UITestAutomation.Pages.Users;
using UITestAutomation.Pages.WorkflowSettings;

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
        Brands brands = new Brands();
        BatchReporting batchReporting = new BatchReporting();
        GLDefinitions glDefinitions = new GLDefinitions();
        ImportConfigurations importConfigurations = new ImportConfigurations();

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

        //ChangePassword Done
        [Given(@"User log into Dispute Tracking Application")]
        public void GivenUserLogIntoDisputeTrackingApplication()
        {
            login.EnterEmailOnLoginPage("abdul@finboa.com");
            login.EnterPasswordOnLoginPage("Password@5");
            login.ClickLoginButtonOnLoginPage();
            string otpCode = loginVerification.GetOTP();
            Thread.Sleep(5000);
            loginVerification.EnterOTPOnLoginVerificationDialog(otpCode);
            loginVerification.ClickAuthenticateButtonOnLoginVerificationDialog();
        }
        [Given(@"User should be able to see Dashboard in Application")]
        public void GivenUserShouldBeAbleToSeeDashboardInApplication()
        {
            dashboard.DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog();
        }
        [Given(@"User clicks the Profile Icon on Dashboard page")]
        public void GivenUserClicksTheProfileIconOnDashboardPage()
        {
            dashboard.ClickProfileIconOnDashboardPage();
        }

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

        //UserPools Done
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

        [Given(@"User clicks the Close Button on Add User Pool Page")]
        public void GivenUserClicksTheCloseButtonOnAddUserPoolPage()
        //{
        {
            userPools.ClickCloseButton();
        }
        //    dashboard.ClickProfileIconOnDashboardPage();
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

        [Given(@"User log into Dispute Tracking Application")]
        public void GivenUserLogIntoDisputeTrackingApplication()
            string otpCode = loginVerification.GetOTP();
        //WorkflowSettings Done
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

        [Given(@"User clicks the Close Button on Add Trigger Page")]
        public void GivenUserClicksTheCloseButtonOnAddTriggerPage()
        {
            workflows.ClickCloseButtononAddTriggerDialog();
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

        //BRANDS

        
        {
        }
        [Given(@"User validates the following UI Controls on the Brand Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheBrandPage(Table table)
        {
            brands.AssertUIControlsOnBrandsPage(table);
        }
        {
        }

        {
        }

        //BATCH REPORTING

        {
        }

        {
        }

        //COMPANY DETAILS

        {
        }
        [Given(@"User validates the following UI Controls on Company Details Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnCompanyDetailsPage(Table table)
        {
            companyDetails.AssertUIControlsOnCompanyDetailsPage(table);
        }
        {
        }

        {
        }

        {
        }
        [Given(@"User validates the following fields on General Settings Page")]
        public void GivenUserValidatesTheFollowingFieldsOnGeneralSettingsPage(Table table)
        {
            companyDetails.AssertFieldsonGeneralSettingsPage(table);
        }
        {
        }

        {
        }
        [Given(@"User validates the following UI Controls on Add Lookup Values Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnAddLookupValuesPage(Table table)
        {
            companyDetails.AssertFieldsonAddPagesofLookupValuesPage(table);
        }
        {
        }

        {
        }


        //FIELD UPDATE SCRIPTS

        {
        }
        [Given(@"User validates the following UI Controls on the Field Update Script Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheFieldUpdateScriptPage(Table table)
        {
            fieldUpdateScripts.AssertUIControlsonFieldUpdateScriptsPage(table);
        }
        {
        }

        {
        }

        {
        }
        [Given(@"User validates the following UI Controls and fields on the Field Update Script Page")]
        public void GivenUserValidatesTheFollowingUIControlsAndFieldsOnTheFieldUpdateScriptPage(Table table)
        {
            fieldUpdateScripts.AssertFieldsonDownloadfromlibraryPage(table);
        }

        //GL DEFINITIONS

        {
        }

        {
        }

        {
        }
        [Given(@"User validates the following fields on the Add GL Definitions Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheAddGLDefinitionsPage(Table table)
        {
            glDefinitions.AssertFieldsonAddGLDefinitionPage(table);
        }

        //users
        {
        }

        {
        }

        //IMPORT CONFIGURATIONS PAGE

        {
            login.EnterPasswordOnLoginPage("Password@5");
            login.ClickLoginButtonOnLoginPage();
            Thread.Sleep(5000);

            string otpCode = loginVerification.GetOTP();
            loginVerification.EnterOTPOnLoginVerificationDialog(otpCode);
            loginVerification.ClickAuthenticateButtonOnLoginVerificationDialog();
        }

        {
        }

        {
        }

        [Given(@"User selects the Import Configurations option from the drop down menu of the ProfileIcon")]
        public void GivenUserSelectsTheImportConfigurationsOptionFromTheDropDownMenuOfTheProfileIcon()
        {
            importConfigurations.ClickImportConfigurationsOption();
        }
        {
        }
        [Given(@"User clicks the Add Configuration Button on the Import Configurations Page")]
        public void GivenUserClicksTheAddConfigurationButtonOnTheImportConfigurationsPage()
        {
            importConfigurations.AddConfigurationButtonn();
        }
        [Given(@"User validates the following fields on the Add Import Configurations Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheAddImportConfigurationsPage(Table table)
        {
            importConfigurations.AssertFieldsonAddConfigurationonImportConfigurationsPage(table);
        }


    }
}
