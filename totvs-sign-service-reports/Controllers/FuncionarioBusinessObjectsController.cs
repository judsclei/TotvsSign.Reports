using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using totvs_sign_service_reports.Mocks;
using totvs_sign_service_reports.Responses;

namespace totvs_sign_service_reports.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FuncionarioBusinessObjectsController : Controller
    {
        JsonSerializerOptions jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        [HttpGet]
        [Route("schema")]
        public SchemaResponse Schema()
        {

            var response = JsonSerializer.Deserialize<SchemaResponse>(Resource.FuncionarioSchemaString, jsonOptions);

            return response;
        }

        [HttpPost]
        [Route("data")]
        public TReportsDataResponse Data(GetDataRequest request)
        {
            var response = new TReportsDataResponse();
            response = JsonSerializer.Deserialize<TReportsDataResponse>(Resource.FuncionarioDataString, jsonOptions);

            return response;
        }




    }
}
