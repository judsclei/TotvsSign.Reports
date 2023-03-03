using totvs_sign_service_reports.Entity;

namespace totvs_sign_service_reports.Responses
{
    public class TReportsDataResponse
    {
        public object data { get; set; }
        public string nextPageUrl { get; set; }
    }

    public class DocumentsDataResponse 
    {
        public DocumentsDataResponse()
        {
            data = new List<Documents>();
            nextPageUrl = string.Empty;
        }
        public List<Documents> data { get; set; }
        public string nextPageUrl { get; set; }
    }
}
