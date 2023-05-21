using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class Customer
    {
        //Controls on customerPage
        By AddCustomer_Button = By.XPath("//button[@title=\"Add Customer\"]");
        By Search_Button = By.XPath("//button[@title=\"Search and set date range\"]");
        By Links_Field = By.XPath("//th[.='Links']");
        By Id_Field = By.XPath("//th[.='Id']");
        By CustomerName_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[3]");
        By CardNumber_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[4]");
        By AccountType_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[5]");
        By Account_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[6]");
        By MainPhone_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[7]");
        By Email_Field = By.XPath("//div[@class='panel panel-primary']//table//tr/th[8]");

        //Fields on Add customer button
        By ID_Label = By.XPath("(//label[text()=\"ID: \"])[1]");
        By CardholderName_Textbox = By.XPath("(//input[@ng-model=\"customer.name\"])[1]");
        By CoreCustomerKey_Textbox = By.XPath("(//input[@ng-model=\"customer.cifNumber\"])[1]");
        By CardNumber_Textbox = By.XPath("(//input[@ng-model=\"customer.cardNumber\"])[1]");
        By Account_Textbox = By.XPath("(//input[@ng-model=\"customer.account\"])[1]");
        By AccountStatus_Textbox = By.XPath("(//input[@ng-model=\"customer.accountStatus\"])[1]");
        By AccountType_Dropdown = By.XPath("(//select[@ng-model=\"customer.accountType\"])[1]");
        By CustomerType_Dropdown = By.XPath("(//select[@ng-model=\"customer.accountOwnershipType\"])[1]");
        By Branch_Dropdown = By.XPath("(//select[@ng-model=\"customer.branch\"])[1]");
        By CharterBranding_Dropdown = By.XPath("(//select[@ng-model=\"customer.charter\"])[1]");
        By MobilePhone_Textbox = By.XPath("(//input[@ng-model=\"customer.phone\"])[1]");
        By HomePhone_Textbox = By.XPath("(//input[@ng-model=\"customer.homePhone\"])[1]");
        By OfficePhone_Textbox = By.XPath("(//input[@ng-model=\"customer.officePhone\"])[1]");
        By Email_Textbox = By.XPath("(//input[@ng-model=\"customer.email\"])[1]");
        By StatementCycleDay_Count = By.XPath("(//input[@ng-model=\"customer.cycleDay\"])[1]");
        By StatementCycleCode_Textbox = By.XPath("(//input[@ng-model=\"customer.cycleDayString\"])[1]");
        By StatementDate_Checkbox = By.XPath("(//input[@ng-model=\"customer.nextBusinessDayStatement\"])[1]");
        By Address_Textbox = By.XPath("(//input[@ng-model=\"customer.address\"])[1]");
        By CloseAddCustomer_Button = By.XPath("(//button[@type=\"button\"])[6]");
        By SaveAddCustomer_Button = By.XPath("//button[@class=\"btn btn-info\"]");

        //Fields on search button
        By CustomerName_Textbox = By.XPath("//input[@ng-model=\"search.customerName\"]");
        By FullCardNumber_Textbox = By.XPath("//input[@ng-model=\"search.cardNumber\"]");
        By FullAccountNumber_Textbox = By.XPath("//input[@ng-model=\"search.account\"]");
        By Reset_Button = By.XPath("//button[@ng-click=\"resetSearchFields()\"]");
        By search_Button = By.XPath("//button[@ng-click=\"searchCustomer()\"]");
        By Close_Button = By.XPath("(//button[@class=\"btn btn-default\"])[10]");

        //fields after search customer
        By EditCustomerDetails_Button = By.XPath("//button[@title='Edit Customer Details']");
        By CustomerDocuments_Button = By.XPath("//button[@title='Customer Documents']");
        By CopyCustomerRecord_Button = By.XPath("//button[@title='Copy Customer Record']");
        By ViewTransactions_Button = By.XPath("//button[@title='View Transactions']");
        By PrintLetter_Button = By.XPath("//button[@title='Print Letter']");

        //Transactionbutton fields
        By From_Field = By.XPath("(//input[@class=\"md-datepicker-input\"])[1]");
        By FromCalenderCust_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[1]");
        By FromDownArrowCust_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[2]");
        By To_Field = By.XPath("(//input[@class=\"md-datepicker-input\"])[2]");
        By ToCalenderCust_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[3]");
        By ToDownArrowCust_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[4]");

        By LoadTransactions_Button = By.XPath("//button[@ng-click=\"loadTransactions()\"]");
        By Search_Textbox = By.XPath("//input[@ng-model=\"search.searchFor\"]");
        By IdTransaction_Field = By.XPath("(//th[1])[1]");
        By Date_Field = By.XPath("(//th[2])[1]");
        By Description_Field = By.XPath("(//th[3])[1]");
        By Amount_Field = By.XPath("(//th[4])[1]");
        By TransactionCode_Field = By.XPath("(//th[5])[1]");
        By Pos_Field = By.XPath("(//th[6])[1]");
        By CloseTransaction_Button = By.XPath("(//button[@ng-click=\"close()\"])[1]");

        //Document Manager controls
        By DownloadDocument_Button = By.XPath("//button[@title='Download Document']");
        By gotoPage_Button = By.XPath("//button[@ng-click=\"gotoPage(1)\"]");
        By prevPage_Button = By.XPath("//button[@ng-click=\"prevPage()\"]");
        By nextPages_Button = By.XPath("//button[@ng-click=\"nextPage()\"]");
        By total_Pages = By.XPath("//button[@ng-click=\"gotoPage(totalPages)\"]");
        By Rotate_Button = By.XPath("//button[@ng-click=\"rotate()\"]");
        By Print_Button = By.XPath("//button[@ng-click=\"printIt()\"]");


        //Edit Customer
        By IDEdit_Label = By.XPath("(//label[text()=\"ID: \"])[2]");
        By EditCardholderName_Textbox = By.XPath("(//input[@ng-model=\"customer.name\"])[2]");
        By EditCoreCustomerKey_Textbox = By.XPath("(//input[@ng-model=\"customer.cifNumber\"])[2]");
        By EditCardNumber_Textbox = By.XPath("(//input[@ng-model=\"customer.cardNumber\"])[2]");
        By EditAccount_Textbox = By.XPath("(//input[@ng-model=\"customer.account\"])[2]");
        By EditAccountStatus_Textbox = By.XPath("(//input[@ng-model=\"customer.accountStatus\"])[2]");      
        By EditAccountType_Dropdown = By.XPath("(//select[@ng-model=\"customer.accountType\"])[2]");      
        By EditCustomerType_Dropdown = By.XPath("(//select[@ng-model=\"customer.accountOwnershipType\"])[2]");
        By EditBranch_Dropdown = By.XPath("(//select[@ng-model=\"customer.branch\"])[2]");
        By EditCharterBranding_Dropdown = By.XPath("(//select[@ng-model=\"customer.charter\"])[2]");
        By EditMobilePhone_Textbox = By.XPath("(//input[@ng-model=\"customer.phone\"])[2]");
        By EditHomePhone_Textbox = By.XPath("(//input[@ng-model=\"customer.homePhone\"])[2]");
        By EditOfficePhone_Textbox = By.XPath("(//input[@ng-model=\"customer.officePhone\"])[2]");
        By EditEmail_Textbox = By.XPath("(//input[@ng-model=\"customer.email\"])[2]");
        By EditStatementCycleDay_Count = By.XPath("(//input[@ng-model=\"customer.cycleDay\"])[2]");
        By EditStatementCycleCode_Textbox = By.XPath("(//input[@ng-model=\"customer.cycleDayString\"])[2]");
        By EditStatementDate_Checkbox = By.XPath("(//input[@ng-model=\"customer.nextBusinessDayStatement\"])[2]");
        By EditAddress_Textbox = By.XPath("(//input[@ng-model=\"customer.address\"])[2]");
        By EditClose_Button = By.XPath("(//button[@class=\"btn btn-default\"])[5]");
        By EditUpdate_Button = By.XPath("(//button[@ng-click=\"saveEditedCustomer()\"])[1]");

    }
}
