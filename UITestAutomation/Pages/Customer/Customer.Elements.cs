using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class Customer
    {
        //Controls on customerPage
        By AddCustomer_Button = By.CssSelector("button[title='Add Customer']");
        By Search_Button = By.CssSelector("button[title='Search and set date range']");
        By Links_Field = By.XPath("//th[.='Links']");
        By Id_Field = By.XPath("//th[.='Id']");
        By CustomerName_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[3]");
        By CardNumber_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[4]");
        By AccountType_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[5]");
        By Account_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[6]");
        By MainPhone_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[7]");
        By Email_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[8]");

        //Fields on Add customer button
        By ID_Label = By.XPath("//customerform[@name='customerForm']/form[@name='customerForm']//label[.='ID: ']");
        By CardholderName_Textbox = By.CssSelector("form[name='customerForm'] input[name='name']");
        By CoreCustomerKey_Textbox = By.CssSelector("form[name='customerForm'] input[name='cifNumber']");
        By CardNumber_Textbox = By.CssSelector("form[name='customerForm'] input[name='cardNumber']");
        By Account_Textbox = By.CssSelector("form[name='customerForm'] input[name='account']");
        By AccountStatus_Textbox = By.CssSelector("form[name='customerForm'] input[name='accountStatus']");
        By AccountType_Dropdown = By.CssSelector("form[name='customerForm'] > div:nth-of-type(7) > .col-lg-8 > select[name='source']");
        By CustomerType_Dropdown = By.XPath("//customerform[@name='customerForm']/form[@name='customerForm']/div[8]/div[@class='col-lg-8']/select");
        By Branch_Dropdown = By.XPath("//customerform[@name='customerForm']/form[@name='customerForm']/div[9]/div[@class='col-lg-8']/select[@name='source']");
        By CharterBranding_Dropdown = By.XPath("//customerform[@name='customerForm']/form[@name='customerForm']/div[10]/div[@class='col-lg-8']/select[@name='source']");
        By MobilePhone_Textbox = By.CssSelector("form[name='customerForm'] > div:nth-of-type(11) > .col-lg-8 > input[name='phone']");
        By HomePhone_Textbox = By.CssSelector("form[name='customerForm'] > div:nth-of-type(12) > .col-lg-8 > input[name='phone']");
        By OfficePhone_Textbox = By.CssSelector("form[name='customerForm'] > div:nth-of-type(13) > .col-lg-8 > input[name='phone']");
        By Email_Textbox = By.CssSelector("form[name='customerForm'] input[name='email']");
        By StatementCycleDay_Count = By.CssSelector("form[name='customerForm'] input[name='cycleDay']");
        By StatementCycleCode_Textbox = By.CssSelector("form[name='customerForm'] input[name='cycleDayString']");
        By StatementDate_Checkbox = By.CssSelector("form[name='customerForm'] input[name='statementDate']");
        By Address_Textbox = By.CssSelector("form[name='customerForm'] input[name='address']");
        By CloseAddCustomer_Button = By.CssSelector("div#addCustomer  .modal-content  .btn.btn-default");
        By SaveAddCustomer_Button = By.CssSelector("[ng-click='addCustomer\\(form\\)']");

        //Fields on search button
        By CustomerName_Textbox = By.CssSelector("form[name='dateFilterForm'] > input[name='customerName']");
        By FullCardNumber_Textbox = By.CssSelector("form[name='dateFilterForm'] > input[name='cardNumber']");
        By FullAccountNumber_Textbox = By.CssSelector("form[name='dateFilterForm'] > input[name='account']");
        By Reset_Button = By.CssSelector("[ng-click='resetSearchFields\\(\\)']");
        By search_Button = By.XPath("//button[@ng-click=\"searchCustomer()\"]");
        By Close_Button = By.XPath("/html//div[@id='dateSearch']//div[@class='modal-footer']/button[3]");

        //fields after search customer
        By EditCustomerDetails_Button = By.XPath("//button[@title='Edit Customer Details']");
        By CustomerDocuments_Button = By.XPath("//button[@title='Customer Documents']");
        By CopyCustomerRecord_Button = By.XPath("//button[@title='Copy Customer Record']");
        By ViewTransactions_Button = By.XPath("//button[@title='View Transactions']");
        By PrintLetter_Button = By.XPath("//button[@title='Print Letter']");

        //Transactionbutton fields
        By From_Field = By.CssSelector("md-datepicker[name='startDate'] > .md-datepicker-input-container > .md-datepicker-input");
        By To_Field = By.CssSelector("md-datepicker[name='endDate'] > .md-datepicker-input-container > .md-datepicker-input");
        By LoadTransactions_Button = By.CssSelector("[ng-click='loadTransactions\\(\\)']");
        By Search_Textbox = By.CssSelector("input[name='searchFor']");
        By IdTransaction_Field = By.CssSelector("tr [width='30px']:nth-of-type(1)");
        By Date_Field = By.CssSelector("[width='100px']");
        By Description_Field = By.CssSelector("[width='65px']");
        By Amount_Field = By.CssSelector("[width='50px']");
        By TransactionCode_Field = By.CssSelector("[width='120px']");
        By Pos_Field = By.CssSelector("tr [width='30px']:nth-of-type(6)");
        By CloseTransaction_Button = By.CssSelector("[ng-click='close\\(\\)']");

        //Document Manager controls
        By DownloadDocument_Button = By.XPath("//button[@title='Download Document']");
        By gotoPage_Button = By.XPath("//button[@ng-click=\"gotoPage(1)\"]");
        By prevPage_Button = By.XPath("//button[@ng-click=\"prevPage()\"]");
        By nextPages_Button = By.XPath("//button[@ng-click=\"nextPage()\"]");
        By total_Pages = By.XPath("//button[@ng-click=\"gotoPage(totalPages)\"]");
        By Rotate_Button = By.XPath("//button[@ng-click=\"rotate()\"]");
        By Print_Button = By.XPath("//button[@ng-click=\"printIt()\"]");


        //Edit Customer
        By IDEdit_Label = By.XPath("//div[@id='editCustomer']//form[@name='addCutomerForm']//div[@class='modal-body']/customerform//label[.='ID: ']");
        By EditCardholderName_Textbox = By.XPath("//form[@name='addCutomerForm']//div[@class='modal-body']/customerform//input[@name='name']");
        By EditCoreCustomerKey_Textbox = By.XPath("//form[@name='addCutomerForm']//div[@class='modal-body']/customerform//input[@name='cifNumber']");
        By EditCardNumber_Textbox = By.CssSelector("#main [role='dialog']:nth-of-type(4) .row:nth-of-type(4) [type]");
        By EditAccount_Textbox = By.CssSelector("#main .row:nth-of-type(5) .ng-valid-required");
        By EditAccountStatus_Textbox = By.CssSelector("#main .row:nth-of-type(6) .ng-not-empty");
        By EditAccountType_Dropdown = By.XPath("//form[@name='addCutomerForm']//div[@class='modal-body']/customerform/div[7]/div[@class='col-lg-8']/select[@name='source']");
        By EditCustomerType_Dropdown = By.XPath("//div[@class='modal-body']/customerform/div[8]/div[@class='col-lg-8']/select");
        By EditBranch_Dropdown = By.XPath("//div[@class='modal-body']/customerform/div[9]/div[@class='col-lg-8']/select[@name='source']");
        By EditCharterBranding_Dropdown = By.XPath("//customerform/div[10]/div[@class='col-lg-8']/select[@name='source']");
        By EditMobilePhone_Textbox = By.XPath("//div[@class='modal-body']/customerform/div[11]/div[@class='col-lg-8']/input[@name='phone']");
        By EditHomePhone_Textbox = By.CssSelector("#main .row:nth-of-type(12) .ng-not-empty");
        By EditOfficePhone_Textbox = By.CssSelector("#main .row:nth-of-type(13) .ng-not-empty");
        By EditEmail_Textbox = By.CssSelector("#main [role='dialog']:nth-of-type(4) .row:nth-of-type(14) [type]");
        By EditStatementCycleDay_Count = By.CssSelector("#main .row:nth-of-type(15) .ng-valid-required");
        By EditStatementCycleCode_Textbox = By.CssSelector("#main .row:nth-of-type(16) .ng-not-empty");
        By EditStatementDate_Checkbox = By.XPath("//form[@name='addCutomerForm']//div[@class='modal-body']/customerform//input[@name='statementDate']");
        By EditAddress_Textbox = By.CssSelector("#main .row:nth-of-type(18) .ng-valid-required");
        By EditClose_Button = By.CssSelector("form[name='addCutomerForm'] .btn.btn-default");
        By EditUpdate_Button = By.CssSelector("#main [role='dialog']:nth-of-type(4) [ng-click='saveEditedCustomer\\(\\)']");

    }
}
