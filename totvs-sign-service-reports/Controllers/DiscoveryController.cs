using Microsoft.AspNetCore.Mvc;
using totvs_sign_service_reports.Responses;
using static System.Net.WebRequestMethods;

namespace totvs_sign_service_reports.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DiscoveryController : Controller
    {

        [HttpGet]
        [Route(".well-known/treports/connector")]
        public DiscoveryResponse WellKnown()
        {
            var response = new DiscoveryResponse()
            {
                ObjectsUrl = "http://localhost:16908/Discovery/BusinessObjects",
                SchemaUrl = "",
                OptionsUrl = "",
                DataUrl = ""
            };

            return response;
        }

        [HttpGet]
        [Route("BusinessObjects")]
        public BusinessObjectsResponse BusinessObjects()
        {
            var bussinessObjects = new List<BusinessObject>() {

                new BusinessObject() {
                    Name = "funcionarios",
                    DisplayName = "Objeto de Negócio - Funcionários",
                    Description = "Objeto de negócio para entidade Funciónários.",
                    Areas = new List<string>() { "RH" },
                    SchemaUrl = "http://localhost:16908/FuncionarioBusinessObjects/schema",
                    DataUrl = "http://localhost:16908/FuncionarioBusinessObjects/data"
                },

                new BusinessObject() {
                    Name = "documentos",
                    DisplayName = "Objeto de Negócio - Documentos TOTVS Assinatura Eletrônica",
                    Description = "Objeto de negócio para listagem de documentos do TOTVS Assinatura Eletrônica.",
                    Areas = new List<string>() { "TAE" },
                    SchemaUrl = "http://localhost:16908/DocumentsBusinessObjects/schema",
                    DataUrl = "http://localhost:16908/DocumentsBusinessObjects/data",
                }
            };

            var result = new BusinessObjectsResponse() { Data = bussinessObjects };
            return result;
        }

    }
}
