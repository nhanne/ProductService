using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using ProductService.Common.Response;
using ProductService.Common.Wrappers;
using ProductService.Domain.Abtractions;
using Serilog;
using System.Net;

namespace ProductService.Application.Handlers;

public class GlobalExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
                                                Exception exception,
                                                CancellationToken cancellationToken)
    {
        httpContext.Response.StatusCode = exception is BaseException e
                                          ? (int)e.StatusCode
                                          : (int)HttpStatusCode.InternalServerError;

        var response = await Response<Response>.FailAsync(new List<string> { exception.Message });
        Log.Error(exception.Message);
        await httpContext.Response.WriteAsJsonAsync(response, cancellationToken)
                                  .ConfigureAwait(false);

        return true;
    }
}