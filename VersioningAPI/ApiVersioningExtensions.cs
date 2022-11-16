using Microsoft.AspNetCore.Mvc;

namespace VersioningAPI;

internal static class ApiVersioningExtensions
{
    internal static IServiceCollection AddApiVersioningOptions(this IServiceCollection services)
    {
        return services.AddApiVersioning(opts =>
        {
            opts.AssumeDefaultVersionWhenUnspecified = true;
            opts.DefaultApiVersion = new ApiVersion(1, 0);
            opts.ReportApiVersions = true;
        });
    }

    internal static IServiceCollection AddApiExplorerOptions(this IServiceCollection services)
    {
        return services.AddVersionedApiExplorer(opts =>
        {
            opts.GroupNameFormat = "'v'VVV";
            opts.SubstituteApiVersionInUrl = true;
        });
    }
}