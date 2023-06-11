using OpenQA.Selenium;

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
        Customer customer = new Customer();
        Users users = new Users();
        Brands brands = new Brands();
        BatchReporting batchReporting = new BatchReporting();
        CompanyDetails companyDetails = new CompanyDetails();
        FieldUpdateScripts fieldUpdateScripts = new FieldUpdateScripts();
        GLDefinitions glDefinitions = new GLDefinitions();
        ImportConfigurations importConfigurations = new ImportConfigurations();
        Tasks tasks = new Tasks();
        FeeSelectionSettings feeSelectionSettings = new FeeSelectionSettings();
        TransactionAlerts transactionAlerts = new TransactionAlerts();
        Disputes disputes = new Disputes();
        MonthlyReport monthlyReport = new MonthlyReport();
        LedgerReport ledgerReport = new LedgerReport();
        DailyLedger dailyLedger = new DailyLedger();
        LedgerBatches ledgerBatches = new LedgerBatches();
        FraudAlerts fraudAlerts = new FraudAlerts();
        ProvisionalCreditLog creditLog = new ProvisionalCreditLog();
        WorkflowAutomations automation = new WorkflowAutomations();
        WorkflowSettings workflows = new WorkflowSettings();
        TaskReports taskReports = new TaskReports();
        MonthlyReport monthlyReports = new MonthlyReport();
        ResetSubmission resetSubmission = new ResetSubmission();
        DeleteSubmission deleteSubmission = new DeleteSubmission();
        MyTasks myTasks = new MyTasks();
        SubmissionList submissionList = new SubmissionList();
        ActivityHistory activityHistory = new ActivityHistory();
        Reconciliation reconciliation = new Reconciliation();
        SubmissionsWithAlerts alerts = new SubmissionsWithAlerts();
        

        //Login **
        [Given(@"User goes to DisputeDev Application")]
        public void GivenUserGoesToDisputeDevApplication()
        {
            Selenium_Methods.GoToURL(ConfigHelper.GetConfig("Baseurl"));
        }

        [Given(@"User enters Username in Username field on Login page")]
        public void GivenUserEntersUsernameInUsernameFieldOnLoginPage()
        {
            login.EnterEmailOnLoginPage(ConfigHelper.GetConfig("applicationUsername"));
        }

        [Given(@"User enters Password in Password field on Login page")]
        public void GivenUserEntersPasswordInPasswordFieldOnLoginPage()
        {
            login.EnterPasswordOnLoginPage(ConfigHelper.GetConfig("applicationPassword"));
        }

        [Given(@"User clicks on Login button on Login page")]
        public void GivenUserClicksOnLoginButtonOnLoginPage()
        {
            login.ClickLoginButtonOnLoginPage();
        }

        [Given(@"User enters OTP on Login Verification dialog")]
        public void GivenUserEntersOTPOnLoginVerificationDialog()
        {
            string otpCode = loginVerification.GetOTP(ConfigHelper.GetConfig("emailUsername"), ConfigHelper.GetConfig("emailPassword"));
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
            login.EnterEmailOnLoginPage(ConfigHelper.GetConfig("applicationUsername"));
            login.EnterPasswordOnLoginPage(ConfigHelper.GetConfig("applicationPassword"));
            login.ClickLoginButtonOnLoginPage();
            Thread.Sleep(5000);
            string otpCode = loginVerification.GetOTP(ConfigHelper.GetConfig("emailUsername"), ConfigHelper.GetConfig("emailPassword"));
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

        //changepassword **
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

        
        //Customers Done **
        [Given(@"User clicks the Customer Field on the Dashboard page")]
        public void GivenUserClicksTheCustomerFieldOnTheDashboardPage()
        {
            dashboard.ClickCustomers();
        }

        [Given(@"User validates the following UI Controls on Customers Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnCustomersPage(Table table)
        {
            customer.AssertUIControlsonCustomerPage(table);
        }

        [Given(@"User clicks the Add Customer Button on Customers Page")]
        public void GivenUserClicksTheAddCustomerButtonOnCustomersPage()
        {
            customer.ClickAddCustomerButton();
        }

        [Given(@"User validates the following Fields Add Customer Button Dialog")]
        public void GivenUserValidatesTheFollowingFieldsAddCustomerButtonDialog(Table table)
        {
            customer.AssertFieldssonAddCustomerDialog(table);
        }

        [Given(@"User clicks the Close Button on Add Customer Button Dialog")]
        public void GivenUserClicksTheCloseButtonOnAddCustomerButtonDialog()
        {
            customer.ClickCloseAddButton();
        }

        [Given(@"User clicks the Search Button on Customers Page")]
        public void GivenUserClicksTheSearchButtonOnCustomersPage()
        {
            customer.ClickSearchButton();
        }

        [Given(@"User validates the following Fields on Search Dialog")]
        public void GivenUserValidatesTheFollowingFieldsOnSearchDialog(Table table)
        {
            customer.AssertFieldssonSearchButtonPage(table);
        }

        [Given(@"User enters ""([^""]*)"" in Customer Name field on Search Dialog")]
        public void GivenUserEntersInCustomerNameFieldOnSearchDialog(string name)
        {
            customer.EnterCustomerNameinSearchButtonPage("singal");
        }

        [Given(@"User clicks the Search Button on Search Dialog")]
        public void GivenUserClicksTheSearchButtonOnSearchDialog()
        {
            customer.ClickSearchButtonAfterEnteringValue();
        }

        [Given(@"User validates the following UIControls on Customer Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnCustomerPage(Table table)
        {
            customer.AssertUIControlsonCustomerPageAfterSearch(table);
        }

        [Given(@"User clicks the View Transactions on Customer Page")]
        public void GivenUserClicksTheViewTransactionsOnCustomerPage()
        {
            customer.ClickViewTransactionButton();
        }

        [Given(@"User validates the following Fields on Transaction Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTransactionPage(Table table)
        {
            customer.AssertFieldssonTransactionButtonPage(table);
        }

        [Given(@"User clicks the Close Button on Transaction Page")]
        public void GivenUserClicksTheCloseButtonOnTransactionPage()
        {
            customer.ClickCloseButtononTransactionPage();
        }

        [Given(@"User clicks the Edit Customer on Customer Page")]
        public void GivenUserClicksTheEditCustomerOnCustomerPage()
        {
            customer.ClickEditCustomerDocumentButton();
        }

        [Given(@"User validates the following Fields on Edit Customer Dialog")]
        public void GivenUserValidatesTheFollowingFieldsOnEditCustomerDialog(Table table)
        {
            customer.AssertFieldssonEditCustomerDocumentDialog(table);
        }

        [Given(@"User clicks the Close Button on Edit Customer Dialog")]
        public void GivenUserClicksTheCloseButtonOnEditCustomerDialog()
        {
            customer.ClickCloseButtononEditCustomerDocumentDialog();
        }

        [Given(@"User clicks the Customer Documents on Customer Page")]
        public void GivenUserClicksTheCustomerDocumentsOnCustomerPage()
        {
            customer.ClickCustomerDocumentButton();
        }

        [Given(@"User validates the following UI Controls on Document Manager Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnDocumentManagerPage(Table table)
        {
            customer.AssertUIControlsonDocumentManaagerPage(table);
        }

        [Given(@"User clicks the Dashboard Icon")]
        public void GivenUserClicksTheDashboardIcon()
        {
            dashboard.ClickDashboard();
        }

        //BRANDS **
        [Given(@"User selects the Brands option from the drop down menu of the ProfileIcon")]
        public void GivenUserSelectsTheBrandsOptionFromTheDropDownMenuOfTheProfileIcon()
        {
            brands.ClickBrandsButton();
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

        //BATCH REPORTING **

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

        //COMPANY DETAILS **

        [Given(@"User selects the Company Details Option from the dropdown menu of ProfileIcon")]
        public void GivenUserSelectsTheCompanyDetailsOptionFromTheDropdownMenuOfProfileIcon()
        {
            companyDetails.ClickCompanyDetailsButton();
        }
        [Given(@"User validates the following UI Controls on Company Details Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnCompanyDetailsPage(Table table)
        {
            companyDetails.AssertUIControlsonCompanyDetailsPage(table);
        }
        [Given(@"User selects the Basic Info button on Company Details Page")]
        public void GivenUserSelectsTheBasicInfoButtonOnCompanyDetailsPage()
        {
            companyDetails.ClickBasicInfoButton();
        }
        [Given(@"User validates the following fields on Basic Info Page")]
        public void GivenUserValidatesTheFollowingFieldsOnBasicInfoPage(Table table)
        {
            companyDetails.AssertFieldsonBasicInfoPage(table);
        }
        [Given(@"User clicks on the General Settings button on Company Details Page")]
        public void GivenUserClicksOnTheGeneralSettingsButtonOnCompanyDetailsPage()
        {
            companyDetails.ClickGeneralSettingsButton();
        }
        [Given(@"User validates the following fields on General Settings Page")]
        public void GivenUserValidatesTheFollowingFieldsOnGeneralSettingsPage(Table table)
        {
            companyDetails.AssertFieldsonGeneralSettingsPage(table);
        }
        [Given(@"User clicks on the Lookup Values button on Company Details Page")]
        public void GivenUserClicksOnTheLookupValuesButtonOnCompanyDetailsPage()
        {
            companyDetails.ClickLookupValuesButton();
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
            companyDetails.ClickStyleButton();
        }
        [Given(@"User validates the following UI Controls on Style Button Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnStyleButtonPage(Table table)
        {
            companyDetails.AssertUIControlsonStylePage(table);
        }


        //FIELD UPDATE SCRIPTS **

        [Given(@"User selects the Field Update Scripts option from the dropdown menu of ProfileIcon")]
        public void GivenUserSelectsTheFieldUpdateScriptsOptionFromTheDropdownMenuOfProfileIcon()
        {
            fieldUpdateScripts.ClickFieldUpdateScriptsButton();
        }
        [Given(@"User validates the following UI Controls on the Field Update Script Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheFieldUpdateScriptPage(Table table)
        {
            fieldUpdateScripts.AssertUIControlsonFieldUpdateScriptsPage(table);
        }
        [Given(@"User clicks the Add Script Icon on the Field Update Script Page")]
        public void GivenUserClicksTheAddScriptIconOnTheFieldUpdateScriptPage()
        {
            fieldUpdateScripts.ClickAddFieldUpdateScriptButton();
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

        //GL DEFINITIONS **

        [Given(@"User selects the GL Definitions option from the drop down menu of the ProfileIcon")]
        public void GivenUserSelectsTheGLDefinitionsOptionFromTheDropDownMenuOfTheProfileIcon()
        {
            glDefinitions.ClickGLDefinitionsButton();
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

        //IMPORT CONFIGURATIONS PAGE **

        [Given(@"User clicks the Profile Icon on the Dashboard page")]
        public void GivenUserClicksTheProfileIconOnTheDashboardPage()
        {
            dashboard.ClickProfileIconOnDashboardPage();
        }

        [Given(@"User selects the Import Configurations option from the drop down menu of the ProfileIcon")]
        public void GivenUserSelectsTheImportConfigurationsOptionFromTheDropDownMenuOfTheProfileIcon()
        {
            importConfigurations.ClickImportConfigurationsButton();
        }
        [Given(@"User validates the following UI Controls on the Import Configurations Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheImportConfigurationsPage(Table table)
        {
            importConfigurations.AssertUIControlsonImportConfigurationsPage(table);
        }
        [Given(@"User clicks the Add Configuration Button on the Import Configurations Page")]
        public void GivenUserClicksTheAddConfigurationButtonOnTheImportConfigurationsPage()
        {
            importConfigurations.AddConfigurationButton();
        }
        [Given(@"User validates the following fields on the Add Import Configurations Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheAddImportConfigurationsPage(Table table)
        {
            importConfigurations.AssertFieldsonAddConfigurationonImportConfigurationsPage(table);
        }

        //Tasks **
        [Given(@"User selects the Tasks option from the drop down menu of the ProfileIcon")]
        public void GivenUserSelectsTheTasksOptionFromTheDropDownMenuOfTheProfileIcon()
        {
            tasks.ClickTasksButton();
        }
        [Given(@"User validates the following UI Controls on the Tasks Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheTasksPage(Table table)
        {
            tasks.AssertUIControlsOnTasksPage(table);
        }
        [Given(@"User clicks the Add New Task Icon on the Tasks Page")]
        public void GivenUserClicksTheAddNewTaskIconOnTheTasksPage()
        {
            tasks.ClickAddNewTaskButton();
        }
        [Given(@"User validates the following fields on the Add Tasks Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheAddTasksPage(Table table)
        {
            tasks.AssertFieldsOnAddTasksPage(table);
        }


        // Fee Selection Settings **
        [Given(@"User selects the Fee Selection Settings option from the drop down menu of the ProfileIcon")]
        public void GivenUserSelectsTheFeeSelectionSettingsOptionFromTheDropDownMenuOfTheProfileIcon()
        {
            feeSelectionSettings.ClickFeeSelectionSettingsButton();
        }
        [Given(@"User validates the following UI Controls on the Fee Selection Settings Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheFeeSelectionSettingsPage(Table table)
        {
            feeSelectionSettings.AssertUIControlsOnFeeSelectionSettingsPage(table);
        }
        [Given(@"User clicks the Add Fee Selection Icon on the Fee Selection Settings Page")]
        public void GivenUserClicksTheAddFeeSelectionIconOnTheFeeSelectionSettingsPage()
        {
            feeSelectionSettings.ClickAddFeeSelectionButton();
        }
        [Given(@"User validates the following fields on the Add Fee Selection Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheAddFeeSelectionPage(Table table)
        {
            feeSelectionSettings.AssertFieldsOnAddFeeSelectionPage(table);
        }

        // Transaction Alerts **
        [Given(@"User selects the Transaction Alerts option from the drop down menu of the ProfileIcon")]
        public void GivenUserSelectsTheTransactionAlertsOptionFromTheDropDownMenuOfTheProfileIcon()
        {
            transactionAlerts.ClickTransactionAlertsButton();
        }
        [Given(@"User validates the following UI Controls on the Transaction Alerts Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheTransactionAlertsPage(Table table)
        {
            transactionAlerts.AssertUIControlsOnTransactionAlertsPage(table);
        }
        [Given(@"User clicks the Add Transaction Alert Icon on the Transaction Alerts Page")]
        public void GivenUserClicksTheAddTransactionAlertIconOnTheTransactionAlertsPage()
        {
            transactionAlerts.ClickAddNewTransactionAlertButton();
        }
        [Given(@"User validates the following fields on the Add Transaction Alerts Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheAddTransactionAlertsPage(Table table)
        {
            transactionAlerts.AssertFieldslsOnAddTransactionAlertsPage(table);
        }



        // DISPUTES **
        [Given(@"User clicks the Disputes Icon on Dashboard page")]
        public void GivenUserClicksTheDisputesIconOnDashboardPage()
        {
            dashboard.ClickDisputeIcon();
        }
        [Given(@"User selects the Disputes option from the drop down menu of the Disputes Page")]
        public void GivenUserSelectsTheDisputesOptionFromTheDropDownMenuOfTheDisputesPage()
        {
            disputes.ClickDisputesButton();
        }
        [Given(@"User validates the following UI Controls on the Disputes Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnTheDisputesPage(Table table)
        {
            disputes.AssertUIControlsOnDisputesPage(table);
        }
        [Given(@"User clicks the Settings Button on the Disputes Page")]
        public void GivenUserClicksTheSettingsButtonOnTheDisputesPage()
        {
            disputes.ClickSettingsButton();
        }
        [Given(@"User validates the following fields on the Settings Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheSettingsPage(Table table)
        {
            disputes.AssertFieldsOnSettingsPage(table);
        }
        [Given(@"User clicks the Search Button on the Disputes Page")]
        public void GivenUserClicksTheSearchButtonOnTheDisputesPage()
        {
            disputes.ClickSearchButton();
        }
        [Given(@"User validates the following fields on the Search Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheSearchPage(Table table)
        {
            disputes.AssertFieldsOnSearchPage(table);
        }
        [Given(@"User clicks the Show Closed Disputes Button on the Disputes Page")]
        public void GivenUserClicksTheShowClosedDisputesButtonOnTheDisputesPage()
        {
            disputes.ClickShowClosedDisputesButton();
        }
        [Given(@"User validates the following fields on the Show Closed Disputes Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheShowClosedDisputesPage(Table table)
        {
            disputes.AssertFieldsOnShowClosedDisputesPage(table);
        }
        [Given(@"User clicks the Edit Disputes Button on the Disputes Page")]
        public void GivenUserClicksTheEditDisputesButtonOnTheDisputesPage()
        {
            disputes.ClickEditDisputeButton();
        }
        [Given(@"User validates the following UI Controls and fields on the Edit Disputes Page")]
        public void GivenUserValidatesTheFollowingUIControlsAndFieldsOnTheEditDisputesPage(Table table)
        {
            disputes.AssertUIControlsOnEditDisputesPage(table);
        }
        [Given(@"User clicks the Documents button on the Edit Disputes Page")]
        public void GivenUserClicksTheDocumentsButtonOnTheEditDisputesPage()
        {
            disputes.ClickDocumentsButton();
        }
        [Given(@"User validates the following fields on the Documents Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheDocumentsPage(Table table)
        {
            disputes.AssertUIControlsOnDocumentsPage(table);
        }
        [Given(@"User clicks the History button on the Edit Disputes Page")]
        public void GivenUserClicksTheHistoryButtonOnTheEditDisputesPage()
        {
            disputes.ClickHistoryButton();
        }
        [Given(@"User validates the following fields on the History Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheHistoryPage(Table table)
        {
            disputes.AssertUIControlsOnHistoryPage(table);
        }
        [Given(@"User clicks the Resolution Button on the Edit Disputes Page")]
        public void GivenUserClicksTheResolutionButtonOnTheEditDisputesPage()
        {
            disputes.ClickResolutionButton();
        }
        [Given(@"User validates the following fields on the Resolution Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheResolutionPage(Table table)
        {
            disputes.AssertFieldslsOnResolutionPage(table);
        }

        // Monthly Report **
        [Given(@"User clicks the Monthly Report Icon from the dropdown of Disputes Page")]
        public void GivenUserClicksTheMonthlyReportIconFromTheDropdownOfDisputesPage()
        {
            monthlyReport.ClickMonthlyReportButton();
        }
        [Given(@"User validates the following fields on the Monthly Report Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheMonthlyReportPage(Table table)
        {
            monthlyReport.AssertUIControlsOnMonthlyReportPage(table);
        }
        [Given(@"User clicks the Summary button on the Monthly Report Page")]
        public void GivenUserClicksTheSummaryButtonOnTheMonthlyReportPage()
        {
            monthlyReport.ClickSummaryButton();
        }
        [Given(@"User validates the following fields on the Summary Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheSummaryPage(Table table)
        {
            monthlyReport.AssertFieldslsOnSummaryPage(table);
        }
        [Given(@"User clicks the List button on the Monthly Report Page")]
        public void GivenUserClicksTheListButtonOnTheMonthlyReportPage()
        {
            monthlyReport.ClickListButton();
        }
        [Given(@"User validates the following fields on the List Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheListPage(Table table)
        {
            monthlyReport.AssertFieldsOnListsPage(table);
        }

        // Daily Ledger **
        [Given(@"User clicks the Daily Ledger Icon from the dropdown of Ledger")]
        public void GivenUserClicksTheDailyLedgerIconFromTheDropdownOfLedger()
        {
            dailyLedger.ClickDailyLedgerButton();
        }
        [Given(@"User validates the following fields on the Daily Ledger Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheDailyLedgerPage(Table table)
        {
            dailyLedger.AssertUIControlsOnDailyLedgerPage(table);
        }

        //Ledger Report **
        [Given(@"User clicks the Ledger Report button from the dropdown of Ledger Page")]
        public void GivenUserClicksTheLedgerReportButtonFromTheDropdownOfLedgerPage()
        {
            ledgerReport.ClickLedgerReportButton();
        }
        [Given(@"User validates the following fields on the Ledger Report Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheLedgerReportPage(Table table)
        {
            ledgerReport.AssertUIControlsOnLedgerReportPage(table);
        }
        [Given(@"User clicks the Ledger Entries button on the Ledger Report Page")]
        public void GivenUserClicksTheLedgerEntriesButtonOnTheLedgerReportPage()
        {
            ledgerReport.ClickLedgerEntriesButton();
        }
        [Given(@"User validates the following fields on the Ledger Entries Page of Ledger Report Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheLedgerEntriesPageOfLedgerReportPage(Table table)
        {
            ledgerReport.AssertFieldsOnLedgerEntriesPage(table);
        }


        // Ledger Batches **
        [Given(@"User clicks the Ledger Icon on the Dashboard Page")]
        public void GivenUserClicksTheLedgerIconOnTheDashboardPage()
        {
            dashboard.ClickLedgerIcon();
        }
        [Given(@"User clicks the Ledger Batches Icon from the dropdown of Ledger")]
        public void GivenUserClicksTheLedgerBatchesIconFromTheDropdownOfLedger()
        {
            ledgerBatches.ClickLedgerBatchesButton();
        }
        [Given(@"User validates the following fields on the Ledger Batches Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheLedgerBatchesPage(Table table)
        {
            ledgerBatches.AssertUIControlsOnLedgerBatchesPage(table);
        }
        [Given(@"User clicks the Ledger Entries button on the Ledger Batches Page")]
        public void GivenUserClicksTheLedgerEntriesButtonOnTheLedgerBatchesPage()
        {
           //legder
        }

        //WorkflowAutomations **
        [Given(@"User Selects the Workflow Automations from the dropdown menu of the Page")]
        public void GivenUserSelectsTheWorkflowAutomationsFromTheDropdownMenuOfThePage()
        {
            automation.ClickWorkflowAutomationsButton();
        }

        [Given(@"User validates following UI controls on WorkFlow Automations Page")]
        public void GivenUserValidatesFollowingUIControlsOnWorkFlowAutomationsPage(Table table)
        {
            automation.AssertUIControlsOnWorkflowAutomationsPage(table);
        }

        [Given(@"User clicks the Add Workflow Automations Icon on Workflow Automations Page")]
        public void GivenUserClicksTheAddWorkflowAutomationsIconOnWorkflowAutomationsPage()
        {
            automation.ClickOnAddWorkflowAutomationsButton();
        }

        [Given(@"User validates following fields on Add Workflow Automations Dialog")]
        public void GivenUserValidatesFollowingFieldsOnAddWorkflowAutomationsDialog(Table table)
        {
            automation.AssertFieldssOnAddWorkflowAutomationsPage(table);
        }

         // (Submissions)**
        //Taskreport
        [Given(@"User clicks the Submissions Field on the Dashboard page")]
        public void GivenUserClicksTheSubmissionsFieldOnTheDashboardPage()
        {
            dashboard.ClickSubmissions();
        }

        [Given(@"User selects the Task Reports Field from the dropdown menu of Submissions")]
        public void GivenUserSelectsTheTaskReportsFieldFromTheDropdownMenuOfSubmissions()
        {
            taskReports.ClickTaskReports();
        }

        [Given(@"User validates the following Fields on Task Reports Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTaskReportsPage(Table table)
        {
            taskReports.AssertFieldsonTaskReportPage(table);
        }

        //monthly report
        [Given(@"User selects the Monthly Report Field from the dropdown menu of Submissions")]
        public void GivenUserSelectsTheMonthlyReportFieldFromTheDropdownMenuOfSubmissions()
        {
            monthlyReports.ClickMonthlyReports();
        }

        [Given(@"User validates the following Fields on Monthly Report Page")]
        public void GivenUserValidatesTheFollowingFieldsOnMonthlyReportPage(Table table)
        {
            monthlyReports.AssertFieldsonMonthlyReportPage(table);
        }

        //reset submission
        [Given(@"User selects the Reset Submission Field from the dropdown menu of Submissions")]
        public void GivenUserSelectsTheResetSubmissionFieldFromTheDropdownMenuOfSubmissions()
        {
            resetSubmission.ClickResetSubmission();
        }

        [Given(@"User validates the following Fields on Reset Submission Page")]
        public void GivenUserValidatesTheFollowingFieldsOnResetSubmissionPage(Table table)
        {
            resetSubmission.AssertFieldsonResetSubmissionPage(table);
        }

        //delete submission
        [Given(@"User selects the Delete Submission Field from the dropdown menu of Submissions")]
        public void GivenUserSelectsTheDeleteSubmissionFieldFromTheDropdownMenuOfSubmissions()
        {
            deleteSubmission.ClickDeleteSubmission();
        }

        [Given(@"User validates the following Fields on Delete Submission Page")]
        public void GivenUserValidatesTheFollowingFieldsOnDeleteSubmissionPage(Table table)
        {
            deleteSubmission.AssertFieldsonDeleteSubmissionPage(table);
        }

        //My Tasks
        [Given(@"User selects the My Tasks Field from the dropdown menu of Submissions")]
        public void GivenUserSelectsTheMyTasksFieldFromTheDropdownMenuOfSubmissions()
        {
            myTasks.ClickMyTasks();
        }

        [Given(@"User validates the following Fields on My Tasks Page")]
        public void GivenUserValidatesTheFollowingFieldsOnMyTasksPage(Table table)
        {
            myTasks.AssertFieldsonMyTasksPage(table);
        }

        //Reconciliation
        [Given(@"User selects the Reconciliation Field from the dropdown menu of Submissions")]
        public void GivenUserSelectsTheReconciliationFieldFromTheDropdownMenuOfSubmissions()
        {
            reconciliation.ClickReconciliation();
        }

        [Given(@"User validates the following Fields on Reconciliation Page")]
        public void GivenUserValidatesTheFollowingFieldsOnReconciliationPage(Table table)
        {
            reconciliation.AssertFieldsonReconciliationPage(table);
        }

        //Submissions With Alerts
        [Given(@"User selects the Submissions With Alerts Field from the dropdown menu of Submissions")]
        public void GivenUserSelectsTheSubmissionsWithAlertsFieldFromTheDropdownMenuOfSubmissions()
        {
            alerts.ClickSubmissionsWithAlerts();
        }

        [Given(@"User validates the following UI Controls on Submissions With Alerts Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnSubmissionsWithAlertsPage(Table table)
        {
            alerts.AssertUIControlsonSubmissionsWithAlertsPage(table);
        }

        [Given(@"User validates the following Fields on Submissions With Alerts Page")]
        public void GivenUserValidatesTheFollowingFieldsOnSubmissionsWithAlertsPage(Table table)
        {
            alerts.AssertFieldsonSubmissionsWithAlertsPage(table);
        }

        //ActivityHistory
        [Given(@"User selects the Activity History Field from the dropdown menu of Submissions")]
        public void GivenUserSelectsTheActivityHistoryFieldFromTheDropdownMenuOfSubmissions()
        {
            activityHistory.ClickActivityHistory();
        }

        [Given(@"User validates the following Fields on Activity History Page")]
        public void GivenUserValidatesTheFollowingFieldsOnActivityHistoryPage(Table table)
        {
            activityHistory.AssertFieldsonActivityHistoryPage(table);
        }

        //Submission List 
        [Given(@"User selects the Submissions List Field from the dropdown menu of Submissions")]
        public void GivenUserSelectsTheSubmissionsListFieldFromTheDropdownMenuOfSubmissions()
        {
            submissionList.ClickSubmissionList();
        }

        [Given(@"User validates the following UI Controls on Submissions List Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnSubmissionsListPage(Table table)
        {
            submissionList.AssertUIControlsonSubmissionListPage(table);
        }
        [Given(@"User validates the following Fields on Submissions List Page")]
        public void GivenUserValidatesTheFollowingFieldsOnSubmissionsListPage(Table table)
        {
            submissionList.AssertFieldsonSubmissionListPage(table);
        }

        [Given(@"User clicks the Reassign Submission Icon on Submissions List Page")]
        public void GivenUserClicksTheReassignSubmissionIconOnSubmissionsListPage()
        {
            submissionList.ClickReassignSubmissionnButton();
        }
        [Given(@"User validates the following UI Controls on Reassign Submission Dialog")]
        public void GivenUserValidatesTheFollowingUIControlsOnReassignSubmissionDialog(Table table)
        {
            submissionList.AssertUIControlsonReassignSubmissionPage(table);
        }

        [Given(@"User clicks the Cancel Button on Reassign Submission Dialog")]
        public void GivenUserClicksTheCancelButtonOnReassignSubmissionDialog()
        {
            submissionList.ClickCancelButtononReassignSubmissionnDialog();
        }

        //New Case
        [Given(@"User clicks the New Case Button on Submissions List Page")]
        public void GivenUserClicksTheNewCaseButtonOnSubmissionsListPage()
        {
            submissionList.ClickNewCaseButton();

        }

        [Given(@"User enters ""([^""]*)"" in Transaction Method field on Dispute Submission Page")]
        public void GivenUserEntersInTransactionMethodFieldOnDisputeSubmissionPage(string value)
        {
            submissionList.EnterValueinTransactionMethodField("Debit Card");
        }

        [Given(@"User clicks the Fraud Button from Listed Transactions on Dispute Submission Page")]
        public void GivenUserClicksTheFraudButtonFromListedTransactionsOnDisputeSubmissionPage()
        {
            submissionList.ClickFruadRadioButton();
        }

        [Given(@"User clicks the Advanced Search Button on Dispute Submission Page")]
        public void GivenUserClicksTheAdvancedSearchButtonOnDisputeSubmissionPage()
        {
            submissionList.ClickAdvanceSearchButton();
        }

        [Given(@"User enters ""([^""]*)"" in the Customer Name field on Customer Search Page")]
        public void GivenUserEntersInTheCustomerNameFieldOnCustomerSearchPage(string value)
        {
            submissionList.EnterValueinCustomerFieldonCustomerSearchPage(value);
        }

        [Given(@"User clicksthe Search Button on Customer Search Page")]
        public void GivenUserClickstheSearchButtonOnCustomerSearchPage()
        {
            submissionList.ClickCustomerSearchButton();
        }

        [Given(@"User Selects the Customer from the Customers Dialog")]
        public void GivenUserSelectsTheCustomerFromTheCustomersDialog()
        {
            submissionList.ClickSelectCustomerButton();
        }

        [Given(@"User enters ""([^""]*)"" in Details on Dispute Submission Page")]
        public void GivenUserEntersInDetailsOnDisputeSubmissionPage(string value)
        {
            submissionList.EnterValueinDetailsTextareaonDisputeSubmissionPage(value);
        }

        [Given(@"User clicks the Additional Tasks on Dispute Submission Page")]
        public void GivenUserClicksTheAdditionalTasksOnDisputeSubmissionPage()
        {
            submissionList.ClickAdditionalTasksField();
        }

        [Given(@"User enters ""([^""]*)"" in Task Name field on Add Task Page")]
        public void GivenUserEntersInTaskNameFieldOnAddTaskPage(string value)
        {
            submissionList.EnterValueonAddTaskPage(value);
        }

        [Given(@"User clicks the Save Button on Add Task Page")]
        public void GivenUserClicksTheSaveButtonOnAddTaskPage()
        {
            submissionList.ClickSaveButtononAdditionalTasksField();
        }

        [Given(@"User clicks the Transaction List on Dispute Submission Page")]
        public void GivenUserClicksTheTransactionListOnDisputeSubmissionPage()
        {
            submissionList.ClickTransactionListField();
        }

        [Given(@"User Enters the following data on Add Transaction Page")]
        public void GivenUserEntersTheFollowingDataOnAddTransactionPage(Table table)
        {
            submissionList.EnterValueinFieldsonAddTransactionPage(table);
        }

        [Given(@"User clicks the Save Button on Add Transaction Page")]
        public void GivenUserClicksTheSaveButtonOnAddTransactionPage()
        {
            submissionList.ClickSaveButtononAddTransactionField();
        }

        [Given(@"User clicks the Next Button on Dispute Submission Page")]
        public void GivenUserClicksTheNextButtonOnDisputeSubmissionPage()
        {
            submissionList.ClickNextButton();
        }

        [Given(@"User clicks the Yes Button for Debit Card possession on Debit Card Dispute Form")]
        public void GivenUserClicksTheYesButtonForDebitCardPossessionOnDebitCardDisputeForm()
        {
            submissionList.ClickYesButtononDisputeForm();
        }

        [Given(@"User clicks the Yes Button for Stolen Card Report")]
        public void GivenUserClicksTheYesButtonForStolenCardReport()
        {
            submissionList.ClickYesButtonStolenCard();
        }

        [Given(@"User enters ""([^""]*)"" in Filed Date field")]
        public void GivenUserEntersInFiledDateField(string value)
        {
            submissionList.EnterValueinFiledDateField(value);
        }

        [Given(@"User enters ""([^""]*)""  in City Report Filed In field on Debit Card Dispute Form")]
        public void GivenUserEntersInCityReportFiledInFieldOnDebitCardDisputeForm(string value)
        {
            submissionList.EnterValueinCityReportField(value);
        }

       
        [Given(@"User clicks the Button for Check appropriate dispute reason")]
        public void GivenUserClicksTheButtonForCheckAppropriateDisputeReason()
        {
            submissionList.ClickDisputeReasonButton();
        }

        [Given(@"User clicks No Button for Card has been closed")]
        public void GivenUserClicksNoButtonForCardHasBeenClosed()
        {
            submissionList.ClickNoButtononDisputeForm();
        }

        [Given(@"User enters  ""([^""]*)"" in Date Card Closed on Debit Card Dispute Form")]
        public void GivenUserEntersInDateCardClosedOnDebitCardDisputeForm(string value)
        {
            submissionList.EnterValueinDateCardClosedField(value);
        }

        [Given(@"User clicks the Customer Signature form Button on Debit Card Dispute Form")]
        public void GivenUserClicksTheCustomerSignatureFormButtonOnDebitCardDisputeForm()
        {
            submissionList.ClickCustomerSignatureForm();
        }

        [Given(@"User clicks the Confirm Electronic Signautre Consent Button")]
        public void GivenUserClicksTheConfirmElectronicSignautreConsentButton()
        {
            submissionList.ClickElectronicSignatureConsentButton();
        }

        [Given(@"User clicks the Acknowledgment Button")]
        public void GivenUserClicksTheAcknowledgmentButton()
        {
            submissionList.ClickConsentCheckbox();
        }

        [Given(@"User clicks the Confirm Button")]
        public void GivenUserClicksTheConfirmButton()
        {
            submissionList.ClickConfirmButton();
        }
        [Given(@"User clicks in the Signature Field on Debit Card Dispute Form")]
        public void GivenUserClicksInTheSignatureFieldOnDebitCardDisputeForm()
        {
            submissionList.ClickSignatureTextarea();
        }

        [Given(@"User clicks the Acknowledge Button on Debit Card Dispute Form")]
        public void GivenUserClicksTheAcknowledgeButtonOnDebitCardDisputeForm()
        {
            submissionList.ClickAcknowldegeCheckbox();
        }

        [Given(@"User clicks the Done Button")]
        public void GivenUserClicksTheDoneButton()
        {
            submissionList.ClickDoneButton();
        }
        [Given(@"User validates the following Fields in Submission Info Dialog on Edit Submission Page")]
        public void GivenUserValidatesTheFollowingFieldsInSubmissionInfoDialogOnEditSubmissionPage(Table table)
        {
            Thread.Sleep(10000);
            submissionList.AssertFieldsonSubmissionsInfoPage(table);
        }

        [Given(@"User clicks the Questionnaire on Edit Submission Page")]
        public void GivenUserClicksTheQuestionnaireOnEditSubmissionPage()
        {
            submissionList.ClickQuestionaireButton();
        }

        [Given(@"User validates the following Fields in  Questionnaire Dialog")]
        public void GivenUserValidatesTheFollowingFieldsInQuestionnaireDialog(Table table)
        {
            submissionList.AssertFieldsonQuestionairePage(table);
        }

        [Given(@"User clicks the Forms on Edit Submission Page")]
        public void GivenUserClicksTheFormsOnEditSubmissionPage()
        {
            submissionList.ClickFormsButton();
        }

        [Given(@"User validates the following Fields in Forms Dialog")]
        public void GivenUserValidatesTheFollowingFieldsInFormsDialog(Table table)
        {
            submissionList.AssertFieldsonFormsPage(table);
        }

        [Given(@"User clicks the Disputes on Edit Submission Page")]
        public void GivenUserClicksTheDisputesOnEditSubmissionPage()
        {
            submissionList.ClickDisputesButton();
        }

        [Given(@"User validates the following Fields in Disputes Dialog")]
        public void GivenUserValidatesTheFollowingFieldsInDisputesDialog(Table table)
        {
            submissionList.AssertFieldsonDisputesPage(table);
        }

        //research comment out
        //[Given(@"User clicks the Research on Edit Submission Page")]
        //public void GivenUserClicksTheResearchOnEditSubmissionPage()
        //{
        //    submissionList.ClickResearchButton();
        //}

        //[Given(@"User validates the following Fields in Research Dialog")]
        //public void GivenUserValidatesTheFollowingFieldsInResearchDialog(Table table)
        //{
        //    submissionList.AssertFieldsonResearchPage(table);
        //}

        [Given(@"User clicks the Customer Status on Edit Submission Page")]
        public void GivenUserClicksTheCustomerStatusOnEditSubmissionPage()
        {
            submissionList.ClickCustomerStatusButton();
        }

        [Given(@"User validates the following Fields in Customer Status Dialog")]
        public void GivenUserValidatesTheFollowingFieldsInCustomerStatusDialog(Table table)
        {
            submissionList.AssertFieldsonCustomerStatusPage(table);
        }

        [Given(@"User clicks the Contacts on Edit Submission Page")]
        public void GivenUserClicksTheContactsOnEditSubmissionPage()
        {
            submissionList.ClickContactsButton();
        }

        [Given(@"User validates the following Fields in Contacts Dialog")]
        public void GivenUserValidatesTheFollowingFieldsInContactsDialog(Table table)
        {
            submissionList.AssertFieldsonContactsPage(table);
        }

        [Given(@"User clicks the GL Ledger on Edit Submission Page")]
        public void GivenUserClicksTheGLLedgerOnEditSubmissionPage()
        {
            submissionList.ClickGLLedgerButton();
        }

        [Given(@"User validates the following Fields in GL Ledger Dialog")]
        public void GivenUserValidatesTheFollowingFieldsInGLLedgerDialog(Table table)
        {
            submissionList.AssertFieldsonGLLedgerPage(table);
        }

        [Given(@"User clicks the Documents on Edit Submission Page")]
        public void GivenUserClicksTheDocumentsOnEditSubmissionPage()
        {
            submissionList.ClickDocumentButton();
        }

        [Given(@"User validates the following Fields in Documents Dialog")]
        public void GivenUserValidatesTheFollowingFieldsInDocumentsDialog(Table table)
        {
            submissionList.AssertFieldsonDocumentsPage(table);
        }

        //Provisional Credit log **
        [Given(@"User clicks the Provisional Credit Log Icon from the dropdown of Disputes Page")]
        public void GivenUserClicksTheProvisionalCreditLogIconFromTheDropdownOfDisputesPage()
        {
            creditLog.ClickProvisionalCreditLogButton();
        }

        [Given(@"User validates the following fields on the Provisional Credit Log Page")]
        public void GivenUserValidatesTheFollowingFieldsOnTheProvisionalCreditLogPage(Table table)
        {
            creditLog.AssertUIControlsOnProvisionalCreditLogPage(table);
        }

        //APPLYING ADD AND DELETE

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

        [Given(@"User validates the following fields on Add User Pool Page")]
        public void GivenUserValidatesTheFollowingFieldsOnAddUserPoolPage(Table table)
        {
            userPools.AssertFieldsOnAddPoolDialog(table);
        }

        [Given(@"User adds following data to respective fields")]
        public void GivenUserAddsFollowingDataToRespectiveFields(Table table)
        {
            userPools.AdddatatoFieldsonAddPoolDialog(table);
        }

        [Given(@"User clicks the Save Button on Add User Pool Page")]
        public void GivenUserClicksTheSaveButtonOnAddUserPoolPage()
        {
            userPools.ClickSaveButton();
        }

        [Given(@"User validates the total number of Action Fields on User Pools Process Page")]
        public void GivenUserValidatesTheTotalNumberOfActionFieldsOnUserPoolsProcessPage()
        {
            userPools.validateActionfields();
        }

        //users **
        [Given(@"User selects the Users Field from the dropdown menu of Profile Icon")]
        public void GivenUserSelectsTheUsersFieldFromTheDropdownMenuOfProfileIcon()
        {
            users.ClickUsers();
        }

        [Given(@"User validates the following UI Controls on Users Page")]
        public void GivenUserValidatesTheFollowingUIControlsOnUsersPage(Table table)
        {
            users.AssertUIControlsonUsersPage(table);
        }

        [Given(@"User clicks the Add User on Users Page")]
        public void GivenUserClicksTheAddUserOnUsersPage()
        {
            users.ClickAddUsers();
        }

        [Given(@"User validates the following fields on Add User Dialog")]
        public void GivenUserValidatesTheFollowingFieldsOnAddUserDialog(Table table)
        {
            users.AssertFieldsonAddUsersDialog(table);
        }

        [Given(@"User adds following data to respective fields on Add User Dialog")]
        public void GivenUserAddsFollowingDataToRespectiveFieldsOnAddUserDialog(Table table)
        {
            users.AdddatatoFieldsonAddUserDialog(table);
        }

        [Given(@"User clicks the Save Button on Add User Dialog")]
        public void GivenUserClicksTheSaveButtonOnAddUserDialog()
        {
            users.ClickSaveButtononAddUsers();
        }

        [Given(@"User validates the total number of Action Fields on Users Page")]
        public void GivenUserValidatesTheTotalNumberOfActionFieldsOnUsersPage()
        {
            users.validateActionfieldsonUserDialog();
        }

        [Given(@"User clicks the Dashboard Icon on Users Page")]
        public void GivenUserClicksTheDashboardIconOnUsersPage()
        {
            dashboard.ClickDashboard();
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

        [Given(@"User adds following data to respective fields on Add Process Transaction Setup Dialog")]
        public void GivenUserAddsFollowingDataToRespectiveFieldsOnAddProcessTransactionSetupDialog(Table table)
        {
            transactionProcess.AdddatatoFieldsOnAddTransactionProcessesDialog(table);
        }

        [Given(@"User clicks the Save Button on Add Process Transaction Setup Dialog")]
        public void GivenUserClicksTheSaveButtonOnAddProcessTransactionSetupDialog()
        {
            transactionProcess.ClickSaveButton();
        }

        [Given(@"User validates the total number of Action Fields on Transaction Process Page")]
        public void GivenUserValidatesTheTotalNumberOfActionFieldsOnTransactionProcessPage()
        {
            transactionProcess.validateActionfieldsonTransactionProcessPage();
        }

        //WorkflowSettings **
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

        [Given(@"User adds the following data to fields in Settings Page")]
        public void GivenUserAddsTheFollowingDataToFieldsInSettingsPage(Table table)
        {
            workflows.AddvaluesonEditWorkflowSettingDialog(table);
        }

        [Given(@"User validates the following Fields in Questionaire Dialog on Edit Setting Dialog")]
        public void GivenUserValidatesTheFollowingFieldsInQuestionaireDialogOnEditSettingDialog(Table table)
        {
            workflows.AssertFieldsOnQuestionaireDialog(table);
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

        [Given(@"User adds the following data to fields in Add Trigger Page on Edit Setting Dialog")]
        public void GivenUserAddsTheFollowingDataToFieldsInAddTriggerPageOnEditSettingDialog(Table table)
        {
            workflows.AddDatatofieldsOnAddTriggersDialog(table);
        }

        [Given(@"User clicks the Save Button on Add Trigger Page")]
        public void GivenUserClicksTheSaveButtonOnAddTriggerPage()
        {
            workflows.ClickSaveButtononAddTriggerDialog();
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

        [Given(@"User adds the following data to fields in Self-Service Verbiage Page")]
        public void GivenUserAddsTheFollowingDataToFieldsInSelf_ServiceVerbiagePage(Table table)
        {
            workflows.AddvaluesonSelfServiceVerbiagePage(table);
        }

        [Given(@"User clicks the Save Button on Self-Service Verbiage Page")]
        public void GivenUserClicksTheSaveButtonOnSelf_ServiceVerbiagePage()
        {
            workflows.ClickSaveButtononSelfVerbiage();
        }

        [Given(@"User validates the total number of Action Fields on Workflow Settings Page")]
        public void GivenUserValidatesTheTotalNumberOfActionFieldsOnWorkflowSettingsPage()
        {
            workflows.validateActionfieldsonWorkflowSettingsPage();
        }




    }
}
