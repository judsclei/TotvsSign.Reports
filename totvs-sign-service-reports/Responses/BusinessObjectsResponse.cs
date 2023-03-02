namespace totvs_sign_service_reports.Responses
{
    public class BusinessObjectsResponse
    {
        public List<BusinessObject> Data { get; set; }
        public string NextPageUrl { get; set; }
    }

    public class BusinessObject
    { 
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public List<string>  Areas { get; set; }
        public string SchemaUrl { get; set; }
        public string DataUrl { get; set; }

    }
}
