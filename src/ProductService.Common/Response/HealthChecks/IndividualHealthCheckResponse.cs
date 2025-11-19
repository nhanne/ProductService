namespace ProductService.Common.Response.HealthChecks;

public class IndividualHealthCheckResponse
{
    public string Status { get; set; } = string.Empty;
    public string Component { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}