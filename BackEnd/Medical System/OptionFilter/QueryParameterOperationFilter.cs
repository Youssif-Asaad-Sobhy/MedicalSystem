using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Medical_System.OptionFilter
{
    public class QueryParameterOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var parametersToRemove = operation.Parameters?.Where(p => p.In == ParameterLocation.Query).ToList();
            parametersToRemove?.ForEach(p => operation.Parameters.Remove(p));

            var parameters = context.ApiDescription.ParameterDescriptions
                .Where(p => p.Source.Id == "Query")
                .ToList();

            if (parameters.Any())
            {
                operation.Parameters ??= new List<OpenApiParameter>();
                foreach (var parameter in parameters)
                {
                    var openApiParameter = new OpenApiParameter
                    {
                        Name = parameter.Name,
                        In = ParameterLocation.Query,
                        Required = parameter.IsRequired,
                        Schema = context.SchemaGenerator.GenerateSchema(parameter.Type, context.SchemaRepository)
                    };

                    operation.Parameters.Add(openApiParameter);
                }
            }
        }

    }
}
