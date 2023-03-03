namespace totvs_sign_service_reports.Responses
{
    public class GetFuncionarioRequest
    {
        public List<string> Properties { get; set; }
        public BusinessObjectFilter Filter { get; set; } = new BusinessObjectFilter();
    }


    public class GetDocumentsResquest
    {
        public List<string> Properties { get; set; }
        public BusinessObjectFilter Filter { get; set; } = new BusinessObjectFilter();
    }




    public class GetDocumentsByTenantResquest
    {
        public List<string> Properties { get; set; }
        public BusinessObjectFilter Filter { get; set; } = new BusinessObjectFilter();
        public DocumentsParameters Parameters { get; set; } = new DocumentsParameters();
    }
    public class DocumentsParameters
    {
        public List<string> tenantId { get; set; } = new List<string>();
    }






    public class BusinessObjectFilter
    {
        public string Operator { get; set; } = string.Empty;
        public string Property { get; set; } = string.Empty;
        public IEnumerable<object>? Values { get; set; }

        public List<BusinessObjectFilter> Conditions { get; set; } = new List<BusinessObjectFilter>();
    }

}
