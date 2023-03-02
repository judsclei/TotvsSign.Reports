using Microsoft.AspNetCore.Mvc;
using totvs_sign_service_reports.Responses;

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
                SchemaUrl = "https://localhost/api/{bussiness-object-name}/something-else",
                OptionsUrl = "https://localhost/api/{bussiness-object-name}/something-else/{property-name}/filter",
                DataUrl = "https://localhost/api/{bussiness-object-name}/data"
            };

            return response;
        }

        [HttpGet]
        [Route("BusinessObjects")]
        public BusinessObjectsResponse BusinessObjects()
        {
            var bussinessObjects = new List<BusinessObject>() {

                new BusinessObject() {
                    Name = "acoesmkt01",
                    DisplayName = "Ações de marketing",
                    Description = "Promover e divulgar novos produtos e serviços.",
                    Areas = new List<string>() { "Compras", "Marketing" },
                    SchemaUrl = "http://localhost/api/IntegratedProviderSample/objectschema/acoesdemarketing",
                    DataUrl = "https://localhost/api/acoesmkt01/data"
                },

                new BusinessObject() {
                    Name = "gestaostoques",
                    DisplayName = "Gestão de estoques",
                    Description = "Gerenciamento dos processos de compras e otimização da operação.",
                    Areas = new List<string>() {  "Financeiro", "Compras", "Expedição"},
                    SchemaUrl = "http://localhost/api/IntegratedProviderSample/objectschema/gestaodeestoques",
                    DataUrl = "https://localhost/api/gestaostoques/data"
                },


                new BusinessObject() {
                    Name = "funcionarios",
                    DisplayName = "Objeto de Negócio - Funcionários",
                    Description = "Objeto de negócio para entidade Funciónários.",
                    Areas = new List<string>() {  "Financeiro", "Compras", "Expedição"},
                    SchemaUrl = "http://localhost:16908/schema",
                    DataUrl = "http://localhost:16908/data"
                }
            };

            var result = new BusinessObjectsResponse() { Data = bussinessObjects };
            return result;
        }

    }
}
