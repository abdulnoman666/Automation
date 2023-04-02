
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
        Brands brands = new Brands();
        BatchReporting batchReporting = new BatchReporting();
        CompanyDetails companyDetails = new CompanyDetails();
        FieldUpdateScripts fieldUpdateScripts = new FieldUpdateScripts();
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

        //ChangePassword


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

        //BRANDS

        
        [Given(@"User selects the Brands option from the drop down menu of the ProfileIcon")]
        public void GivenUserSelectsTheBrandsOptionFromTheDropDownMenuOfTheProfileIcon()
        {
            brands.ClickBrandsOption();
        }
        [Given(@"User validates the following UI Controls on the Brand Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheBrandPage(Table table)
        {
            brands.AssertUIControlsOnBrandsPage(table);
        }
        
        [Given(@"User clicks the Add Brand Icon on the Brand Page")]
        public void GivenUserClicksTheAddBrandIconOnTheBrandPage()
        {
            brands.ClickAddNewCaseBrandButton();
        }
        [Given(@"User validates the following fields on the Brand Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheBrandPage(Table table)
        {
            brands.AssertFieldsonAddBrandsPage(table);
        }

        //BATCH REPORTING

        [Given(@"User selects the Batch Reporting option from the drop down menu of the ProfileIcon")]
        public void GivenUserSelectsTheBatchReportingOptionFromTheDropDownMenuOfTheProfileIcon()
        {
            batchReporting.ClickBatchReportingOption();
        }
        [Given(@"User validates the following UI Controls on the Batch Reporting Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheBatchReportingPage(Table table)
        {
            batchReporting.AssertUIControlsOnBatchReportingPage(table);
        }

        //COMPANY DETAILS

        [Given(@"User selects the Company Details Option from the dropdown menu of ProfileIcon")]
        public void GivenUserSelectsTheCompanyDetailsOptionFromTheDropdownMenuOfProfileIcon()
        {
            companyDetails.ClickCompanyDetailsOption();
        }
        [Given(@"User validates the following UI Controls on Company Details Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnCompanyDetailsPage(Table table)
        {
            companyDetails.AssertUIControlsOnCompanyDetailsPage(table);
        }
        [Given(@"User selects the Basic Info button on Company Details Page")]
        public void GivenUserSelectsTheBasicInfoButtonOnCompanyDetailsPage()
        {
            companyDetails.ClickBasicInfoButtonn();
        }
        [Given(@"User validates the following fields on Basic Info Page")]
        public void GivenUserValidatesTheFollowingFieldsOnBasicInfoPage(Table table)
        {
            companyDetails.AssertFieldsonBasicInfoPage(table);
        }
        [Given(@"User clicks on the General Settings button on Company Details Page")]
        public void GivenUserClicksOnTheGeneralSettingsButtonOnCompanyDetailsPage()
        {
            companyDetails.ClickGeneralSettingsButtonn();
        }
        [Given(@"User validates the following fields on General Settings Page")]
        public void GivenUserValidatesTheFollowingFieldsOnGeneralSettingsPage(Table table)
        {
            companyDetails.AssertFieldsonGeneralSettingsPage(table);
        }
        [Given(@"User clicks on the Lookup Values button on Company Details Page")]
        public void GivenUserClicksOnTheLookupValuesButtonOnCompanyDetailsPage()
        {
            companyDetails.ClickLookupValuesButtonn();
        }
        [Given(@"User validates the following UI Controls on Lookup Values Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnLookupValuesPage(Table table)
        {
            companyDetails.AssertUIControlsOnLookupValuesPage(table);
        }
        [Given(@"User validates the following UI Controls on Add Lookup Values Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnAddLookupValuesPage(Table table)
        {
            companyDetails.AssertFieldsonAddPagesofLookupValuesPage(table);
        }
        [Given(@"User clicks on Style Button on Company Details Page")]
        public void GivenUserClicksOnStyleButtonOnCompanyDetailsPage()
        {
            companyDetails.ClickStyleButtonn();
        }
        [Given(@"User validates the following UI Controls on Style Button Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnStyleButtonPage(Table table)
        {
            companyDetails.AssertUIControlsonStylePage(table);
        }


        //FIELD UPDATE SCRIPTS

        [Given(@"User selects the Field Update Scripts option from the dropdown menu of ProfileIcon")]
        public void GivenUserSelectsTheFieldUpdateScriptsOptionFromTheDropdownMenuOfProfileIcon()
        {
            fieldUpdateScripts.ClickFieldUpdateScriptsOption();
        }
        [Given(@"User validates the following UI Controls on the Field Update Script Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheFieldUpdateScriptPage(Table table)
        {
            fieldUpdateScripts.AssertUIControlsonFieldUpdateScriptsPage(table);
        }
        [Given(@"User clicks the Add Script Icon on the Field Update Script Page")]
        public void GivenUserClicksTheAddScriptIconOnTheFieldUpdateScriptPage()
        {
            fieldUpdateScripts.ClickAddFieldUpdateScriptOption();
        }
        [Given(@"User validates the following fields on the Field Update Script Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheFieldUpdateScriptPage(Table table)
        {
            fieldUpdateScripts.AssertFieldsonAddFieldUpdateScriptPage(table);
        }
        [Given(@"User clicks the Download From Library Button on the Field Update Script Page")]
        public void GivenUserClicksTheDownloadFromLibraryButtonOnTheFieldUpdateScriptPage()
        {
            fieldUpdateScripts.ClickDownloadfromlibraryButton();
        }
        [Given(@"User validates the following UI Controls and fields on the Field Update Script Page")]
        public void GivenUserValidatesTheFollowingUIControlsAndFieldsOnTheFieldUpdateScriptPage(Table table)
        {
            fieldUpdateScripts.AssertFieldsonDownloadfromlibraryPage(table);
        }

        //GL DEFINITIONS

        [Given(@"User selects the GL Definitions option from the drop down menu of the ProfileIcon")]
        public void GivenUserSelectsTheGLDefinitionsOptionFromTheDropDownMenuOfTheProfileIcon()
        {
            glDefinitions.ClickGLDefinitionsOption();
        }
        [Given(@"User validates the following UI Controls on the GL Definitions Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheGLDefinitionsPage(Table table)
        {
            glDefinitions.AssertUIControlsonGLDefinitionsPage(table);
        }
        [Given(@"User clicks the Add GL Definition Icon on the GL Definitions Page")]
        public void GivenUserClicksTheAddGLDefinitionIconOnTheGLDefinitionsPage()
        {
            glDefinitions.AddGLDefinitionButton();
        }
        [Given(@"User validates the following fields on the Add GL Definitions Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheAddGLDefinitionsPage(Table table)
        {
            glDefinitions.AssertFieldsonAddGLDefinitionPage(table);
        }

        [Given(@"User clicks the Download from Library Button on the GL Definitions Page")]
        public void GivenUserClicksTheDownloadFromLibraryButtonOnTheGLDefinitionsPage()
        {
            glDefinitions.DownloadfromLibraryButton();
        }
        [Given(@"User validates the following fields on the Download from Library Button Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheDownloadFromLibraryButtonPage(Table table)
        {
            glDefinitions.AssertFieldsonDownloadfromLibraryPage(table);
        }

        //IMPORT CONFIGURATIONS PAGE

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

        [Given(@"User selects the Import Configurations option from the drop down menu of the ProfileIcon")]
        public void GivenUserSelectsTheImportConfigurationsOptionFromTheDropDownMenuOfTheProfileIcon()
        {
            importConfigurations.ClickImportConfigurationsOption();
        }
        [Given(@"User validates the following UI Controls on the Import Configurations Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheImportConfigurationsPage(Table table)
        {
            importConfigurations.AssertUIControlsonImportConfigurationsPage(table);
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
