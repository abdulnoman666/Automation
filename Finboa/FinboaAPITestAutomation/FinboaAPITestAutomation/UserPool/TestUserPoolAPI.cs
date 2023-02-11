using System.Net;
using System.Threading.Tasks;
using FinboaAPITestAutomation.UserPool;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;

namespace FinboaAPITestAutomation
{
    internal class TestUserPoolAPI
    {
        RestClient restClient = null;
        int companyId = 2;
        string groupName = "TestPoolUpdated";
        int id = 0;
        string reference = "PoolRefUpdated";
        string user = string.Empty;

        [Test]
        public async Task Test_Get_User_Pool_On_User_Pools_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/userpool.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Add_User_Pools_On_User_Pools_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/adduserpool.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Show_User_Pools_On_User_Pools_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/showUsers.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_User_Pools_On_User_Pools_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/userpools/");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_User_Pools_By_Id_On_User_Pools_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/userpools/1");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Add_User_Pools_On_User_Pools_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/userpools/");

            request.AddParameter("companyId", companyId);
            request.AddParameter("groupName", "Test Pool 1");
            request.AddParameter("reference", "PoolRef1");
            request.AddParameter("Users", "80");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = JsonConvert.DeserializeObject<UserPools>(response.Content);

            id = output.Id;
        }

        [Test, Order(2)]
        public async Task Test_Post_Update_User_Pools_On_User_Pools_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/userpools/");

            request.AddParameter("companyId", companyId);
            request.AddParameter("groupName", groupName);
            request.AddParameter("id", id);
            request.AddParameter("reference", reference);
            request.AddParameter("Users", "105");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = JsonConvert.DeserializeObject<UserPools>(response.Content);

            Assert.That(groupName, Is.EqualTo(output.GroupName), "Group Name does not match");
            Assert.That(reference, Is.EqualTo(output.Reference), "Reference of User Pool does not match");
        }

        [Test, Order(3)]
        public async Task Test_Post_Delete_User_Pools_On_User_Pools_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/userpools/delete");

            request.AddParameter("companyId", companyId);
            request.AddParameter("groupName", groupName);
            request.AddParameter("id", id);
            request.AddParameter("reference", reference);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
