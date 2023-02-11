using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace ExceptionTrackingEntities
{
    public static class RequestHelperForET
    {
        public static RestRequest CreateOpenExceptionSearchFilterRequest(RestRequest request, int pagenumber, int itemsperpage, string searchBy, string startDate, string endDate, string checklistId, string lastActivityEndDate, string lastActivityStartDate, string productId, string userId)
        {
            request.AddJsonBody(new
            {
                PageNumber = pagenumber,
                ItemsPerPage = itemsperpage,
                SearchBy = searchBy,
                StartDate = startDate,
                EndDate = endDate,
                ChecklistId = checklistId,
                LastActivityEndDate = lastActivityEndDate,
                LastActivityStartDate = lastActivityStartDate,
                ProductId = productId,
                UserId = userId
            });

            return request;
        }
    }
}
