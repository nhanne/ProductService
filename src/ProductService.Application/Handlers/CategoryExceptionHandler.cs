using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using ProductService.Common.Response;
using ProductService.Common.Wrappers;
using ProductService.Domain.Exceptions.Categories;

namespace ProductService.Application.Handlers;

public class CategoryExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
                                                Exception exception,
                                                CancellationToken cancellationToken)
    {
        if (exception is CategoryNotFoundException notFoundException)
            return await HandleExceptionAsync(httpContext, notFoundException, cancellationToken);
        if (exception is CategoryExistException existException)
            return await HandleExceptionAsync(httpContext, existException, cancellationToken);

        return false;
    }
    private async Task<bool> HandleExceptionAsync(HttpContext httpContext,
                                                  Exception exception,
                                                  CancellationToken cancellationToken)
    {
        var response = await Response<Response>.FailAsync(new List<string> { exception.Message });
        httpContext.Response.StatusCode = (int)((dynamic)exception).StatusCode;
        await httpContext.Response.WriteAsJsonAsync(response, cancellationToken)
                                  .ConfigureAwait(false);

        return true;
    }
}
