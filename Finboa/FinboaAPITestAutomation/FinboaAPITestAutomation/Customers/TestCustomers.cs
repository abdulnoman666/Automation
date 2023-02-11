using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestCustomers
    {
        RestClient restClient = null;

        [Test]
        public async Task Test_Get_Customer_List_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/customerlist.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Customer_Form_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/partials/customerform.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Customer_Search_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customer/0/search?redacted=false");

            request.AddParameter("customerName", "singal");
            //request.AddParameter("text/json", "{\"customerName\":\"singal\"}", ParameterType.RequestBody);

            //request.AddParameter("customerName", "singal");

            //JsonTextReader reader = new JsonTextReader(new StreamReader("D:\\Finboa\\FinboaProject\\FinboaAPITestAutomation\\FinboaAPITestAutomation\\JSONData\\AddCustomer.txt"));

            //request.AddJsonBody(reader);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Transactions_Search_List_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customer/2/transactionsearchlist");

            //request.AddParameter("reportedOnDateEnd", "2022-09-11");

            //request.AddParameter("reportedOnDateStart", "2020-01-01");

            var jsonData = HelperFunctions.ReadJsonBody("JSONData\\SearchTransactionsList.json");

            request.AddParameter(jsonData, ParameterType.RequestBody);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Add_New_Customer_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customer");

            request = RequestHelper.CreateCustomerRequest(request, "3698369836983698", "Business", "Open", "DDA", "House P-1105", "Branch 1", "3698369836983698", "NOMAN",
                "3698", "RWP", 0, "0", "abdul@finboa.com", "051", "Automated Tester 1", true, "042", "0332", "PUN", "46000");

            /*request.AddJsonBody(new {
                account = "3698369836983698",
                accountOwnershipType = "Business",
                accountStatus = "Open",
                accountType = "DDA",
                address = "House P-1105",
                branch = "Branch 1",
                cardNumber = "3698369836983698",
                charter = "NOMAN",
                cifNumber = "3698",
                city = "RWP",
                cycleDay = 0,
                cycleDayString = "0",
                email = "abdul@finboa.com",
                homePhone = "051",
                name = "Automated Tester 1",
                nextBusinessDayStatement = true,
                officePhone = "042",
                phone = "0332",
                state = "PUN",
                zip = "46000"
            });*/

            var response = await TestLoginAPI.globalRestClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Company_Settings_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/companysetting");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Document_Manager_Viewer_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/document/viewer.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Document_Manager_Documents_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/document/documents.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Document_Manager_Date_Picker_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOADirectives/fidatepicker.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Document_Manager_File_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/company/2/customer/2/file");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Document_Manager_Generate_Report_Task_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/customer/2/generatereporttask");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Download_Document_On_Document_Manager_On_Customer_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/customer/2/downloaddocument/32");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
