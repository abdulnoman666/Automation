using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestLetterTemplatesAPI
    {
        RestClient restClient = null;
        string id = string.Empty;

        [Test]
        public async Task Test_Get_Letter_on_Letter_Templates_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/letter");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Template_Object_on_Letter_Templates_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/letter");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Letter_Action_on_Letter_Templates_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/letter/0/letteractions");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Fee_Reimbursement_On_Letter_Templates_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/letterlist.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_View_Letter_On_Letter_Templates_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/viewletter.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Create_Letter_Template_On_Letter_Templates_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/letter");

            request = RequestHelper.CreateLetterTemplateRequest(request, "Author", true, "Description", true, "FileName", true, "LT", "Subject Line", "Customers", "Title", true);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
        }

        [Test, Order(2)]
        public async Task Test_Get_Delete_Letter_Template_On_Letter_Templates_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest($"api/letter/{id}/deleteletter");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(3)]
        public async Task Test_Get_Copy_Letter_Template_On_Letter_Templates_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request1 = HelperFunctions.CreateGetRequest($"api/letter/5/copy");

            var response1 = await restClient.ExecuteAsync(request1);

            Assert.That(response1.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response1);

            id = output["id"];

            var request2 = HelperFunctions.CreateGetRequest($"api/letter/{id}/deleteletter");

            var response2 = await restClient.ExecuteAsync(request2);

            Assert.That(response2.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
