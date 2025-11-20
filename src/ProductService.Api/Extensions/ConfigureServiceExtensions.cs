using FluentValidation;
using ProductService.Application.Handlers;
using ProductService.Application.Mappers;
using ProductService.Infrastructure;
using Serilog;

namespace ProductService.Api.Extensions;

internal static partial class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        // Host Configuration
        builder.Host.UseSerilog();
        builder.Host.AddAutoFacConfiguration();

        // Default Configuration
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            });
        });
        builder.Services.AddHttpClient();
        builder.Services.AddControllers();
        builder.Services.AddAutoMapper(typeof(ProductAutoMapperProfile).Assembly);
        builder.Services.AddValidatorsFromAssembly(typeof(ProductAutoMapperProfile).Assembly);

        // Custom Configuration
        
        builder.Services.AddExceptionHandler();
        builder.Services.AddSwaggerConfiguration();
        builder.Services.AddMediatRConfiguration();
        builder.Services.AddDatabaseConfiguration(builder.Configuration);
        builder.Services.AddHealthChecks().AddDbContextCheck<AppDbContext>();

        return builder.Build();
    }
}