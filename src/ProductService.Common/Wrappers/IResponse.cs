namespace ProductService.Common.Wrappers;

public interface IResponse
{
    bool Succeeded { get; set; }
    List<string> Errors { get; set; }
    string Message { get; set; }
}
public interface IResponse<out T> : IResponse
{
    T Data { get; }
}