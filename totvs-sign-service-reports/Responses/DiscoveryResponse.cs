namespace totvs_sign_service_reports.Responses
{
    public class DiscoveryResponse
    {
        public DiscoveryResponse()
        {
            
        }
        public DiscoveryResponse(string objectsUrl, string schemaUrl, string optionsUrl, string dataUrl)
        {
            ObjectsUrl = objectsUrl;
            SchemaUrl = schemaUrl;
            OptionsUrl = optionsUrl;
            DataUrl = dataUrl;
        }

        public string ObjectsUrl { get; set; }
        public string SchemaUrl { get; set; }
        public string OptionsUrl { get; set; }
        public string DataUrl { get; set; }
    }
}
