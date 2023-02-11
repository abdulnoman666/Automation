using ExceptionTrackingAPITestAutomation.OpenItems;
using ExceptionTrackingEntities;
using FinboaAPITestAutomation;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ExceptionTrackingAPITestAutomation
{
    [TestFixture]
    class TestOpenItemsAPI
    {
        RestClient restClient = null;

        [OneTimeSetUp]
        public void Setup()
        {
            restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();

            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
        }

        [Test]
        public async Task Test_Get_Setting_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/exceptiondefinition/setting");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Company_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/company/");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Product_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/product/");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Checklist_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/checklist/");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [TestCase("1","15")]
        public async Task Test_Get_OpenException_On_Open_Items_Page(string pageNumber, string itemPerPage)
        {
            var request = HelperFunctions.CreateGetRequest("api/exception/openexceptions");

            request.AddParameter("pagenumber", pageNumber);
            request.AddParameter("itemsperpage", itemPerPage);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            /*var item = JsonConvert.DeserializeObject<Items>(response.Content);

            Assert.That(item.items.Count, Is.EqualTo(Int32.Parse(itemPerPage)), "Returned Exceptions per page are not equal");

            Assert.That(item.TotalCount, Is.GreaterThanOrEqualTo(100), "Total number of exceptions are not greator than and equal to 869");*/
        }

        [Test]
        public async Task Test_Get_Active_User_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/company/2/activeuser");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var activeUser = JsonConvert.DeserializeObject<OpenItems.ActiveUser>(response.Content);

            Assert.That(activeUser.Email, Is.EqualTo(TestLoginAPI.appUsername), "Username is not correct");

            Assert.That(activeUser.CompanyId, Is.EqualTo(2), "Company Id is not correct");

            Assert.That(activeUser.Role, Is.EqualTo("Manager"), "Role is not Manager");

        }

        [Test]
        public async Task Test_Get_App_User_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/appuser/");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var activeUsers = JsonConvert.DeserializeObject<List<OpenItems.ActiveUser>>(response.Content);

            Assert.That(activeUsers.Count, Is.GreaterThanOrEqualTo(0));

        }


        [Test]
        public async Task Test_Get_ActiveUser_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/company/2/activeuser");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var activeuser = JsonConvert.DeserializeObject<OpenItems.ActiveUser>(response.Content);

        }

        [Test]
        public async Task Test_Get_AppUser_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/appuser/");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        }

        [Test]
        public async Task Test_Get_GenerateReportTask_ExportOpenItems_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/exception/0/generatereporttask");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var GRT = JsonConvert.DeserializeObject<ExceptionTrackingEntities.GenerateReportTask>(response.Content);
            Assert.That(GRT.CompanyId, Is.EqualTo(2), "Company Id is not correct");
            Assert.That(GRT.CreatedBy, Is.EqualTo(98), "CreatedBy is not correct");
            Assert.That(GRT.OfficerId, Is.EqualTo(0), "OfficerId is not correct");
            Assert.That(GRT.UserId, Is.EqualTo(98), "UserId is not correct");
            Assert.That(GRT.Id, Is.GreaterThan(300), "Company Id is not correct");
            Assert.That(GRT.Code, Is.Not.Empty, "Company Id is not correct");
        }

        [TestCase("1", "15")]
        public async Task Test_Post_OpenExceptionFlaggedItem_On_Open_Items_Page(string pageNumber, string itemPerPage)
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var request = HelperFunctions.CreatePostRequest("api/exception/openexceptions?pagenumber=1&itemsperpage=15");
            request.AddParameter("pagenumber", pageNumber);
            request.AddParameter("itemsperpage", itemPerPage);
            request.AddParameter("flaggedItems", "true");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var exceptionData = JsonConvert.DeserializeObject<OpenItems.Items>(response.Content);

        }

        [TestCase("1", "15")]
        public async Task Test_Post_OpenExceptionAllItem_On_Open_Items_Page(string pageNumber, string itemPerPage)
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var request = HelperFunctions.CreatePostRequest("api/exception/openexceptions?pagenumber=1&itemsperpage=15");
            request.AddParameter("pagenumber", pageNumber);
            request.AddParameter("itemsperpage", itemPerPage);
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var exceptionData = JsonConvert.DeserializeObject<OpenItems.Items>(response.Content);

        }

        [TestCase("1", "15")]
        public async Task Test_Post_OpenExceptionSearchText_On_Open_Items_Page(string pageNumber, string itemPerPage)
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var request = HelperFunctions.CreatePostRequest("api/exception/openexceptions?pagenumber=1&itemsperpage=15");
            request.AddParameter("pagenumber", pageNumber);
            request.AddParameter("itemsperpage", itemPerPage);
            request.AddParameter("searchText", "mjata");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var exceptionData = JsonConvert.DeserializeObject<OpenItems.Items>(response.Content);

        }
         
         [TestCase("1", "15")]
         public async Task Test_Post_OpenExceptionSearchFilter_On_Open_Items_Page(String pageNumber, String itemPerPage)
         {
             var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
             restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
             var request = HelperFunctions.CreatePostRequest("api/exception/openexceptions?pagenumber=1&itemsperpage=15");
            request = RequestHelperForET.CreateOpenExceptionSearchFilterRequest(request,1,15, "createdDate,createdOn", "2022-01-01", "2022-09-09", "99", "2022-09-09", "2022-01-01", "28,13", "3,53");
            // var jsonBody = HelperFunctions.ReadJsonBody("JSONFiles\\ETOpenItemsFilter.json");
            /* request.AddJsonBody(new
             {
                 pagenumber= 1,
                 itemsperpage= 15,
                 searchBy= "createdDate,createdOn",
                 startDate= "2022-01-01",
                 endDate= "2022-09-09",
                 checklistId= "99",
                 lastActivityEndDate= "2022-09-09",
                 lastActivityStartDate= "2022-01-01",
                 productId= "28,13",
                 userId= "3,53"
             });
            */
           
            // request.AddParameter("pagenumber", pageNumber);
            // request.AddParameter("itemsperpage", itemPerPage);

            var response = await restClient.ExecuteAsync(request);
             Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
          // var exceptionData = JsonConvert.DeserializeObject<OpenItems.Items>(response.Content);

         }
        
        [TestCase("1", "15")]
        public async Task Test_Post_OpenExceptionFilterReset_On_Open_Items_Page(string pageNumber, string itemPerPage)
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var request = HelperFunctions.CreatePostRequest("api/exception/openexceptions?pagenumber=1&itemsperpage=15");
            request.AddParameter("pagenumber", pageNumber);
            request.AddParameter("itemsperpage", itemPerPage);
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var exceptionData = JsonConvert.DeserializeObject<OpenItems.Items>(response.Content);

        }

        [Test]
        public async Task Test_Get_GenerateReportTask_ExportClearedItems_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/exception/0/generatereporttask");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var GRT = JsonConvert.DeserializeObject<ExceptionTrackingEntities.GenerateReportTask>(response.Content);
            Assert.That(GRT.CompanyId, Is.EqualTo(2), "Company Id is not correct");
            Assert.That(GRT.CreatedBy, Is.EqualTo(98), "CreatedBy is not correct");
            Assert.That(GRT.OfficerId, Is.EqualTo(0), "OfficerId is not correct");
            Assert.That(GRT.UserId, Is.EqualTo(98), "UserId is not correct");
            Assert.That(GRT.Id, Is.GreaterThan(300), "Company Id is not correct");
            Assert.That(GRT.Code, Is.Not.Empty, "Company Id is not correct");
        }

        [Test]
        public async Task Test_Get_Notes_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/exception/459/notes");
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

           
        }

        [TestCase("1871")]
        public async Task Test_Get_MarkAnItemFlag_On_Open_Items_Page(string exceptionID)
        {
            string requeststring = "api/bankaccount/5/flagexception/" + exceptionID;
            var request = HelperFunctions.CreateGetRequest(requeststring);
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var responseData = JsonConvert.DeserializeObject<ExceptionTrackingEntities.FlagExceptionItemResponce>(response.Content);
        }

        [TestCase("1871")]
        public async Task Test_Get_MarkAnItemUnFlag_On_Open_Items_Page(string exceptionID)
        {
            string requeststring = "api/bankaccount/5/unflagexception/" + exceptionID;
            var request = HelperFunctions.CreateGetRequest(requeststring);
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var responseData = JsonConvert.DeserializeObject<ExceptionTrackingEntities.FlagExceptionItemResponce>(response.Content);
        }

        [TestCase("1871")]
        public async Task Test_Get_MarkClearException_On_Open_Items_Page(string exceptionID)
        {
            string requeststring = "api/bankaccount/5/clearexception/" + exceptionID;
            var request = HelperFunctions.CreateGetRequest(requeststring);
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var responseData = JsonConvert.DeserializeObject<ExceptionTrackingEntities.FlagExceptionItemResponce>(response.Content);
        }

        [TestCase("617")]
        public async Task Test_Post_AddNoteToAnException_On_Open_Items_Page(string ExceptionNote)
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            string requeststring = "api/exception/"+ ExceptionNote + "/addnote";
            var request = HelperFunctions.CreatePostRequest(requeststring);
            request.AddParameter("description", "Note Added by API Automation");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var responseData = JsonConvert.DeserializeObject<ExceptionTrackingEntities.AddedNoteResponse>(response.Content);
        }

        [TestCase("617")]
        public async Task Test_Post_DeleteNoteToAnException_On_Open_Items_Page(string ExceptionNote)
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            string addrequeststring = "api/exception/" + ExceptionNote + "/addnote";
            var request = HelperFunctions.CreatePostRequest(addrequeststring);
            request.AddParameter("description", "Note Added by API Automation");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var responseData = JsonConvert.DeserializeObject<ExceptionTrackingEntities.AddedNoteResponse>(response.Content);
            
            string DeleteRequestString = "api/exception/" + ExceptionNote + "/deletenote";
            var request2 = HelperFunctions.CreatePostRequest(DeleteRequestString);
            request2.AddParameter("companyId", responseData.CompanyId);
            request2.AddParameter("createdBy", responseData.CreatedBy);
            request2.AddParameter("createdOn", responseData.CreatedOn);
            request2.AddParameter("description", responseData.Description);
            request2.AddParameter("id", responseData.Id);
            request2.AddParameter("objectId", responseData.ObjectId);
            request2.AddParameter("objectType", responseData.ObjectType);
            var response2 = await restClient.ExecuteAsync(request2);
            Assert.That(response2.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var responseData2 = JsonConvert.DeserializeObject<List<ExceptionTrackingEntities.AddedNoteResponse>>(response2.Content);
        }


        [TestCase("624")]
        public async Task Test_Post_AssignExceptionTo_On_Open_Items_Page(string Id)
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            string requeststring = "api/exception/"+ Id + "/assignto";
            var request = HelperFunctions.CreatePostRequest(requeststring);
            request.AddParameter("Id", "45");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [TestCase("790", "Note added by Automation Script")]
        public async Task Test_Post_UpdateExpirationDate_On_Open_Items_Page(string Id, string Note)
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            string RequestStringForDate = "api/exception/" + Id + "/updateexpirationdate";
            var requestForDate = HelperFunctions.CreatePostRequest(RequestStringForDate);
            DateTime date = new DateTime();
            requestForDate.AddParameter("expirationDate", date);
            var responseForDate = await restClient.ExecuteAsync(requestForDate);
            Assert.That(responseForDate.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            string RequestStringForNote = "api/exception/" + Id + "/addnote";
            var requestForNote = HelperFunctions.CreatePostRequest(RequestStringForNote);
            requestForNote.AddParameter("description", Note);
            var responseForNote = await restClient.ExecuteAsync(requestForNote);
            Assert.That(responseForNote.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [TestCase("790", "Note added by Automation Script On Reset")]
        public async Task Test_Post_UpdateExpirationDateReset_On_Open_Items_Page(string Id, string Note)
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            string RequestStringForDate = "api/exception/" + Id + "/updateexpirationdate";
            var requestForDate = HelperFunctions.CreatePostRequest(RequestStringForDate);

            requestForDate.AddParameter("expirationDate", "null");
            var responseForDate = await restClient.ExecuteAsync(requestForDate);
            Assert.That(responseForDate.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            string RequestStringForNote = "api/exception/" + Id + "/addnote";
            var requestForNote = HelperFunctions.CreatePostRequest(RequestStringForNote);
            requestForNote.AddParameter("description", Note);
            var responseForNote = await restClient.ExecuteAsync(requestForNote);
            Assert.That(responseForNote.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
