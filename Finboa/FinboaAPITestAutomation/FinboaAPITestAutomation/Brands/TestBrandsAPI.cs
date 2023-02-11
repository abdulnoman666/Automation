using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestBrandsAPI
    {
        RestClient restClient = null;
        string id = string.Empty;

        [Test]
        public async Task Test_Get_Brands_On_Brands_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/brand");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Add_Brands_On_Brands_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/brand");

            request.AddParameter("address", "P-1105");
            request.AddParameter("brandName", "Automated Test Brand");
            request.AddParameter("charter", "C130");
            request.AddParameter("city","Rawalpindi");
            request.AddParameter("companyId", 2);
            request.AddParameter("email","abdul@finboa.com");
            request.AddParameter("fax", "0345");
            request.AddParameter("id", 0);
            request.AddParameter("logo", "");
            request.AddParameter("phone", "0332");
            request.AddParameter("state","Punjab");
            request.AddParameter("zip", "46000");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
        }

        [Test, Order(2)]
        public async Task Test_Post_Delete_Brands_On_Brands_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest($"api/brand/{id}/delete");

            request.AddParameter("address", "P-1105");
            request.AddParameter("brandName", "Automated Test Brand");
            request.AddParameter("charter", "C130");
            request.AddParameter("city", "Rawalpindi");
            request.AddParameter("companyId", 2);
            request.AddParameter("email", "abdul@finboa.com");
            request.AddParameter("fax", "0345");
            request.AddParameter("id", id);
            request.AddParameter("logo", "");
            request.AddParameter("phone", "0332");
            request.AddParameter("state", "Punjab");
            request.AddParameter("zip", "46000");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Brands_Page_On_Brands_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/brands.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Brands_Editor_Dialog_On_Brands_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/brands-edit-dialog.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
