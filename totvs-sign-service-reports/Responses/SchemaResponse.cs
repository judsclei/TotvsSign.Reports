namespace totvs_sign_service_reports.Responses
{
    public class SchemaResponse
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public List<string> areas { get; set; }
        public string schemaUrl { get; set; }
        public string dataUrl { get; set; }

        public List<PropertiesSchema> properties { get; set; }
        public List<ParametersSchema> parameters { get; set; }
    }

    public class PropertiesSchema
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public FilterPropertie filter { get; set; }
    }

    public class FilterPropertie
    {
        public string optionsUrl { get; set; }
        public bool isRequired { get; set; }
    }

    public class ParametersSchema
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public string type { get; set; }
        public bool multiValue { get; set; }
    }
}
