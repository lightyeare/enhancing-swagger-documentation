using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace EnhancingSwagger;

internal class DocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        //you can manipulate various parts of the OpenApiDocument
        var schemaComponent = swaggerDoc.Components.Schemas.FirstOrDefault(x => x.Key=="CustomerRepresentation");
        schemaComponent.Value.Description = "Represents a Customer request and response. This description was added by the DocumentFilter.";
    }
}