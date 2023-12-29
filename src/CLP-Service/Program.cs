using CLPService.Services.Swagger;
using System.Text.Json.Serialization;

namespace CLPService;

/// <summary>
/// Main entry
/// </summary>
public class Program
{
    /// <summary>
    /// Main entry
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        SetupServices(builder.Services);
        var app = builder.Build();
        SetupApp(app);
        app.Run();
    }

    private static void SetupServices(IServiceCollection services)
    {
        // TODO: AddApiVersioningConfigured

        services
            .AddControllers()
            .AddJsonOptions(options =>
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter())
            );

        services.AddSwaggerSupport();
    }

    private static void SetupApp(WebApplication app)
    {
        app.MapControllers();
        app.UseSwagger();
        app.UseSwaggerUI();
    }
}
