using ProductService.Api.Extensions;
using Serilog;
using Serilog.Debugging;
try
{
    var builder = WebApplication.CreateBuilder(args);
    Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration)
                                                       .CreateLogger();

    SelfLog.Enable(msg => Log.Information(msg));
    Log.Information("Starting server.");

    var app = builder
        .ConfigureServices()
        .ConfigurePipeline(builder);

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "server terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}