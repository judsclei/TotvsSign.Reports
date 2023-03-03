namespace totvs_sign_service_reports.Responses
{
    public class SchemaResponse
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public List<string> Areas { get; set; }
        public string SchemaUrl { get; set; }
        public string DataUrl { get; set; }

        public List<PropertiesSchema> Properties { get; set; }
        public List<ParametersSchema> Parameters { get; set; }
    }

    public class PropertiesSchema
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public FilterPropertie Filter { get; set; }
    }

    public class FilterPropertie
    {
        public string OptionsUrl { get; set; }
        public bool IsRequired { get; set; }
    }

    public class ParametersSchema
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Type { get; set; }
        public bool MultiValue { get; set; }
    }
}
