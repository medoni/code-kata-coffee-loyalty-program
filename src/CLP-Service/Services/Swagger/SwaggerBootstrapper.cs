using CLPService.Modules.Customer.UseCases.ManageCustomer.Api.Dtos;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;

namespace CLPService.Services.Swagger;

internal static class SwaggerBootstrapper
{
    public static IServiceCollection AddSwaggerSupport(
        this IServiceCollection services
    )
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerExamples();
        services.AddSwaggerExamplesFromAssemblyOf<CustomerCreatedDtoExample>();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "API for locality coffee program",
                Description = "An ASP.NET Core Web API for code kata implementing loyalty coffee program",
                Contact = new OpenApiContact
                {
                    Name = "medoni",
                    Url = new Uri("https://github.com/medoni/code-kata-coffee-loyalty-program")
                }
            });

            options.ExampleFilters();

            // using System.Reflection;
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });

        return services;
    }


}