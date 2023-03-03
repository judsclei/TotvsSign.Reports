using Microsoft.AspNetCore.Mvc;
using totvs_sign_service_reports.Responses;

namespace totvs_sign_service_reports.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DocumentsBusinessObjectsController : Controller
    {
        [HttpGet]
        [Route("schema")]
        public SchemaResponse Schema()
        {
            var response = new SchemaResponse()
            {
                Name = "acoesmkt01",
                DisplayName = "Ações de marketing",
                Description = "Promover e divulgar novos produtos e serviços.",
                Areas = new List<string>() { "Compras", "Marketing" },
                SchemaUrl = "http://localhost/api/IntegratedProviderSample/objectschema/acoesdemarketing",
                DataUrl = "http://localhost/api/IntegratedProviderSample/objectdata/acoesdemarketing",
                Properties = new List<PropertiesSchema>() { 
                    new PropertiesSchema(){ Name = "CodigoDoProduto", DisplayName = "Código do Produto", Description = "Código gerado pelo...", Type = "string"},
                    new PropertiesSchema(){ Name = "ValorDoProduto", DisplayName = "Valor do Produto", Description = "Valor do Produto após...", Type = "number", Filter = new FilterPropertie(){ IsRequired = false} },
                    new PropertiesSchema(){ Name = "PerfilDoConsumidor", DisplayName = "Perfil do Consumidor", Description = "Classificação do perfil de consumidor", Type = "string", Filter = new FilterPropertie(){ IsRequired = true, OptionsUrl = "http://localhost/api/IntegratedProviderSample/lookupdatakeylabel"} },
                },
                Parameters = new List<ParametersSchema>() { 
                    new ParametersSchema(){ Name = "ParamCodigoFilial", DisplayName = "Código da Filial", Type = "number", MultiValue = false },
                    new ParametersSchema(){ Name = "ParamCodSecao", DisplayName = "Código da Seção", Type = "string", MultiValue = true },
                    new ParametersSchema(){ Name = "ParamSituacao", DisplayName = "Código da Situação", Type = "string", MultiValue = true },
                    new ParametersSchema(){ Name = "ParamUsaValeTransporte", DisplayName = "Usa Vale Transporte?", Type = "boolean", MultiValue = false }
                }
            };

            return response;
        }

        [HttpPost]
        [Route("data")]
        public TReportsDataResponse Data()
        {
            var response = new TReportsDataResponse();
            response.data = new List<DocumentsDataResponse>
            {
                new DocumentsDataResponse() { Nome = "nome 1"},
                new DocumentsDataResponse() { Nome = "nome 2"},
                new DocumentsDataResponse() { Nome = "nome 3"}
            };

            return response;
        }
    }
}
