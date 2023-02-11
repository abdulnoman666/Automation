using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    class TestUsersAPI
    {
        RestClient restClient = null;
        string id = string.Empty;
        string email = string.Empty;
        string firstName = "First Name";
        string lastName = "Last Name";
        bool hasAccount = false;
        string mobilePhone = "03325166674";
        string role = "Manager";
        int lastCompanyId = 2;
        string companyId = string.Empty;
        string isDeleted = string.Empty;
        string roleChanged = string.Empty;
        string status = string.Empty;
        string systemRole = string.Empty;
        string title = string.Empty;
        string uniqueId = string.Empty;
        string changePassword = string.Empty;

        [Test]
        public async Task Test_Get_Company_Users_On_Users_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/company/users");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Company_Users_On_Users_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/appuser");

            var rnd = new Random();
            var i = rnd.Next(0, 1000);
            email = $"AutomatedUser{i}@Automation.com";

            request.AddParameter("email", email);
            request.AddParameter("firstName", firstName);
            request.AddParameter("hasAccount", hasAccount);
            request.AddParameter("lastCompanyId", lastCompanyId);
            request.AddParameter("lastName", lastName);
            request.AddParameter("mobilePhone", mobilePhone);
            request.AddParameter("role", role);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            isDeleted = output["isDeleted"];
            roleChanged = output["roleChanged"];
            status = output["status"];
            systemRole = output["systemRole"];
            changePassword = output["changePassword"];
            companyId = output["companyId"];
            email = output["email"];
        }

        [Test, Order(2)]
        public async Task Test_Post_Reset_User_Lockout_On_Users_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/useraccount/resetuserlockout");

            request.AddParameter("changePassword", true);
            request.AddParameter("companyId", companyId);
            request.AddParameter("email", "AR@finboa.com");
            request.AddParameter("firstName", "Auditor Role");
            request.AddParameter("hasAccount", true);
            request.AddParameter("id", 98);
            request.AddParameter("isDeleted", false);
            request.AddParameter("lastName", "Test");
            request.AddParameter("mobilePhone", "");
            request.AddParameter("role", "Auditor");
            request.AddParameter("roleChanged", false);
            request.AddParameter("status", false);
            request.AddParameter("systemRole", "User");
            request.AddParameter("title", "");
            request.AddParameter("uniqueId", "");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(3)]
        public async Task Test_Post_Reset_User_Password_On_Users_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/useraccount/resetuserpassword");

            request.AddParameter("changePassword", true);
            request.AddParameter("companyId", companyId);
            request.AddParameter("confirmPassword", "Password@1");
            request.AddParameter("email", "AR@finboa.com");
            request.AddParameter("firstName", "Auditor Role");
            request.AddParameter("hasAccount", true);
            request.AddParameter("id", 98);
            request.AddParameter("isDeleted", false);
            request.AddParameter("lastName", "Test");
            request.AddParameter("mobilePhone", "");
            request.AddParameter("newPassword", "Password@1");
            request.AddParameter("password", "na");
            request.AddParameter("role", "Auditor");
            request.AddParameter("roleChanged", false);
            request.AddParameter("status", false);
            request.AddParameter("systemRole", "");
            request.AddParameter("title", "");
            request.AddParameter("uniqueId", "");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(4)]
        public async Task Test_Post_Delete_User_On_Users_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/company/deleteuser");

            request.AddParameter("changePassword", true);
            request.AddParameter("companyId", companyId);
            request.AddParameter("email", email);
            request.AddParameter("firstName", firstName);
            request.AddParameter("hasAccount", hasAccount);
            request.AddParameter("id", id);
            request.AddParameter("isDeleted", isDeleted);
            request.AddParameter("lastName", lastName);
            request.AddParameter("mobilePhone", mobilePhone);
            request.AddParameter("role", role);
            request.AddParameter("roleChanged", roleChanged);
            request.AddParameter("status", status);
            request.AddParameter("systemRole", "");
            request.AddParameter("title", "");
            request.AddParameter("uniqueId", "");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(4)]
        public async Task Test_Post_Restore_User_On_Users_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/company/restoreuser");

            request.AddParameter("changePassword", changePassword);
            request.AddParameter("companyId", companyId);
            request.AddParameter("email", email);
            request.AddParameter("firstName", firstName);
            request.AddParameter("hasAccount", hasAccount);
            request.AddParameter("id", id);
            request.AddParameter("isDeleted", isDeleted);
            request.AddParameter("lastName", lastName);
            request.AddParameter("mobilePhone", mobilePhone);
            request.AddParameter("role", role);
            request.AddParameter("roleChanged", roleChanged);
            request.AddParameter("status", status);
            request.AddParameter("systemRole", "");
            request.AddParameter("title", "");
            request.AddParameter("uniqueId", "");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(5)]
        public async Task Test_Post_Update_User_On_Users_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/company/updateuser");

            request.AddParameter("changePassword", changePassword);
            request.AddParameter("companyId", companyId);
            request.AddParameter("email", email);
            request.AddParameter("firstName", "Updated First Name");
            request.AddParameter("hasAccount", hasAccount);
            request.AddParameter("id", id);
            request.AddParameter("isDeleted", isDeleted);
            request.AddParameter("lastName", "Updated Last name");
            request.AddParameter("mobilePhone", "0345");
            request.AddParameter("role", "Internal Auditor");
            request.AddParameter("roleChanged", roleChanged);
            request.AddParameter("status", status);
            request.AddParameter("systemRole", "User");
            request.AddParameter("title", "");
            request.AddParameter("uniqueId", "");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
