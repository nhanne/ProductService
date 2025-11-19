namespace ProductService.Common.Response.HealthChecks;

public class HealthCheckResponse
{
    public string Status { get; set; } = string.Empty;
    public IEnumerable<IndividualHealthCheckResponse>? HealthChecks { get; set; }
    public TimeSpan HealthCheckDuration { get; set; }
}
