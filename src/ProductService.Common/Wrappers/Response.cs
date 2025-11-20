namespace ProductService.Common.Wrappers;

public class Response : IResponse
{
    public Response()
    {
    }
    public bool Succeeded { get; set; }
    public List<string> Errors { get; set; } = [];
    public string Message { get; set; } = string.Empty;

    public static IResponse Fail()
    {
        return new Response { Succeeded = false };
    }

    public static IResponse Fail(string message)
    {
        return new Response { Succeeded = false, Message = message };
    }

    public static IResponse Fail(List<string> errors)
    {
        return new Response { Succeeded = false, Errors = errors };
    }

    public static Task<IResponse> FailAsync()
    {
        return Task.FromResult(Fail());
    }

    public static Task<IResponse> FailAsync(string message)
    {
        return Task.FromResult(Fail(message));
    }

    public static Task<IResponse> FailAsync(List<string> errors)
    {
        return Task.FromResult(Fail(errors));
    }

    public static IResponse Success()
    {
        return new Response { Succeeded = true };
    }

    public static IResponse Success(string message)
    {
        return new Response { Succeeded = true, Message = message };
    }

    public static Task<IResponse> SuccessAsync()
    {
        return Task.FromResult(Success());
    }

    public static Task<IResponse> SuccessAsync(string message)
    {
        return Task.FromResult(Success(message));
    }
}
public class Response<T> : Response, IResponse<T>
{
    public Response()
    {
    }
    public Response(T data)
    {
        Succeeded = true;
        Message = string.Empty;
        Errors = [];
        Data = data;
    }
    public T Data { get; set; } = default!;

    public new static Response<T> Fail()
    {
        return new Response<T> { Succeeded = false };
    }

    public new static Response<T> Fail(string message)
    {
        return new Response<T> { Succeeded = false, Message = message };
    }

    public new static Response<T> Fail(List<string> errors)
    {
        return new Response<T> { Succeeded = false, Errors = errors, Message = "Something went wrong !" };
    }

    public new static Task<Response<T>> FailAsync()
    {
        return Task.FromResult(Fail());
    }

    public new static Task<Response<T>> FailAsync(string message)
    {
        return Task.FromResult(Fail(message));
    }

    public new static Task<Response<T>> FailAsync(List<string> errors)
    {
        return Task.FromResult(Fail(errors));
    }

    public new static Response<T> Success()
    {
        return new Response<T> { Succeeded = true };
    }

    public new static Response<T> Success(string message)
    {
        return new Response<T> { Succeeded = true, Message = message };
    }

    public static Response<T> Success(T data)
    {
        return new Response<T> { Succeeded = true, Data = data };
    }

    public static Response<T> Success(T data, string message)
    {
        return new Response<T> { Succeeded = true, Data = data, Message = message };
    }

    public static Response<T> Success(T data, List<string> errors)
    {
        return new Response<T> { Succeeded = true, Data = data, Errors = errors };
    }

    public new static Task<Response<T>> SuccessAsync()
    {
        return Task.FromResult(Success());
    }

    public new static Task<Response<T>> SuccessAsync(string message)
    {
        return Task.FromResult(Success(message));
    }

    public static Task<Response<T>> SuccessAsync(T data)
    {
        return Task.FromResult(Success(data));
    }

    public static Task<Response<T>> SuccessAsync(T data, string message)
    {
        return Task.FromResult(Success(data, message));
    }
}