using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using totvs_sign_service_reports.Responses;

namespace totvs_sign_service_reports.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DocumentsBusinessObjectsController : Controller
    {
        JsonSerializerOptions jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string pathJsonData = $@"{Directory.GetCurrentDirectory()}\\Mocks\\assinaturaDigitalArquivosData.json";

        [HttpGet]
        [Route("schema")]
        public SchemaResponse Schema()
        {
            var response = new SchemaResponse()
            {
                Name = "acoesmkt01",
                DisplayName = "Schema - Documentos TOTVS Assinatura Eletrônica",
                Description = "Listagem de documentos do TOTVS Assinatura Eletrônica",
                Areas = new List<string>() { "TAE" },
                SchemaUrl = "http://localhost:16908/DocumentsBusinessObjects/schema",
                DataUrl = "http://localhost:16908/DocumentsBusinessObjects/data",
                Properties = new List<PropertiesSchema>() {
                    new PropertiesSchema(){ Name = "id", DisplayName = "Id. Documento", Description = "Identificador do documento", Type = "number"},
                    new PropertiesSchema(){ Name = "nomearquivo", DisplayName = "Nome Documento", Description = "Nome do documento", Type = "string", Filter = new FilterPropertie(){ IsRequired = false} },
                    new PropertiesSchema(){ Name = "status", DisplayName = "Status", Description = "Status do documento", Type = "string", Filter = new FilterPropertie(){ IsRequired = false} },
                    new PropertiesSchema(){ Name = "autor", DisplayName = "Autor", Description = "Autor do documento", Type = "string", Filter = new FilterPropertie(){ IsRequired = false} },
                    new PropertiesSchema(){ Name = "datacriacao", DisplayName = "Data de criação", Description = "Data de criação do documento", Type = "date", Filter = new FilterPropertie(){ IsRequired = false} },
                    new PropertiesSchema(){ Name = "nomeempresa", DisplayName = "Empresa", Description = "Empresa proprietária do documento", Type = "string", Filter = new FilterPropertie(){ IsRequired = false } },
                    new PropertiesSchema(){ Name = "tenantid", DisplayName = "Tennti Id", Description = "Identificador da Empresa", Type = "string", Filter = new FilterPropertie(){ IsRequired = false} },
                }
            };

            return response;
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
