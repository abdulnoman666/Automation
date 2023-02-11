using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using FinboaAPITestAutomation.AlertDefinitions;
using System;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestAlertDefinitionAPI
    {
        RestClient restClient = null;
        string id = null;
        string alertName = string.Empty;
        string alertType = string.Empty;
        string alertTypeString = string.Empty;
        string businessDays = string.Empty;
        string calculateTheLastBusinessDay = string.Empty;
        string companyId = string.Empty;
        string createdOn = string.Empty;
        string days = string.Empty;
        string deadlineReference = string.Empty;
        string reference = string.Empty;
        string sourceList = string.Empty;
        string tableName = string.Empty;
        string alertCriteria = string.Empty;
        string explanation = string.Empty;

        [Test, Order(1)]
        public async Task Test_Get_Alert_Definition_on_Alert_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/alertdefinition");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            //var item = JsonConvert.DeserializeObject<AlertDefinitions>(response.Content);
        }

        [Test, Order(2), Ignore("")]
        public async Task Test_Options_Alert_Definition_on_Alert_Definition_Page()
        {
            restClient = HelperFunctions.InitializeFinboaTemplatesAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/alertdefinition");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(3)]
        public async Task Test_Post_Add_Alert_Definition_on_Alert_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/alertdefinition");

            RequestHelper.CreateAlertDefinitionRequest(request, "Test Alert 1", "EARLYWARNING", true, false, "15", "ReportedOn > 15", "TA", "TestSourceList", "CustomerDisputes");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            alertCriteria = output["alertCriteria"];
            alertName = output["alertName"];
            alertType = output["alertType"];
            alertTypeString = output["alertTypeString"];
            businessDays = output["businessDays"];
            calculateTheLastBusinessDay = output["calculateTheLastBusinessDay"];
            companyId = output["companyId"];
            createdOn = output["createdOn"];
            days = output["days"];
            deadlineReference = output["deadlineReference"];
            explanation = output["explanation"];
            reference = output["reference"];
            sourceList = output["sourceList"];
            tableName = output["tableName"];
        }

        [Test, Order(4)]
        public async Task Test_Delete_Alert_Definition_on_Alert_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest($"api/alertdefinition/{id}/deletedefinition");

            RequestHelper.DeleteAlertDefinitionRequest(request, alertCriteria, alertName, alertType, alertTypeString, businessDays, calculateTheLastBusinessDay, companyId, createdOn, days, deadlineReference, explanation, id, reference, sourceList, tableName);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(5)]
        public async Task Test_Get_Alert_Definitions_on_Alert_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/alertdefinition.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(6)]
        public async Task Test_Get_Copy_Alert_Definitions_on_Alert_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var cRequest = HelperFunctions.CreateGetRequest("api/alertdefinition/109/copydefinition");

            var cResponse = await restClient.ExecuteAsync(cRequest);

            Assert.That(cResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var item = JsonConvert.DeserializeObject<AlertDefinition>(cResponse.Content);

            var dRequest = HelperFunctions.CreatePostRequest($"api/alertdefinition/{item.Id}/deletedefinition");

            RequestHelper.DeleteAlertDefinitionRequest(dRequest, null, item.AlertName, item.AlertType.ToString(), item.AlertTypeString, item.BusinessDays.ToString(), item.CalculateTheLastBusinessDay.ToString(), item.CompanyId.ToString(), item.CreatedOn, item.Days.ToString(), item.DeadlineReference, item.Explanation, item.Id.ToString(), item.Reference, item.SourceList, item.TableName);

            var response = await restClient.ExecuteAsync(dRequest);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(7), Ignore("")]
        public async Task Test_Post_Update_Alert_Definition_on_Alert_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            //Add the Alert
            var aRequest = HelperFunctions.CreatePostRequest("api/alertdefinition");

            RequestHelper.CreateAlertDefinitionRequest(aRequest, "Test Alert 1", "EARLYWARNING", true, false, "15", "ReportedOn > 15", "TA", "TestSourceList", "CustomerDisputes");

            var aResponse = await restClient.ExecuteAsync(aRequest);

            Assert.That(aResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var aOutput = HelperFunctions.DeserializeResponseToJson(aResponse);

            var aId = aOutput["id"];//172
            var aAlertCriteria = aOutput["alertCriteria"];//null
            //var aAlertName = aOutput["alertName"];
            var aAlertType = aOutput["alertType"];//0
            //var aAlertTypeString = aOutput["alertTypeString"];
            //var aBusinessDays = aOutput["businessDays"];
            //var aCalculateTheLastBusinessDay = aOutput["calculateTheLastBusinessDay"];
            var aCompanyId = aOutput["companyId"];//0
            var aCreatedOn = aOutput["createdOn"];
            //var aDays = aOutput["days"];
            //var aDeadlineReference = aOutput["deadlineReference"];
            var aExplanation = aOutput["explanation"];//null
            //var aReference = aOutput["reference"];
            //var aSourceList = aOutput["sourceList"];
            //var aTableName = aOutput["tableName"];

            //Modifying the Alert
            var uAlertName = "Test Alert Updated";
            var uAlertTypeString = "CRITICAL";
            var uBusinessDays = false;
            var uCalculateTheLastBusinessDay = true;
            var uDays = "0";
            var uDeadlineReference = "CreatedDate > 10";
            var uReference = "TU";
            var uSourceList = "DebitCard";
            var uTableName = "Disputes";

            var uRequest = HelperFunctions.CreatePostRequest("api/alertdefinition");

            var alertCriteria = Array.Empty<string>();

            //uRequest = RequestHelper.CreateUpdateAlertDefinitionRequest(uRequest, null, uAlertName, "1", uAlertTypeString, uBusinessDays, uCalculateTheLastBusinessDay, "2", aCreatedOn, uDays, uDeadlineReference, aExplanation, aId, uReference, uSourceList, uTableName);

            uRequest.AddParameter("alertCriteria", "");
            uRequest.AddParameter("alertName", uAlertName);
            uRequest.AddParameter("alertType", aAlertType);
            uRequest.AddParameter("alertTypeString", uAlertTypeString);
            uRequest.AddParameter("businessDays", uBusinessDays);
            uRequest.AddParameter("calculateTheLastBusinessDay", uCalculateTheLastBusinessDay);
            uRequest.AddParameter("companyId", 2);
            uRequest.AddParameter("createdOn", aCreatedOn);
            uRequest.AddParameter("days", uDays);
            uRequest.AddParameter("deadlineReference", uDeadlineReference);
            uRequest.AddParameter("explanation", aExplanation);
            uRequest.AddParameter("id", 179);
            uRequest.AddParameter("reference", uReference);
            uRequest.AddParameter("sourceList", uSourceList);
            uRequest.AddParameter("tableName", uTableName);

            var mResponse = await restClient.ExecuteAsync(uRequest);

            //Verify the modification
            var output = HelperFunctions.DeserializeResponseToJson(mResponse);

            var mId = output["id"];
            var mAlertCriteria = output["alertCriteria"];
            var mAlertName = output["alertName"];
            var mAlertType = output["alertType"];
            var mAlertTypeString = output["alertTypeString"];
            var mBusinessDays = output["businessDays"];
            var mCalculateTheLastBusinessDay = output["calculateTheLastBusinessDay"];
            var mCompanyId = output["companyId"];
            var mCreatedOn = output["createdOn"];
            var mDays = output["days"];
            var mDeadlineReference = output["deadlineReference"];
            var mExplanation = output["explanation"];
            var mReference = output["reference"];
            var mSourceList = output["sourceList"];
            var mTableName = output["tableName"];

            Assert.That(mAlertName, Is.EqualTo(uAlertName), "Alert Name does not match");

            Assert.That(mAlertTypeString, Is.EqualTo(uAlertTypeString), "Alert Type String does not match");

            Assert.That(mBusinessDays, Is.EqualTo(uBusinessDays), "Alert Type String does not match");

            Assert.That(mCalculateTheLastBusinessDay, Is.EqualTo(uCalculateTheLastBusinessDay), "Alert Name does not match");

            Assert.That(mDays, Is.EqualTo(uDays), "Alert Type String does not match");

            Assert.That(mDeadlineReference, Is.EqualTo(uDeadlineReference), "Alert Definition Deadline Reference String does not match");

            Assert.That(mSourceList, Is.EqualTo(uSourceList), "Alert Definition Source List does not match");

            Assert.That(mTableName, Is.EqualTo(uTableName), "Alert Definition Table Name does not match");

            Assert.That(mReference, Is.EqualTo(uReference), "Alert Definition Reference does not match");

            //deleting the alert definition

            var dRequest = HelperFunctions.CreatePostRequest($"api/alertdefinition/{mId}/deletedefinition");

            dRequest =  RequestHelper.DeleteAlertDefinitionRequest(dRequest, mAlertCriteria, mAlertName, mAlertType, mAlertTypeString, mBusinessDays, mCalculateTheLastBusinessDay, mCompanyId, mCreatedOn, mDays, mDeadlineReference, mExplanation, mId, mReference, mSourceList, mTableName);

            var dResponse = await restClient.ExecuteAsync(dRequest);

            Assert.That(dResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        }
    }
}
