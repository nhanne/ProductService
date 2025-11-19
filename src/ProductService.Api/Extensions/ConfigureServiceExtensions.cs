using ProductService.Application.Handlers;
using ProductService.Infrastructure;
using Serilog;

namespace ProductService.Api.Extensions;

internal static partial class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        // Host Configuration
        builder.Host.UseSerilog();

        // Default Configuration
        builder.Services.AddHttpClient();
        builder.Services.AddControllers();

        // Custom Configuration
        
        builder.Services.AddExceptionHandler();
        builder.Services.AddSwaggerConfiguration();
        builder.Services.AddDatabaseConfiguration(builder.Configuration);
        builder.Services.AddHealthChecks().AddDbContextCheck<AppDbContext>();

        return builder.Build();
    }
}