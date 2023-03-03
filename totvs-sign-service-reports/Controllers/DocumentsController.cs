using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using totvs_sign_service_reports.Entity;
using totvs_sign_service_reports.Responses;

namespace totvs_sign_service_reports.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DocumentsController : Controller
    {
        JsonSerializerOptions jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string pathJsonData = $@"{Directory.GetCurrentDirectory()}\\Mocks\\assinaturaDigitalArquivosData.json";

        [HttpGet]
        [Route("schema")]
        public SchemaResponse Schema()
        {
            var response = new SchemaResponse()
            {
                Name = "documentos",
                DisplayName = "Schema - Documentos do TOTVS Assinatura Eletrônica",
                Description = "Listagem de documentos do TOTVS Assinatura Eletrônica",
                Areas = new List<string>() { "TAE" },
                SchemaUrl = "http://localhost:16908/Documents/schema",
                DataUrl = "http://localhost:16908/Documents/data",
                Properties = new List<PropertiesSchema>() {
                    new PropertiesSchema(){ Name = "id", DisplayName = "Id. Documento", Description = "Identificador do documento", Type = "number"},
                    new PropertiesSchema(){ Name = "nomeArquivo", DisplayName = "Nome Documento", Description = "Nome do documento", Type = "string", Filter = new FilterPropertie(){ IsRequired = false} },
                    new PropertiesSchema(){ Name = "status", DisplayName = "Status", Description = "Status do documento", Type = "string", Filter = new FilterPropertie(){ IsRequired = false} },
                    new PropertiesSchema(){ Name = "autor", DisplayName = "Autor", Description = "Autor do documento", Type = "string", Filter = new FilterPropertie(){ IsRequired = false} },
                    new PropertiesSchema(){ Name = "dataCriacao", DisplayName = "Data de criação", Description = "Data de criação do documento", Type = "date", Filter = new FilterPropertie(){ IsRequired = false} },
                    new PropertiesSchema(){ Name = "nomeEmpresa", DisplayName = "Empresa", Description = "Empresa proprietária do documento", Type = "string", Filter = new FilterPropertie(){ IsRequired = false } },
                    new PropertiesSchema(){ Name = "tenantId", DisplayName = "Tennti Id", Description = "Identificador da Empresa", Type = "string", Filter = new FilterPropertie(){ IsRequired = false} },
                }
            };

            return response;
        }

        [HttpPost]
        [Route("data")]
        public TReportsDataResponse Data(GetDocumentsResquest request)
        {
            using (StreamReader r = new StreamReader(pathJsonData))
            {
                var jsonData = r.ReadToEnd();

                var documentos = JsonSerializer.Deserialize<List<Documents>>(jsonData, jsonOptions);

                var result = new TReportsDataResponse();
                result.data = documentos.ToArray();

                return result;
            }
        }
    }
}
