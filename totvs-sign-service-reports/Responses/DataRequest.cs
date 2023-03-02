namespace totvs_sign_service_reports.Responses
{
    public class DataRequest
    {
        public List<string> properties { get; set; }
        public FilterRequest filter { get; set; }
        public ParametersRequest parameters { get; set; }
    }

    public class FilterRequest
    {
    }

    public class ParametersRequest
    {
    }
}
