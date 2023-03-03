using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using totvs_sign_service_reports.Responses;

namespace totvs_sign_service_reports.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FuncionarioBusinessObjectsController : Controller
    {
        JsonSerializerOptions jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string pathJsonSchema = $@"{Directory.GetCurrentDirectory()}\\Mocks\\funcionarioSchema.json";
        string pathJsonData = $@"{Directory.GetCurrentDirectory()}\\Mocks\\funcionarioData.json";

        [HttpGet]
        [Route("schema")]
        public SchemaResponse Schema()
        {
            using (StreamReader r = new StreamReader(pathJsonSchema))
            {
                var jsonData = r.ReadToEnd();
                return JsonSerializer.Deserialize<SchemaResponse>(jsonData, jsonOptions);
            }
        }

        [HttpPost]
        [Route("data")]
        public TReportsDataResponse Data(GetDataRequest request)
        {
            using (StreamReader r = new StreamReader(pathJsonData))
            {
                var jsonData = r.ReadToEnd();

                return JsonSerializer.Deserialize<TReportsDataResponse>(jsonData, jsonOptions);
            }
        }




    }
}
