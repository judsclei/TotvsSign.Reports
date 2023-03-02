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
                name = "acoesmkt01",
                displayName = "Ações de marketing",
                description = "Promover e divulgar novos produtos e serviços.",
                areas = new List<string>() { "Compras", "Marketing" },
                schemaUrl = "http://localhost/api/IntegratedProviderSample/objectschema/acoesdemarketing",
                dataUrl = "http://localhost/api/IntegratedProviderSample/objectdata/acoesdemarketing",
                properties = new List<PropertiesSchema>() { 
                    new PropertiesSchema(){ name = "CodigoDoProduto", displayName = "Código do Produto", description = "Código gerado pelo...", type = "string"},
                    new PropertiesSchema(){ name = "ValorDoProduto", displayName = "Valor do Produto", description = "Valor do Produto após...", type = "number", filter = new FilterPropertie(){ isRequired = false} },
                    new PropertiesSchema(){ name = "PerfilDoConsumidor", displayName = "Perfil do Consumidor", description = "Classificação do perfil de consumidor", type = "string", filter = new FilterPropertie(){ isRequired = true, optionsUrl = "http://localhost/api/IntegratedProviderSample/lookupdatakeylabel"} },
                },
                parameters = new List<ParametersSchema>() { 
                    new ParametersSchema(){ name = "ParamCodigoFilial", displayName = "Código da Filial", type = "number", multiValue = false },
                    new ParametersSchema(){ name = "ParamCodSecao", displayName = "Código da Seção", type = "string", multiValue = true },
                    new ParametersSchema(){ name = "ParamSituacao", displayName = "Código da Situação", type = "string", multiValue = true },
                    new ParametersSchema(){ name = "ParamUsaValeTransporte", displayName = "Usa Vale Transporte?", type = "boolean", multiValue = false }
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
                new DocumentsDataResponse() { nome = "nome 1"},
                new DocumentsDataResponse() { nome = "nome 2"},
                new DocumentsDataResponse() { nome = "nome 3"}
            };

            return response;
        }
    }
}
