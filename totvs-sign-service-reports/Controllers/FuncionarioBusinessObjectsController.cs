using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using totvs_sign_service_reports.Mocks;
using totvs_sign_service_reports.Responses;

namespace totvs_sign_service_reports.Controllers
{
    public class FuncionarioBusinessObjectsController : Controller
    {
        [HttpGet]
        [Route("schema")]
        public SchemaResponse Schema()
        {

            var response = JsonSerializer.Deserialize<SchemaResponse>(Resource.FuncionarioSchemaString);

            return response;
        }

        [HttpPost]
        [Route("data")]
        public TReportsDataResponse Data(DataRequest request)
        {
            var response = new TReportsDataResponse();
            response = JsonSerializer.Deserialize<TReportsDataResponse>(Resource.FuncionarioDataString);

            return response;
        }




    }
}
