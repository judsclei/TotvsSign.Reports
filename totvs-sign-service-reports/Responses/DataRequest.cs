namespace totvs_sign_service_reports.Responses
{
    public class GetDataRequest
    {
        public List<string> Properties { get; set; }
        public BusinessObjectFilter Filter { get; set; } = new BusinessObjectFilter();
        public BusinessObjectParameters Parameters { get; set; }= new BusinessObjectParameters();
    }

    public class BusinessObjectFilter
    {
        public string Operator { get; set; } = string.Empty;
        public string Property { get; set; } = string.Empty;
        public IEnumerable<object>? Values { get; set; }
        
        public List<BusinessObjectFilter> Conditions { get; set; } = new List<BusinessObjectFilter>();
    }

    public class BusinessObjectParameters
    {
    }
}
